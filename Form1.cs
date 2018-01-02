using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using NetworkTables;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using INI;
using System.Diagnostics;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge;
using AForge.Imaging;
using System.IO;


namespace indecoTarget
{
    public partial class frmMain : Form
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource = null;
        MJPEGStream stream = null;
        bool capVideoInProgress = false;
        static double DFOV = 68.5;
        static double HFOV = 54.8;
        private double STEERMIN = (HFOV / 2.0) * -1;
        private double STEERMAX = HFOV / 2.0;
        private double HorizontalDegreesPerPixel = 0.0;
        private int cameraSelected = 0;
        private double HueLow = 80;
        private double HueHigh = 250;
        private double SatLow = 0.5;
        private double SatHigh = 1;
        private double ValLow = 0.3;
        private double ValHigh = 1;
        private double AreaLow = 1500;
        private double AreaHigh = 5000;
        private double AspectRatioLow = 0.5;
        private double AspectRatioHigh = 2.5;
        private double WidthLow = 0;
        private double WidthHigh = 1000;
        private double HeightLow = 0;
        private double HeightHigh = 1000;
        private double targetX = 0;
        private double targetY = 0;
        private double targetAngle = 0;
        private double targetSteer = 0;
        private bool targetVisible = false;
        private double targetArea;
        private double targetAspectRatio;
        private int targetWidth;
        private int targetHeight;
        private double targetDistance;
        private bool colorRequested;
        private int colorX;
        private int colorY;
        private double focal = 0;
        private double calHeight = 1;
        private double calDistance = 12;
        private double outputFilter = 0.25;
        double hue = 0;
        double sat = 0;
        double lum = 0;
        NetworkTable nt;

        /*
         * 
         *    MS LifeCam HD 3000  
         *    Diagonal Field of View = 68.5
         *    Diagonal_Pixels = sqrt((FRAME_WIDTH_PIXELS * FRAME_WIDTH_PIXELS) + (FRAME_HEIGHT_PIXELS * FRAME_HEIGHT_PIXELS));
         *    = 400
         *    Vertical Field of View = (DFOV * FRAME_HEIGHT_PIXELS) / Diagonal_Pixels;
         *    = 
         *    Horizontal Field of View  = (DFOV * FRAME_WIDTH_PIXELS) / Diagonal_Pixels;
         *    = 54.8
         * 
         */

        public frmMain()
        {
            InitializeComponent();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            Application.Idle += Application_Idle;
        }

        public void Log(string s)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(System.IO.Path.ChangeExtension(System.IO.Path.GetFullPath(Application.ExecutablePath), "log"), true))
                {
                    writer.WriteLine("[" + Convert.ToString(DateTime.Now) + "] " + s);
                }
            }
            catch { }
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                IniFile ini = new IniFile(path + "\\indecoTarget.ini");
                this.Width = Convert.ToInt32(ini.IniReadValue("Application", "Width"));
                this.Height = Convert.ToInt32(ini.IniReadValue("Application", "Height"));
                this.Left = Convert.ToInt32(ini.IniReadValue("Application", "Left"));
                this.Top = Convert.ToInt32(ini.IniReadValue("Application", "Top"));
                splitContainer1.SplitterDistance = Convert.ToInt32(ini.IniReadValue("Application", "Splitter1"));
                splitContainer2.SplitterDistance = Convert.ToInt32(ini.IniReadValue("Application", "Splitter2"));
            }
            catch { };
            ReadSetup();
            nudHueL.Value = Convert.ToDecimal(HueLow);
            nudHueH.Value = Convert.ToDecimal(HueHigh);
            nudSatL.Value = Convert.ToDecimal(SatLow);
            nudSatH.Value = Convert.ToDecimal(SatHigh);
            nudValL.Value = Convert.ToDecimal(ValLow);
            nudValH.Value = Convert.ToDecimal(ValHigh);
            nudAreaL.Value = Convert.ToDecimal(AreaLow);
            nudAreaH.Value = Convert.ToDecimal(AreaHigh);
            nudAreaRatioL.Value = Convert.ToDecimal(AspectRatioLow);
            nudAreaRatioH.Value = Convert.ToDecimal(AspectRatioHigh);
            nudCalHeight.Value = Convert.ToDecimal(calHeight);
            nudCalDistance.Value = Convert.ToDecimal(calDistance);
            cmbCamera.SelectedIndex = cameraSelected;
            tbOutputFilter.Value = Convert.ToInt32(outputFilter * 100);
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            try
            {
                lblTargetArea.Text = targetArea.ToString("N0");
                lblTargetAreaRatio.Text = targetAspectRatio.ToString("N2");
                lblTargetWidth.Text = targetWidth.ToString("N0");
                lblTargetHeight.Text = targetHeight.ToString("N0");
                lblTargetX.Text = "X: " + targetX.ToString("N0");
                lblTargetY.Text = "Y: " + targetY.ToString("N0");
                if (targetVisible) lblTargetVisible.BackColor = Color.Lime;
                else lblTargetVisible.BackColor = Color.Red;
                try
                {
                    if (nt.IsConnected) lblNetworkTables.BackColor = Color.Lime;
                    else lblNetworkTables.BackColor = Color.Red;
                }
                catch { }
                lblTargetDistance.Text = "Distance: " + targetDistance.ToString("N0");
                lblTargetAngle.Text = "Angle: " + targetAngle.ToString("N0");
                lblTargetSteer.Text = "Steer: " + targetSteer.ToString("N2");
                if (tabMain.SelectedTab.Name == "tpCalibration")
                {
                    lblCalibrateHeight.Text = "Height: " + targetHeight.ToString("N0");
                    lblCalibrateDistance.Text = lblTargetDistance.Text;
                    btnCalibrate.Enabled = nudCalDistance.Value > 0;
                    lblFocal.Text = "Focal: " + focal.ToString();
                    lblCalHeight.Text = "calHeight: " + calHeight.ToString();
                    lblCalDistance.Text = "calDist: " + calDistance.ToString();
                }
                if (tabMain.SelectedTab.Name == "tpSetup")
                {
                    lblSetCalHeight.Text = "calHeight: " + calHeight.ToString();
                    lblSetCalDistance.Text = "calDist: " + calDistance.ToString();
                    lblSetCalFocal.Text = "calFocal: " + focal.ToString();
                    lblSetHueLow.Text = "HueLow: " + HueLow.ToString("N0");
                    lblSetHueHigh.Text = "HueHigh: " + HueHigh.ToString("N0");
                    lblSetSatLow.Text = "SatLow: " + SatLow.ToString("N2");
                    lblSetSatHigh.Text = "SatHigh: " + SatHigh.ToString("N2");
                    lblSetValLow.Text = "ValLow: " + ValLow.ToString("N2");
                    lblSetValHigh.Text = "ValHigh: " + ValHigh.ToString("N2");
                    lblSetAreaLow.Text = "AreaLow: " + AreaLow.ToString("N0");
                    lblSetAreaHigh.Text = "AreaHigh: " + AreaHigh.ToString("N0");
                    lblSetAreaEnabled.Text = "AreaEnabled: " + Convert.ToString(cbUseAreaFilter.Checked);
                    lblSetAreaRatioLow.Text = "AspecRatioLow: " + AspectRatioLow.ToString("N2");
                    lblSetAreaRatioHigh.Text = "AspectRatioHigh: " + AspectRatioHigh.ToString("N2");
                    lblSetAreaRatioEnabled.Text = "AspectRatioEnabled: " + Convert.ToString(cbUseAreaRatioFilter.Checked);
                    lblSetWidthLow.Text = "WidthLow: " + WidthLow.ToString("N0");
                    lblSetWidthHigh.Text = "WidthHigh: " + WidthHigh.ToString("N0");
                    lblSetWidthEnabled.Text = "WidthEnabled: " + Convert.ToString(cbUseWidthFilter.Checked);
                    lblSetHeightLow.Text = "HeightLow: " + HeightLow.ToString("N0");
                    lblSetHeightHigh.Text = "HeightHigh: " + HeightHigh.ToString("N0");
                    lblSetHeightEnabled.Text = "HeightEnabled: " + Convert.ToString(cbUseHeightFilter.Checked);
                    lblSetCamera.Text = "Camera: " + cmbCamera.Text;
                }
            }
            catch { };
        }

        bool isPingable(String addr)
        {
            try
            {
                Ping x = new Ping();
                PingReply reply = x.Send(addr);
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        public void ReadSetup()
        {
            try
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                IniFile ini = new IniFile(path + "\\indecoTarget.ini");

                cameraSelected = Convert.ToInt32(ini.IniReadValue("General", "Camera"));
                calHeight = Convert.ToDouble(ini.IniReadValue("General","CalibrationHeight"));
                calDistance = Convert.ToDouble(ini.IniReadValue("General", "CalibrationDistance"));
                focal = Convert.ToDouble(ini.IniReadValue("General", "CalibrationFocal"));
                txtNetworkTables.Text = ini.IniReadValue("General", "RoboRioAddress");
                txtIPCamera.Text = ini.IniReadValue("General", "AxisIPCameraAddress");
                HueLow = Convert.ToDouble(ini.IniReadValue("General", "HueLow"));
                HueHigh = Convert.ToDouble(ini.IniReadValue("General", "HueHigh"));
                SatLow = Convert.ToDouble(ini.IniReadValue("General", "SatLow"));
                SatHigh = Convert.ToDouble(ini.IniReadValue("General", "SatHigh"));
                ValLow = Convert.ToDouble(ini.IniReadValue("General", "ValLow"));
                ValHigh = Convert.ToDouble(ini.IniReadValue("General", "ValHigh"));
                AreaLow = Convert.ToDouble(ini.IniReadValue("General", "AreaLow"));
                AreaHigh = Convert.ToDouble(ini.IniReadValue("General", "AreaHigh"));
                cbUseAreaFilter.Checked = Convert.ToBoolean(ini.IniReadValue("General", "AreaEnabled"));
                AspectRatioLow = Convert.ToDouble(ini.IniReadValue("General", "AspectRatioLow"));
                AspectRatioHigh = Convert.ToDouble(ini.IniReadValue("General", "AspectRatioHigh"));
                cbUseAreaRatioFilter.Checked = Convert.ToBoolean(ini.IniReadValue("General", "AspectRatioEnabled"));
                WidthLow = Convert.ToDouble(ini.IniReadValue("General", "WidthLow"));
                WidthHigh = Convert.ToDouble(ini.IniReadValue("General", "WidthHigh"));
                cbUseWidthFilter.Checked = Convert.ToBoolean(ini.IniReadValue("General", "WidthEnabled"));
                HeightLow = Convert.ToDouble(ini.IniReadValue("General", "HeightLow"));
                HeightHigh = Convert.ToDouble(ini.IniReadValue("General", "HeightHigh"));
                cbUseHeightFilter.Checked = Convert.ToBoolean(ini.IniReadValue("General", "HeightEnabled"));
                outputFilter = Convert.ToDouble(ini.IniReadValue("General", "OutputFilter"));
            }
            catch (Exception ex)
            {
                Log("[ReadSetup] " + ex.Message);
            }
        }

        public void WriteSetup()
        {
            try
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                IniFile ini = new IniFile(path + "\\indecoTarget.ini");
                ini.IniWriteValue("General", "Camera", cameraSelected.ToString());
                ini.IniWriteValue("General", "CalibrationHeight", calHeight.ToString());
                ini.IniWriteValue("General", "CalibrationDistance", calDistance.ToString());
                ini.IniWriteValue("General", "CalibrationFocal", focal.ToString());
                ini.IniWriteValue("General", "RoboRioAddress", txtNetworkTables.Text);
                ini.IniWriteValue("General", "AxisIPCameraAddress", txtIPCamera.Text);
                ini.IniWriteValue("General", "HueLow", HueLow.ToString());
                ini.IniWriteValue("General", "HueHigh", HueHigh.ToString());
                ini.IniWriteValue("General", "SatLow", SatLow.ToString());
                ini.IniWriteValue("General", "SatHigh", SatHigh.ToString());
                ini.IniWriteValue("General", "ValLow", ValLow.ToString());
                ini.IniWriteValue("General", "ValHigh", ValHigh.ToString());
                ini.IniWriteValue("General", "AreaLow", AreaLow.ToString());
                ini.IniWriteValue("General", "AreaHigh", AreaHigh.ToString());
                ini.IniWriteValue("General", "AreaEnabled", cbUseAreaFilter.Checked.ToString());
                ini.IniWriteValue("General", "AspectRatioLow", AspectRatioLow.ToString());
                ini.IniWriteValue("General", "AspectRatioHigh", AspectRatioHigh.ToString());
                ini.IniWriteValue("General", "AspectRatioEnabled", cbUseAreaRatioFilter.Checked.ToString());
                ini.IniWriteValue("General", "WidthLow", WidthLow.ToString());
                ini.IniWriteValue("General", "WidthHigh", WidthHigh.ToString());
                ini.IniWriteValue("General", "WidthEnabled", cbUseWidthFilter.Checked.ToString());
                ini.IniWriteValue("General", "HeightLow", HeightLow.ToString());
                ini.IniWriteValue("General", "HeightHigh", HeightHigh.ToString());
                ini.IniWriteValue("General", "HeightEnabled", cbUseHeightFilter.Checked.ToString());
                ini.IniWriteValue("General", "OutputFilter", outputFilter.ToString());
            }
            catch (Exception ex)
            {
                Log("[WriteSetup] " + ex.Message);
            }
        }

        private void StopVideo(int cam)
        {
            switch (cam)
            {
                case 0:
                    vspTarget.SignalToStop();
                    vspTarget.WaitForStop();
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    break;
                case 1:
                case 2:
                case 3:
                    vspTarget.SignalToStop();
                    vspTarget.WaitForStop();
                    stream.SignalToStop();
                    stream.WaitForStop();
                    break;
            }
            btnCapture.Text = "Start";
            capVideoInProgress = false;
            cmbCamera.Enabled = true;
        }

        private void StartVideo(int cam)
        {
            switch (cam)
            {
                case 0:
                    if (videoDevices.Count == 0) throw new Exception("No USB Camera available");
                    if (videoSource != null) videoSource.WaitForStop();
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString); //local USB
                    vspTarget.VideoSource = videoSource;
                    vspTarget.Start();
                    btnCapture.Text = "Stop";
                    capVideoInProgress = true;
                    cmbCamera.Enabled = false;
                    break;
                case 1:
                    //if (!isPingable(txtNetworkTables.Text)) throw new Exception("Camera is not available");
                    if (stream != null) stream.WaitForStop();
                    stream = new MJPEGStream("http://" + txtNetworkTables.Text + ":1181/?action=stream");
                    vspTarget.VideoSource = stream;
                    vspTarget.Start();
                    btnCapture.Text = "Stop";
                    capVideoInProgress = true;
                    cmbCamera.Enabled = false;
                    break;
                case 2:
                    //if (!isPingable(txtNetworkTables.Text)) throw new Exception("Camera is not available");
                    if (stream != null) stream.WaitForStop();
                    stream = new MJPEGStream("http://" + txtNetworkTables.Text + ":1182/?action=stream");
                    vspTarget.VideoSource = stream;
                    vspTarget.Start();
                    btnCapture.Text = "Stop";
                    capVideoInProgress = true;
                    cmbCamera.Enabled = false;
                    break;
                case 3:
                    //if (!isPingable(txtIPCamera.Text)) throw new Exception("Camera is not available");
                    if (stream != null) stream.WaitForStop();
                    stream = new MJPEGStream("http://" + txtIPCamera.Text + "/mjpg/video.mjpg");
                    vspTarget.VideoSource = stream;
                    vspTarget.Start();
                    btnCapture.Text = "Stop";
                    capVideoInProgress = true;
                    cmbCamera.Enabled = false;
                    break;
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {   
            try
            {
                if (capVideoInProgress)
                {   //stop the capture
                    StopVideo(cmbCamera.SelectedIndex);
                    NetworkTable.Shutdown();
                }
                else
                {   //start the capture
                    StartVideo(cmbCamera.SelectedIndex);
                    try
                    {
                        NetworkTable.SetIPAddress(txtNetworkTables.Text);
                        NetworkTable.SetClientMode();
                        NetworkTable.Initialize();
                        nt = NetworkTable.GetTable("indecoTarget");
                    }
                    catch { };
                }
            }
            catch { };
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (videoSource != null)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
                if (stream != null)
                {
                    stream.SignalToStop();
                    stream.WaitForStop();
                }
                vspTarget.SignalToStop();
                vspTarget.WaitForStop();
            }
            catch { };
            try
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                IniFile ini = new IniFile(path + "\\indecoTarget.ini");
                ini.IniWriteValue("Application", "Width", this.Width.ToString());
                ini.IniWriteValue("Application", "Height", this.Height.ToString());
                ini.IniWriteValue("Application", "Left", this.Left.ToString());
                ini.IniWriteValue("Application", "Top", this.Top.ToString());
                ini.IniWriteValue("Application", "Splitter1", splitContainer1.SplitterDistance.ToString());
                ini.IniWriteValue("Application", "Splitter2", splitContainer2.SplitterDistance.ToString());
            }
            catch { };
        }
                
        private void nudAreaL_ValueChanged(object sender, EventArgs e)
        {
            if (nudAreaL.Value < Convert.ToDecimal(AreaHigh))
                AreaLow = Convert.ToDouble(nudAreaL.Value);
            else
                nudAreaL.Value = Convert.ToDecimal(AreaHigh - 1.0);
        }

        private void nudAreaH_ValueChanged(object sender, EventArgs e)
        {
            if (nudAreaH.Value > Convert.ToDecimal(AreaLow))
                AreaHigh = Convert.ToDouble(nudAreaH.Value);
            else
                nudAreaH.Value = Convert.ToDecimal(AreaLow + 1.0);
        }

        private void nudHueL_ValueChanged(object sender, EventArgs e)
        {
            if (nudHueL.Value < (int)HueHigh)
                HueLow = Convert.ToDouble(nudHueL.Value);
            else
                nudHueL.Value = (int)HueHigh - 1; 
        }

        private void nudHueH_ValueChanged(object sender, EventArgs e)
        {
            if (nudHueH.Value > (int)HueLow)
                HueHigh = Convert.ToDouble(nudHueH.Value);
            else
                nudHueH.Value = (int)HueLow + 1;
        }

        private void nudSatL_ValueChanged(object sender, EventArgs e)
        {
            if (nudSatL.Value < Convert.ToDecimal(SatHigh))
                SatLow = Convert.ToDouble(nudSatL.Value);
            else
                nudSatL.Value = Convert.ToDecimal(SatHigh - 0.01);
        }

        private void nudSatH_ValueChanged(object sender, EventArgs e)
        {
            if (nudSatH.Value > Convert.ToDecimal(SatLow))
                SatHigh = Convert.ToDouble(nudSatH.Value);
            else
                nudSatH.Value = Convert.ToDecimal(SatLow + 0.01);
        }

        private void nudValL_ValueChanged(object sender, EventArgs e)
        {
            if (nudValL.Value < Convert.ToDecimal(ValHigh))
                ValLow = Convert.ToDouble(nudValL.Value);
            else
                nudValL.Value = Convert.ToDecimal(ValHigh - 0.01);
        }

        private void nudValH_ValueChanged(object sender, EventArgs e)
        {
            if (nudValH.Value > Convert.ToDecimal(ValLow))
                ValHigh = Convert.ToDouble(nudValH.Value);
            else
                nudValH.Value = Convert.ToDecimal(ValLow + 0.01);
        }

        private void btnCalibrate_Click(object sender, EventArgs e)
        {
            if (nudCalDistance.Value > 0 && nudCalHeight.Value > 0)
            {
                calHeight = Convert.ToDouble(nudCalHeight.Value);
                calDistance = Convert.ToDouble(nudCalDistance.Value);
                try { focal = (targetHeight * calDistance) / calHeight; }
                catch { };
            }
        }

        private void btnSaveSetup_Click(object sender, EventArgs e)
        {
            WriteSetup();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 1)
            {
                switch (cmbCamera.SelectedIndex)
                {
                    case 0:
                        webBrowser1.Visible = false;
                        break;
                    case 1:
                        webBrowser1.Visible = true;
                        webBrowser1.Navigate("http://" + txtNetworkTables.Text + ":1181");
                        break;
                    case 2:
                        webBrowser1.Visible = true;
                        webBrowser1.Navigate("http://" + txtNetworkTables.Text + ":1182");
                        break;
                    case 3:
                        webBrowser1.Visible = true;
                        webBrowser1.Navigate("http://" + txtIPCamera.Text);
                        break;
                    default:
                        webBrowser1.Visible = true;
                        webBrowser1.Navigate(cmbCamera.Text);
                        break;
                }
            }
        }

        private void tbOutputFilter_ValueChanged(object sender, EventArgs e)
        {
            outputFilter = Convert.ToDouble(tbOutputFilter.Value) / 100.0;
        }

        private void nudAreaRatioL_ValueChanged(object sender, EventArgs e)
        {
            if (nudAreaRatioL.Value < Convert.ToDecimal(AspectRatioHigh))
                AspectRatioLow = Convert.ToDouble(nudAreaRatioL.Value);
            else
                nudAreaRatioL.Value = Convert.ToDecimal(AspectRatioHigh - 0.01);
        }

        private void nudAreaRatioH_ValueChanged(object sender, EventArgs e)
        {
            if (nudAreaRatioH.Value > Convert.ToDecimal(AspectRatioLow))
                AspectRatioHigh = Convert.ToDouble(nudAreaRatioH.Value);
            else
                nudAreaRatioH.Value = Convert.ToDecimal(AspectRatioLow + 0.01);
        }

        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraSelected = cmbCamera.SelectedIndex;
        }

        double Normalize(double angle, double rangeMin, double rangeMax, double boundMin, double boundMax)
        {
            if (angle <= rangeMin) return boundMin;
            if (angle >= rangeMax) return boundMax;
            return boundMin + (angle - rangeMin) / ((rangeMax - rangeMin) - 1) * (boundMax - boundMin);
        }

        double ffilter(double raw, double current, double lpf)
        {
            double weight = Math.Min(0.99999, Math.Max(lpf, 0));
            return ((1 - weight) * raw) + (weight * current);
        }

        int filter(int raw, int current, double lpf)
        {
            double weight = Math.Min(0.99999, Math.Max(lpf, 0));
            return Convert.ToInt32(((1 - weight) * raw) + (weight * current));
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            lock (this)
            {
                //copy input image
                using (Bitmap hsl = (Bitmap)image.Clone())
                {
                    //filter by HSL
                    HSLFiltering filterHSL = new HSLFiltering();
                    // set color ranges to keep
                    filterHSL.Hue = new IntRange(Convert.ToInt32(HueLow), Convert.ToInt32(HueHigh));
                    filterHSL.Saturation = new Range((float)SatLow, (float)SatHigh);
                    filterHSL.Luminance = new Range((float)ValLow, (float)ValHigh);
                    // apply the filter
                    if (cbxTargetFrame.Checked) filterHSL.ApplyInPlace(image);
                    else filterHSL.ApplyInPlace(hsl);
                    
                    //Process blobs
                    BlobCounter bc = new BlobCounter();
                    bc.ObjectsOrder = ObjectsOrder.Area;
                    if (cbxTargetFrame.Checked) bc.ProcessImage(image);
                    else bc.ProcessImage(hsl);

                    //show HSL values for selected pixel
                    if (colorRequested)
                    {
                        try
                        {
                            colorRequested = false;
                            int x = colorX * image.Width / vspTarget.ClientSize.Width;
                            int y = colorY * image.Height / vspTarget.ClientSize.Height;
                            Color c = image.GetPixel(x, y);
                            var xrgb = new RGB(c);
                            var xhsl = new HSL();
                            xhsl = HSL.FromRGB(xrgb);
                            hue = xhsl.Hue;
                            sat = xhsl.Saturation;
                            lum = xhsl.Luminance;
                            this.Text = "HUE: " + hue.ToString("N0") + "   SAT: " + sat.ToString("N2") + "   LUM: " + lum.ToString("N2");
                        }
                        catch { };
                    }

                    using (Graphics g = Graphics.FromImage(image))
                    {
                        Rectangle[] rects = bc.GetObjectsRectangles();
                        try
                        {
                            if (rects.Length > 0)
                            {
                                //collect info
                                targetWidth = filter(Convert.ToInt32(rects[0].Width), targetWidth, outputFilter);
                                targetHeight = filter(Convert.ToInt32(rects[0].Height), targetHeight, outputFilter);
                                double area = targetHeight * targetWidth;
                                targetArea = ffilter(area, targetArea, outputFilter);
                                if (targetWidth > 0 && targetHeight > 0) targetAspectRatio = ffilter(Convert.ToDouble(targetWidth) / Convert.ToDouble(targetHeight), targetAspectRatio, outputFilter);
                                double tmpDist = (focal * calHeight) / targetHeight;
                                if (!double.IsInfinity(tmpDist)) targetDistance = ffilter(tmpDist, targetDistance, outputFilter);
                                targetX = ffilter(rects[0].X + (rects[0].Width / 2), targetX, outputFilter);
                                targetY = ffilter(rects[0].Y + (rects[0].Height / 2), targetY, outputFilter);
                                HorizontalDegreesPerPixel = HFOV / Convert.ToDouble(image.Width);
                                targetAngle = ffilter((targetX - (Convert.ToDouble(image.Width) / 2)) * HorizontalDegreesPerPixel, targetAngle, outputFilter);
                                if (image.Width > 0) targetSteer = ffilter(Normalize(targetAngle, STEERMIN, STEERMAX, -1.0, 1.0), targetSteer, outputFilter);
                                targetVisible = true;
                                if (cbUseAreaFilter.Checked)
                                {
                                    if (targetArea < AreaLow || targetArea > AreaHigh) targetVisible = false;
                                }
                                if (cbUseAreaRatioFilter.Checked)
                                {
                                    if (targetAspectRatio < AspectRatioLow || targetAspectRatio > AspectRatioHigh) targetVisible = false;
                                }
                                if (cbUseWidthFilter.Checked)
                                {
                                    if (targetWidth < WidthLow || targetWidth > WidthHigh) targetVisible = false;
                                }
                                if (cbUseHeightFilter.Checked)
                                {
                                    if (targetHeight < HeightLow || targetHeight > HeightHigh) targetVisible = false;
                                }
                                if (nt.IsConnected)
                                {
                                    nt.PutNumber("targetX", targetX);
                                    nt.PutNumber("targetY", targetY);
                                    nt.PutNumber("targetDistance", targetDistance);
                                    nt.PutNumber("targetAngle", targetAngle);
                                    nt.PutNumber("targetSteer", targetSteer);
                                    nt.PutBoolean("targetVisible", targetVisible);
                                }
                            }
                            else
                            {
                                targetVisible = false;
                                if (nt.IsConnected)
                                {
                                    nt.PutBoolean("targetVisible", targetVisible);
                                }
                            }
                            if (targetVisible)
                            {
                                //Draw Bounding Rectangle
                                if (rects.Length > 0) g.DrawRectangle(new Pen(Color.Red, 1), rects[0]);
                            }
                        }
                        catch { };
                    }
                }
            }
        }

        private void nudWidthL_ValueChanged(object sender, EventArgs e)
        {
            if (nudWidthL.Value < Convert.ToDecimal(WidthHigh))
                WidthLow = Convert.ToDouble(nudWidthL.Value);
            else
                nudWidthL.Value = Convert.ToDecimal(WidthHigh - 1);
        }

        private void nudWidthH_ValueChanged(object sender, EventArgs e)
        {
            if (nudWidthH.Value > Convert.ToDecimal(WidthLow))
                WidthHigh = Convert.ToDouble(nudWidthH.Value);
            else
                nudWidthH.Value = Convert.ToDecimal(WidthLow + 1);
        }

        private void nudHeightL_ValueChanged(object sender, EventArgs e)
        {
            if (nudHeightL.Value < Convert.ToDecimal(HeightHigh))
                HeightLow = Convert.ToDouble(nudHeightL.Value);
            else
                nudHeightL.Value = Convert.ToDecimal(HeightHigh - 1);
        }

        private void nudHeightH_ValueChanged(object sender, EventArgs e)
        {
            if (nudHeightH.Value > Convert.ToDecimal(HeightLow))
                HeightHigh = Convert.ToDouble(nudHeightH.Value);
            else
                nudHeightH.Value = Convert.ToDecimal(HeightLow + 1);
        }

        private void vspTarget_Click(object sender, EventArgs e)
        {
            try
            {
                MouseEventArgs rato = e as MouseEventArgs;
                colorRequested = true;
                colorX = rato.X;
                colorY = rato.Y;
            }
            catch { };
        }

        
        
    }
}
