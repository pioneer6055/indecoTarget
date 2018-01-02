namespace indecoTarget
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpTarget = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblNetworkTables = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudHeightL = new System.Windows.Forms.NumericUpDown();
            this.cbUseHeightFilter = new System.Windows.Forms.CheckBox();
            this.nudHeightH = new System.Windows.Forms.NumericUpDown();
            this.nudWidthL = new System.Windows.Forms.NumericUpDown();
            this.cbUseWidthFilter = new System.Windows.Forms.CheckBox();
            this.nudWidthH = new System.Windows.Forms.NumericUpDown();
            this.nudAreaRatioL = new System.Windows.Forms.NumericUpDown();
            this.lblTargetArea = new System.Windows.Forms.Label();
            this.lblTargetHeight = new System.Windows.Forms.Label();
            this.lblTargetAreaRatio = new System.Windows.Forms.Label();
            this.lblTargetWidth = new System.Windows.Forms.Label();
            this.cbUseAreaRatioFilter = new System.Windows.Forms.CheckBox();
            this.nudAreaRatioH = new System.Windows.Forms.NumericUpDown();
            this.cbUseAreaFilter = new System.Windows.Forms.CheckBox();
            this.nudAreaH = new System.Windows.Forms.NumericUpDown();
            this.nudAreaL = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudHueH = new System.Windows.Forms.NumericUpDown();
            this.nudHueL = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValH = new System.Windows.Forms.NumericUpDown();
            this.nudValL = new System.Windows.Forms.NumericUpDown();
            this.nudSatH = new System.Windows.Forms.NumericUpDown();
            this.nudSatL = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.vspTarget = new AForge.Controls.VideoSourcePlayer();
            this.lblTargetSteer = new System.Windows.Forms.Label();
            this.tbOutputFilter = new System.Windows.Forms.TrackBar();
            this.lblTargetAngle = new System.Windows.Forms.Label();
            this.lblTargetDistance = new System.Windows.Forms.Label();
            this.lblTargetVisible = new System.Windows.Forms.Label();
            this.lblTargetY = new System.Windows.Forms.Label();
            this.lblTargetX = new System.Windows.Forms.Label();
            this.cbxTargetFrame = new System.Windows.Forms.CheckBox();
            this.tpCalibration = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.nudCalHeight = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCalDistance = new System.Windows.Forms.Label();
            this.lblCalHeight = new System.Windows.Forms.Label();
            this.lblFocal = new System.Windows.Forms.Label();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nudCalDistance = new System.Windows.Forms.NumericUpDown();
            this.lblCalibrateDistance = new System.Windows.Forms.Label();
            this.lblCalibrateHeight = new System.Windows.Forms.Label();
            this.tpSetup = new System.Windows.Forms.TabPage();
            this.lblSetHeightEnabled = new System.Windows.Forms.Label();
            this.lblSetHeightHigh = new System.Windows.Forms.Label();
            this.lblSetHeightLow = new System.Windows.Forms.Label();
            this.lblSetWidthEnabled = new System.Windows.Forms.Label();
            this.lblSetWidthHigh = new System.Windows.Forms.Label();
            this.lblSetWidthLow = new System.Windows.Forms.Label();
            this.lblSetCamera = new System.Windows.Forms.Label();
            this.lblSetAreaRatioEnabled = new System.Windows.Forms.Label();
            this.lblSetAreaRatioHigh = new System.Windows.Forms.Label();
            this.lblSetAreaRatioLow = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIPCamera = new System.Windows.Forms.TextBox();
            this.btnSaveSetup = new System.Windows.Forms.Button();
            this.lblSetAreaEnabled = new System.Windows.Forms.Label();
            this.lblSetAreaHigh = new System.Windows.Forms.Label();
            this.lblSetAreaLow = new System.Windows.Forms.Label();
            this.lblSetValHigh = new System.Windows.Forms.Label();
            this.lblSetValLow = new System.Windows.Forms.Label();
            this.lblSetSatHigh = new System.Windows.Forms.Label();
            this.lblSetSatLow = new System.Windows.Forms.Label();
            this.lblSetHueHigh = new System.Windows.Forms.Label();
            this.lblSetHueLow = new System.Windows.Forms.Label();
            this.lblSetCalFocal = new System.Windows.Forms.Label();
            this.lblSetCalDistance = new System.Windows.Forms.Label();
            this.lblSetCalHeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNetworkTables = new System.Windows.Forms.TextBox();
            this.tpCamera = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tpHelp = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaRatioL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaRatioH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutputFilter)).BeginInit();
            this.tpCalibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalDistance)).BeginInit();
            this.tpSetup.SuspendLayout();
            this.tpCamera.SuspendLayout();
            this.tpHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpTarget);
            this.tabMain.Controls.Add(this.tpCalibration);
            this.tabMain.Controls.Add(this.tpSetup);
            this.tabMain.Controls.Add(this.tpCamera);
            this.tabMain.Controls.Add(this.tpHelp);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(735, 418);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpTarget
            // 
            this.tpTarget.Controls.Add(this.splitContainer1);
            this.tpTarget.Location = new System.Drawing.Point(4, 22);
            this.tpTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpTarget.Name = "tpTarget";
            this.tpTarget.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpTarget.Size = new System.Drawing.Size(727, 392);
            this.tpTarget.TabIndex = 0;
            this.tpTarget.Text = "Target";
            this.tpTarget.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblNetworkTables);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCamera);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnCapture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(723, 388);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 15;
            // 
            // lblNetworkTables
            // 
            this.lblNetworkTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNetworkTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetworkTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkTables.Location = new System.Drawing.Point(166, 344);
            this.lblNetworkTables.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetworkTables.Name = "lblNetworkTables";
            this.lblNetworkTables.Size = new System.Drawing.Size(84, 34);
            this.lblNetworkTables.TabIndex = 44;
            this.lblNetworkTables.Text = "Network Tables Connected";
            this.lblNetworkTables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Items.AddRange(new object[] {
            "Local USB",
            "USB1 on RoboRIO",
            "USB2 on RoboRIO",
            "Axis IP Camera"});
            this.cmbCamera.Location = new System.Drawing.Point(49, 9);
            this.cmbCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(145, 25);
            this.cmbCamera.TabIndex = 43;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudHeightL);
            this.groupBox2.Controls.Add(this.cbUseHeightFilter);
            this.groupBox2.Controls.Add(this.nudHeightH);
            this.groupBox2.Controls.Add(this.nudWidthL);
            this.groupBox2.Controls.Add(this.cbUseWidthFilter);
            this.groupBox2.Controls.Add(this.nudWidthH);
            this.groupBox2.Controls.Add(this.nudAreaRatioL);
            this.groupBox2.Controls.Add(this.lblTargetArea);
            this.groupBox2.Controls.Add(this.lblTargetHeight);
            this.groupBox2.Controls.Add(this.lblTargetAreaRatio);
            this.groupBox2.Controls.Add(this.lblTargetWidth);
            this.groupBox2.Controls.Add(this.cbUseAreaRatioFilter);
            this.groupBox2.Controls.Add(this.nudAreaRatioH);
            this.groupBox2.Controls.Add(this.cbUseAreaFilter);
            this.groupBox2.Controls.Add(this.nudAreaH);
            this.groupBox2.Controls.Add(this.nudAreaL);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(245, 167);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Filters";
            // 
            // nudHeightL
            // 
            this.nudHeightL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeightL.Location = new System.Drawing.Point(56, 131);
            this.nudHeightL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHeightL.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudHeightL.Name = "nudHeightL";
            this.nudHeightL.Size = new System.Drawing.Size(60, 23);
            this.nudHeightL.TabIndex = 55;
            this.nudHeightL.ValueChanged += new System.EventHandler(this.nudHeightL_ValueChanged);
            // 
            // cbUseHeightFilter
            // 
            this.cbUseHeightFilter.AutoSize = true;
            this.cbUseHeightFilter.Location = new System.Drawing.Point(5, 132);
            this.cbUseHeightFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUseHeightFilter.Name = "cbUseHeightFilter";
            this.cbUseHeightFilter.Size = new System.Drawing.Size(57, 17);
            this.cbUseHeightFilter.TabIndex = 57;
            this.cbUseHeightFilter.Text = "Height";
            this.cbUseHeightFilter.UseVisualStyleBackColor = true;
            // 
            // nudHeightH
            // 
            this.nudHeightH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeightH.Location = new System.Drawing.Point(116, 131);
            this.nudHeightH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHeightH.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudHeightH.Name = "nudHeightH";
            this.nudHeightH.Size = new System.Drawing.Size(60, 23);
            this.nudHeightH.TabIndex = 56;
            this.nudHeightH.ValueChanged += new System.EventHandler(this.nudHeightH_ValueChanged);
            // 
            // nudWidthL
            // 
            this.nudWidthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidthL.Location = new System.Drawing.Point(57, 98);
            this.nudWidthL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudWidthL.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudWidthL.Name = "nudWidthL";
            this.nudWidthL.Size = new System.Drawing.Size(60, 23);
            this.nudWidthL.TabIndex = 52;
            this.nudWidthL.ValueChanged += new System.EventHandler(this.nudWidthL_ValueChanged);
            // 
            // cbUseWidthFilter
            // 
            this.cbUseWidthFilter.AutoSize = true;
            this.cbUseWidthFilter.Location = new System.Drawing.Point(6, 99);
            this.cbUseWidthFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUseWidthFilter.Name = "cbUseWidthFilter";
            this.cbUseWidthFilter.Size = new System.Drawing.Size(54, 17);
            this.cbUseWidthFilter.TabIndex = 54;
            this.cbUseWidthFilter.Text = "Width";
            this.cbUseWidthFilter.UseVisualStyleBackColor = true;
            // 
            // nudWidthH
            // 
            this.nudWidthH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidthH.Location = new System.Drawing.Point(117, 98);
            this.nudWidthH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudWidthH.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudWidthH.Name = "nudWidthH";
            this.nudWidthH.Size = new System.Drawing.Size(60, 23);
            this.nudWidthH.TabIndex = 53;
            this.nudWidthH.ValueChanged += new System.EventHandler(this.nudWidthH_ValueChanged);
            // 
            // nudAreaRatioL
            // 
            this.nudAreaRatioL.DecimalPlaces = 2;
            this.nudAreaRatioL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAreaRatioL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAreaRatioL.Location = new System.Drawing.Point(58, 64);
            this.nudAreaRatioL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAreaRatioL.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAreaRatioL.Name = "nudAreaRatioL";
            this.nudAreaRatioL.Size = new System.Drawing.Size(60, 23);
            this.nudAreaRatioL.TabIndex = 47;
            this.nudAreaRatioL.ValueChanged += new System.EventHandler(this.nudAreaRatioL_ValueChanged);
            // 
            // lblTargetArea
            // 
            this.lblTargetArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetArea.Location = new System.Drawing.Point(179, 31);
            this.lblTargetArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetArea.Name = "lblTargetArea";
            this.lblTargetArea.Size = new System.Drawing.Size(59, 22);
            this.lblTargetArea.TabIndex = 51;
            this.lblTargetArea.Text = "Area: ";
            this.lblTargetArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetHeight
            // 
            this.lblTargetHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetHeight.Location = new System.Drawing.Point(179, 130);
            this.lblTargetHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetHeight.Name = "lblTargetHeight";
            this.lblTargetHeight.Size = new System.Drawing.Size(59, 22);
            this.lblTargetHeight.TabIndex = 18;
            this.lblTargetHeight.Text = "Height:";
            this.lblTargetHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetAreaRatio
            // 
            this.lblTargetAreaRatio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetAreaRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetAreaRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetAreaRatio.Location = new System.Drawing.Point(179, 64);
            this.lblTargetAreaRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetAreaRatio.Name = "lblTargetAreaRatio";
            this.lblTargetAreaRatio.Size = new System.Drawing.Size(59, 22);
            this.lblTargetAreaRatio.TabIndex = 50;
            this.lblTargetAreaRatio.Text = "Ratio: ";
            this.lblTargetAreaRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetWidth
            // 
            this.lblTargetWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetWidth.Location = new System.Drawing.Point(179, 98);
            this.lblTargetWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetWidth.Name = "lblTargetWidth";
            this.lblTargetWidth.Size = new System.Drawing.Size(59, 22);
            this.lblTargetWidth.TabIndex = 17;
            this.lblTargetWidth.Text = "Width:";
            this.lblTargetWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUseAreaRatioFilter
            // 
            this.cbUseAreaRatioFilter.AutoSize = true;
            this.cbUseAreaRatioFilter.Location = new System.Drawing.Point(7, 66);
            this.cbUseAreaRatioFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUseAreaRatioFilter.Name = "cbUseAreaRatioFilter";
            this.cbUseAreaRatioFilter.Size = new System.Drawing.Size(51, 17);
            this.cbUseAreaRatioFilter.TabIndex = 49;
            this.cbUseAreaRatioFilter.Text = "Ratio";
            this.cbUseAreaRatioFilter.UseVisualStyleBackColor = true;
            // 
            // nudAreaRatioH
            // 
            this.nudAreaRatioH.DecimalPlaces = 2;
            this.nudAreaRatioH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAreaRatioH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAreaRatioH.Location = new System.Drawing.Point(118, 64);
            this.nudAreaRatioH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAreaRatioH.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAreaRatioH.Name = "nudAreaRatioH";
            this.nudAreaRatioH.Size = new System.Drawing.Size(60, 23);
            this.nudAreaRatioH.TabIndex = 48;
            this.nudAreaRatioH.ValueChanged += new System.EventHandler(this.nudAreaRatioH_ValueChanged);
            // 
            // cbUseAreaFilter
            // 
            this.cbUseAreaFilter.AutoSize = true;
            this.cbUseAreaFilter.Location = new System.Drawing.Point(7, 32);
            this.cbUseAreaFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUseAreaFilter.Name = "cbUseAreaFilter";
            this.cbUseAreaFilter.Size = new System.Drawing.Size(48, 17);
            this.cbUseAreaFilter.TabIndex = 46;
            this.cbUseAreaFilter.Text = "Area";
            this.cbUseAreaFilter.UseVisualStyleBackColor = true;
            // 
            // nudAreaH
            // 
            this.nudAreaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAreaH.Location = new System.Drawing.Point(118, 31);
            this.nudAreaH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAreaH.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAreaH.Name = "nudAreaH";
            this.nudAreaH.Size = new System.Drawing.Size(60, 23);
            this.nudAreaH.TabIndex = 45;
            this.nudAreaH.ValueChanged += new System.EventHandler(this.nudAreaH_ValueChanged);
            // 
            // nudAreaL
            // 
            this.nudAreaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAreaL.Location = new System.Drawing.Point(58, 30);
            this.nudAreaL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAreaL.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudAreaL.Name = "nudAreaL";
            this.nudAreaL.Size = new System.Drawing.Size(60, 23);
            this.nudAreaL.TabIndex = 44;
            this.nudAreaL.ValueChanged += new System.EventHandler(this.nudAreaL_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "High";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Low";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudHueH);
            this.groupBox1.Controls.Add(this.nudHueL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudValH);
            this.groupBox1.Controls.Add(this.nudValL);
            this.groupBox1.Controls.Add(this.nudSatH);
            this.groupBox1.Controls.Add(this.nudSatL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 122);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HSL Filter";
            // 
            // nudHueH
            // 
            this.nudHueH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHueH.Location = new System.Drawing.Point(128, 33);
            this.nudHueH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHueH.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.nudHueH.Name = "nudHueH";
            this.nudHueH.Size = new System.Drawing.Size(58, 23);
            this.nudHueH.TabIndex = 50;
            this.nudHueH.ValueChanged += new System.EventHandler(this.nudHueH_ValueChanged);
            // 
            // nudHueL
            // 
            this.nudHueL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHueL.Location = new System.Drawing.Point(50, 33);
            this.nudHueL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudHueL.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.nudHueL.Name = "nudHueL";
            this.nudHueL.Size = new System.Drawing.Size(58, 23);
            this.nudHueL.TabIndex = 49;
            this.nudHueL.ValueChanged += new System.EventHandler(this.nudHueL_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "LUM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "SAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "HUE";
            // 
            // nudValH
            // 
            this.nudValH.DecimalPlaces = 2;
            this.nudValH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudValH.Location = new System.Drawing.Point(128, 90);
            this.nudValH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudValH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValH.Name = "nudValH";
            this.nudValH.Size = new System.Drawing.Size(58, 23);
            this.nudValH.TabIndex = 43;
            this.nudValH.ValueChanged += new System.EventHandler(this.nudValH_ValueChanged);
            // 
            // nudValL
            // 
            this.nudValL.DecimalPlaces = 2;
            this.nudValL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudValL.Location = new System.Drawing.Point(50, 90);
            this.nudValL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudValL.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValL.Name = "nudValL";
            this.nudValL.Size = new System.Drawing.Size(58, 23);
            this.nudValL.TabIndex = 42;
            this.nudValL.ValueChanged += new System.EventHandler(this.nudValL_ValueChanged);
            // 
            // nudSatH
            // 
            this.nudSatH.DecimalPlaces = 2;
            this.nudSatH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSatH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSatH.Location = new System.Drawing.Point(128, 61);
            this.nudSatH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSatH.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSatH.Name = "nudSatH";
            this.nudSatH.Size = new System.Drawing.Size(58, 23);
            this.nudSatH.TabIndex = 41;
            this.nudSatH.ValueChanged += new System.EventHandler(this.nudSatH_ValueChanged);
            // 
            // nudSatL
            // 
            this.nudSatL.DecimalPlaces = 2;
            this.nudSatL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSatL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSatL.Location = new System.Drawing.Point(50, 61);
            this.nudSatL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSatL.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSatL.Name = "nudSatL";
            this.nudSatL.Size = new System.Drawing.Size(58, 23);
            this.nudSatL.TabIndex = 40;
            this.nudSatL.ValueChanged += new System.EventHandler(this.nudSatL_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "High";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Camera:";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(6, 347);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(78, 30);
            this.btnCapture.TabIndex = 14;
            this.btnCapture.Text = "Start";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.vspTarget);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.lblTargetSteer);
            this.splitContainer2.Panel2.Controls.Add(this.tbOutputFilter);
            this.splitContainer2.Panel2.Controls.Add(this.lblTargetAngle);
            this.splitContainer2.Panel2.Controls.Add(this.lblTargetDistance);
            this.splitContainer2.Panel2.Controls.Add(this.lblTargetVisible);
            this.splitContainer2.Panel2.Controls.Add(this.lblTargetY);
            this.splitContainer2.Panel2.Controls.Add(this.lblTargetX);
            this.splitContainer2.Panel2.Controls.Add(this.cbxTargetFrame);
            this.splitContainer2.Size = new System.Drawing.Size(462, 388);
            this.splitContainer2.SplitterDistance = 297;
            this.splitContainer2.TabIndex = 4;
            // 
            // vspTarget
            // 
            this.vspTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vspTarget.Location = new System.Drawing.Point(0, 0);
            this.vspTarget.Name = "vspTarget";
            this.vspTarget.Size = new System.Drawing.Size(460, 295);
            this.vspTarget.TabIndex = 1;
            this.vspTarget.Text = "vspTarget";
            this.vspTarget.VideoSource = null;
            this.vspTarget.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            this.vspTarget.Click += new System.EventHandler(this.vspTarget_Click);
            // 
            // lblTargetSteer
            // 
            this.lblTargetSteer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetSteer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetSteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetSteer.Location = new System.Drawing.Point(123, 56);
            this.lblTargetSteer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetSteer.Name = "lblTargetSteer";
            this.lblTargetSteer.Size = new System.Drawing.Size(95, 22);
            this.lblTargetSteer.TabIndex = 48;
            this.lblTargetSteer.Text = "Steer:";
            this.lblTargetSteer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOutputFilter
            // 
            this.tbOutputFilter.AutoSize = false;
            this.tbOutputFilter.LargeChange = 10;
            this.tbOutputFilter.Location = new System.Drawing.Point(232, 52);
            this.tbOutputFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOutputFilter.Maximum = 99;
            this.tbOutputFilter.Name = "tbOutputFilter";
            this.tbOutputFilter.Size = new System.Drawing.Size(107, 26);
            this.tbOutputFilter.TabIndex = 46;
            this.tbOutputFilter.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbOutputFilter.Value = 25;
            this.tbOutputFilter.ValueChanged += new System.EventHandler(this.tbOutputFilter_ValueChanged);
            // 
            // lblTargetAngle
            // 
            this.lblTargetAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetAngle.Location = new System.Drawing.Point(123, 32);
            this.lblTargetAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetAngle.Name = "lblTargetAngle";
            this.lblTargetAngle.Size = new System.Drawing.Size(95, 22);
            this.lblTargetAngle.TabIndex = 45;
            this.lblTargetAngle.Text = "Angle:";
            this.lblTargetAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetDistance
            // 
            this.lblTargetDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDistance.Location = new System.Drawing.Point(123, 8);
            this.lblTargetDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetDistance.Name = "lblTargetDistance";
            this.lblTargetDistance.Size = new System.Drawing.Size(95, 22);
            this.lblTargetDistance.TabIndex = 24;
            this.lblTargetDistance.Text = "Dist:";
            this.lblTargetDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetVisible
            // 
            this.lblTargetVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetVisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetVisible.Location = new System.Drawing.Point(14, 8);
            this.lblTargetVisible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetVisible.Name = "lblTargetVisible";
            this.lblTargetVisible.Size = new System.Drawing.Size(95, 22);
            this.lblTargetVisible.TabIndex = 22;
            this.lblTargetVisible.Text = "Target Visible";
            this.lblTargetVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTargetY
            // 
            this.lblTargetY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetY.Location = new System.Drawing.Point(14, 56);
            this.lblTargetY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetY.Name = "lblTargetY";
            this.lblTargetY.Size = new System.Drawing.Size(95, 22);
            this.lblTargetY.TabIndex = 21;
            this.lblTargetY.Text = "Y: ";
            this.lblTargetY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetX
            // 
            this.lblTargetX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTargetX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetX.Location = new System.Drawing.Point(14, 32);
            this.lblTargetX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetX.Name = "lblTargetX";
            this.lblTargetX.Size = new System.Drawing.Size(95, 22);
            this.lblTargetX.TabIndex = 20;
            this.lblTargetX.Text = "X: ";
            this.lblTargetX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxTargetFrame
            // 
            this.cbxTargetFrame.AutoSize = true;
            this.cbxTargetFrame.Location = new System.Drawing.Point(341, 10);
            this.cbxTargetFrame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTargetFrame.Name = "cbxTargetFrame";
            this.cbxTargetFrame.Size = new System.Drawing.Size(110, 17);
            this.cbxTargetFrame.TabIndex = 19;
            this.cbxTargetFrame.Text = "Show Filter Frame";
            this.cbxTargetFrame.UseVisualStyleBackColor = true;
            // 
            // tpCalibration
            // 
            this.tpCalibration.Controls.Add(this.label15);
            this.tpCalibration.Controls.Add(this.nudCalHeight);
            this.tpCalibration.Controls.Add(this.label12);
            this.tpCalibration.Controls.Add(this.label11);
            this.tpCalibration.Controls.Add(this.lblCalDistance);
            this.tpCalibration.Controls.Add(this.lblCalHeight);
            this.tpCalibration.Controls.Add(this.lblFocal);
            this.tpCalibration.Controls.Add(this.btnCalibrate);
            this.tpCalibration.Controls.Add(this.label13);
            this.tpCalibration.Controls.Add(this.nudCalDistance);
            this.tpCalibration.Controls.Add(this.lblCalibrateDistance);
            this.tpCalibration.Controls.Add(this.lblCalibrateHeight);
            this.tpCalibration.Location = new System.Drawing.Point(4, 22);
            this.tpCalibration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCalibration.Name = "tpCalibration";
            this.tpCalibration.Size = new System.Drawing.Size(727, 392);
            this.tpCalibration.TabIndex = 2;
            this.tpCalibration.Text = "Calibration";
            this.tpCalibration.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(146, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Calibrate Target Height:";
            // 
            // nudCalHeight
            // 
            this.nudCalHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCalHeight.Location = new System.Drawing.Point(277, 40);
            this.nudCalHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCalHeight.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCalHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCalHeight.Name = "nudCalHeight";
            this.nudCalHeight.Size = new System.Drawing.Size(80, 23);
            this.nudCalHeight.TabIndex = 54;
            this.nudCalHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 223);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Distance = (CalibrateHeight * Focal) / PixelHeight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Focal = (PixelHeight * CalibrateDistance) / CalibrateHeight";
            // 
            // lblCalDistance
            // 
            this.lblCalDistance.AutoSize = true;
            this.lblCalDistance.Location = new System.Drawing.Point(22, 181);
            this.lblCalDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalDistance.Name = "lblCalDistance";
            this.lblCalDistance.Size = new System.Drawing.Size(19, 13);
            this.lblCalDistance.TabIndex = 50;
            this.lblCalDistance.Text = "??";
            // 
            // lblCalHeight
            // 
            this.lblCalHeight.AutoSize = true;
            this.lblCalHeight.Location = new System.Drawing.Point(22, 150);
            this.lblCalHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalHeight.Name = "lblCalHeight";
            this.lblCalHeight.Size = new System.Drawing.Size(19, 13);
            this.lblCalHeight.TabIndex = 49;
            this.lblCalHeight.Text = "??";
            // 
            // lblFocal
            // 
            this.lblFocal.AutoSize = true;
            this.lblFocal.Location = new System.Drawing.Point(22, 123);
            this.lblFocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFocal.Name = "lblFocal";
            this.lblFocal.Size = new System.Drawing.Size(19, 13);
            this.lblFocal.TabIndex = 48;
            this.lblFocal.Text = "??";
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Enabled = false;
            this.btnCalibrate.Location = new System.Drawing.Point(370, 61);
            this.btnCalibrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(80, 22);
            this.btnCalibrate.TabIndex = 47;
            this.btnCalibrate.Text = "Calibrate";
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(146, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Calibrate Target Distance:";
            // 
            // nudCalDistance
            // 
            this.nudCalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCalDistance.Location = new System.Drawing.Point(277, 71);
            this.nudCalDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCalDistance.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudCalDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCalDistance.Name = "nudCalDistance";
            this.nudCalDistance.Size = new System.Drawing.Size(80, 23);
            this.nudCalDistance.TabIndex = 45;
            this.nudCalDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCalibrateDistance
            // 
            this.lblCalibrateDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCalibrateDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalibrateDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalibrateDistance.Location = new System.Drawing.Point(25, 61);
            this.lblCalibrateDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalibrateDistance.Name = "lblCalibrateDistance";
            this.lblCalibrateDistance.Size = new System.Drawing.Size(95, 22);
            this.lblCalibrateDistance.TabIndex = 26;
            this.lblCalibrateDistance.Text = "Distance:";
            this.lblCalibrateDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalibrateHeight
            // 
            this.lblCalibrateHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCalibrateHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalibrateHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalibrateHeight.Location = new System.Drawing.Point(25, 37);
            this.lblCalibrateHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalibrateHeight.Name = "lblCalibrateHeight";
            this.lblCalibrateHeight.Size = new System.Drawing.Size(95, 22);
            this.lblCalibrateHeight.TabIndex = 25;
            this.lblCalibrateHeight.Text = "Height:";
            this.lblCalibrateHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpSetup
            // 
            this.tpSetup.Controls.Add(this.lblSetHeightEnabled);
            this.tpSetup.Controls.Add(this.lblSetHeightHigh);
            this.tpSetup.Controls.Add(this.lblSetHeightLow);
            this.tpSetup.Controls.Add(this.lblSetWidthEnabled);
            this.tpSetup.Controls.Add(this.lblSetWidthHigh);
            this.tpSetup.Controls.Add(this.lblSetWidthLow);
            this.tpSetup.Controls.Add(this.lblSetCamera);
            this.tpSetup.Controls.Add(this.lblSetAreaRatioEnabled);
            this.tpSetup.Controls.Add(this.lblSetAreaRatioHigh);
            this.tpSetup.Controls.Add(this.lblSetAreaRatioLow);
            this.tpSetup.Controls.Add(this.label14);
            this.tpSetup.Controls.Add(this.txtIPCamera);
            this.tpSetup.Controls.Add(this.btnSaveSetup);
            this.tpSetup.Controls.Add(this.lblSetAreaEnabled);
            this.tpSetup.Controls.Add(this.lblSetAreaHigh);
            this.tpSetup.Controls.Add(this.lblSetAreaLow);
            this.tpSetup.Controls.Add(this.lblSetValHigh);
            this.tpSetup.Controls.Add(this.lblSetValLow);
            this.tpSetup.Controls.Add(this.lblSetSatHigh);
            this.tpSetup.Controls.Add(this.lblSetSatLow);
            this.tpSetup.Controls.Add(this.lblSetHueHigh);
            this.tpSetup.Controls.Add(this.lblSetHueLow);
            this.tpSetup.Controls.Add(this.lblSetCalFocal);
            this.tpSetup.Controls.Add(this.lblSetCalDistance);
            this.tpSetup.Controls.Add(this.lblSetCalHeight);
            this.tpSetup.Controls.Add(this.label8);
            this.tpSetup.Controls.Add(this.txtNetworkTables);
            this.tpSetup.Location = new System.Drawing.Point(4, 22);
            this.tpSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpSetup.Name = "tpSetup";
            this.tpSetup.Size = new System.Drawing.Size(727, 392);
            this.tpSetup.TabIndex = 3;
            this.tpSetup.Text = "Setup";
            this.tpSetup.UseVisualStyleBackColor = true;
            // 
            // lblSetHeightEnabled
            // 
            this.lblSetHeightEnabled.AutoSize = true;
            this.lblSetHeightEnabled.Location = new System.Drawing.Point(246, 336);
            this.lblSetHeightEnabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetHeightEnabled.Name = "lblSetHeightEnabled";
            this.lblSetHeightEnabled.Size = new System.Drawing.Size(19, 13);
            this.lblSetHeightEnabled.TabIndex = 77;
            this.lblSetHeightEnabled.Text = "??";
            // 
            // lblSetHeightHigh
            // 
            this.lblSetHeightHigh.AutoSize = true;
            this.lblSetHeightHigh.Location = new System.Drawing.Point(246, 309);
            this.lblSetHeightHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetHeightHigh.Name = "lblSetHeightHigh";
            this.lblSetHeightHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetHeightHigh.TabIndex = 76;
            this.lblSetHeightHigh.Text = "??";
            // 
            // lblSetHeightLow
            // 
            this.lblSetHeightLow.AutoSize = true;
            this.lblSetHeightLow.Location = new System.Drawing.Point(246, 280);
            this.lblSetHeightLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetHeightLow.Name = "lblSetHeightLow";
            this.lblSetHeightLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetHeightLow.TabIndex = 75;
            this.lblSetHeightLow.Text = "??";
            // 
            // lblSetWidthEnabled
            // 
            this.lblSetWidthEnabled.AutoSize = true;
            this.lblSetWidthEnabled.Location = new System.Drawing.Point(246, 254);
            this.lblSetWidthEnabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetWidthEnabled.Name = "lblSetWidthEnabled";
            this.lblSetWidthEnabled.Size = new System.Drawing.Size(19, 13);
            this.lblSetWidthEnabled.TabIndex = 74;
            this.lblSetWidthEnabled.Text = "??";
            // 
            // lblSetWidthHigh
            // 
            this.lblSetWidthHigh.AutoSize = true;
            this.lblSetWidthHigh.Location = new System.Drawing.Point(246, 227);
            this.lblSetWidthHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetWidthHigh.Name = "lblSetWidthHigh";
            this.lblSetWidthHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetWidthHigh.TabIndex = 73;
            this.lblSetWidthHigh.Text = "??";
            // 
            // lblSetWidthLow
            // 
            this.lblSetWidthLow.AutoSize = true;
            this.lblSetWidthLow.Location = new System.Drawing.Point(246, 198);
            this.lblSetWidthLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetWidthLow.Name = "lblSetWidthLow";
            this.lblSetWidthLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetWidthLow.TabIndex = 72;
            this.lblSetWidthLow.Text = "??";
            // 
            // lblSetCamera
            // 
            this.lblSetCamera.AutoSize = true;
            this.lblSetCamera.Location = new System.Drawing.Point(14, 32);
            this.lblSetCamera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetCamera.Name = "lblSetCamera";
            this.lblSetCamera.Size = new System.Drawing.Size(19, 13);
            this.lblSetCamera.TabIndex = 71;
            this.lblSetCamera.Text = "??";
            // 
            // lblSetAreaRatioEnabled
            // 
            this.lblSetAreaRatioEnabled.AutoSize = true;
            this.lblSetAreaRatioEnabled.Location = new System.Drawing.Point(246, 171);
            this.lblSetAreaRatioEnabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetAreaRatioEnabled.Name = "lblSetAreaRatioEnabled";
            this.lblSetAreaRatioEnabled.Size = new System.Drawing.Size(19, 13);
            this.lblSetAreaRatioEnabled.TabIndex = 70;
            this.lblSetAreaRatioEnabled.Text = "??";
            // 
            // lblSetAreaRatioHigh
            // 
            this.lblSetAreaRatioHigh.AutoSize = true;
            this.lblSetAreaRatioHigh.Location = new System.Drawing.Point(246, 144);
            this.lblSetAreaRatioHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetAreaRatioHigh.Name = "lblSetAreaRatioHigh";
            this.lblSetAreaRatioHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetAreaRatioHigh.TabIndex = 69;
            this.lblSetAreaRatioHigh.Text = "??";
            // 
            // lblSetAreaRatioLow
            // 
            this.lblSetAreaRatioLow.AutoSize = true;
            this.lblSetAreaRatioLow.Location = new System.Drawing.Point(246, 115);
            this.lblSetAreaRatioLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetAreaRatioLow.Name = "lblSetAreaRatioLow";
            this.lblSetAreaRatioLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetAreaRatioLow.TabIndex = 68;
            this.lblSetAreaRatioLow.Text = "??";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Axis IP Camera Address:";
            // 
            // txtIPCamera
            // 
            this.txtIPCamera.Location = new System.Drawing.Point(610, 46);
            this.txtIPCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIPCamera.Name = "txtIPCamera";
            this.txtIPCamera.Size = new System.Drawing.Size(110, 20);
            this.txtIPCamera.TabIndex = 66;
            this.txtIPCamera.Text = "10.60.55.11";
            // 
            // btnSaveSetup
            // 
            this.btnSaveSetup.Location = new System.Drawing.Point(519, 343);
            this.btnSaveSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveSetup.Name = "btnSaveSetup";
            this.btnSaveSetup.Size = new System.Drawing.Size(76, 28);
            this.btnSaveSetup.TabIndex = 65;
            this.btnSaveSetup.Text = "Save Setup";
            this.btnSaveSetup.UseVisualStyleBackColor = true;
            this.btnSaveSetup.Click += new System.EventHandler(this.btnSaveSetup_Click);
            // 
            // lblSetAreaEnabled
            // 
            this.lblSetAreaEnabled.AutoSize = true;
            this.lblSetAreaEnabled.Location = new System.Drawing.Point(246, 88);
            this.lblSetAreaEnabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetAreaEnabled.Name = "lblSetAreaEnabled";
            this.lblSetAreaEnabled.Size = new System.Drawing.Size(19, 13);
            this.lblSetAreaEnabled.TabIndex = 64;
            this.lblSetAreaEnabled.Text = "??";
            // 
            // lblSetAreaHigh
            // 
            this.lblSetAreaHigh.AutoSize = true;
            this.lblSetAreaHigh.Location = new System.Drawing.Point(246, 60);
            this.lblSetAreaHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetAreaHigh.Name = "lblSetAreaHigh";
            this.lblSetAreaHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetAreaHigh.TabIndex = 63;
            this.lblSetAreaHigh.Text = "??";
            // 
            // lblSetAreaLow
            // 
            this.lblSetAreaLow.AutoSize = true;
            this.lblSetAreaLow.Location = new System.Drawing.Point(246, 32);
            this.lblSetAreaLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetAreaLow.Name = "lblSetAreaLow";
            this.lblSetAreaLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetAreaLow.TabIndex = 62;
            this.lblSetAreaLow.Text = "??";
            // 
            // lblSetValHigh
            // 
            this.lblSetValHigh.AutoSize = true;
            this.lblSetValHigh.Location = new System.Drawing.Point(14, 288);
            this.lblSetValHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetValHigh.Name = "lblSetValHigh";
            this.lblSetValHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetValHigh.TabIndex = 61;
            this.lblSetValHigh.Text = "??";
            // 
            // lblSetValLow
            // 
            this.lblSetValLow.AutoSize = true;
            this.lblSetValLow.Location = new System.Drawing.Point(14, 259);
            this.lblSetValLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetValLow.Name = "lblSetValLow";
            this.lblSetValLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetValLow.TabIndex = 60;
            this.lblSetValLow.Text = "??";
            // 
            // lblSetSatHigh
            // 
            this.lblSetSatHigh.AutoSize = true;
            this.lblSetSatHigh.Location = new System.Drawing.Point(14, 231);
            this.lblSetSatHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetSatHigh.Name = "lblSetSatHigh";
            this.lblSetSatHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetSatHigh.TabIndex = 59;
            this.lblSetSatHigh.Text = "??";
            // 
            // lblSetSatLow
            // 
            this.lblSetSatLow.AutoSize = true;
            this.lblSetSatLow.Location = new System.Drawing.Point(14, 202);
            this.lblSetSatLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetSatLow.Name = "lblSetSatLow";
            this.lblSetSatLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetSatLow.TabIndex = 58;
            this.lblSetSatLow.Text = "??";
            // 
            // lblSetHueHigh
            // 
            this.lblSetHueHigh.AutoSize = true;
            this.lblSetHueHigh.Location = new System.Drawing.Point(14, 174);
            this.lblSetHueHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetHueHigh.Name = "lblSetHueHigh";
            this.lblSetHueHigh.Size = new System.Drawing.Size(19, 13);
            this.lblSetHueHigh.TabIndex = 57;
            this.lblSetHueHigh.Text = "??";
            // 
            // lblSetHueLow
            // 
            this.lblSetHueLow.AutoSize = true;
            this.lblSetHueLow.Location = new System.Drawing.Point(14, 145);
            this.lblSetHueLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetHueLow.Name = "lblSetHueLow";
            this.lblSetHueLow.Size = new System.Drawing.Size(19, 13);
            this.lblSetHueLow.TabIndex = 56;
            this.lblSetHueLow.Text = "??";
            // 
            // lblSetCalFocal
            // 
            this.lblSetCalFocal.AutoSize = true;
            this.lblSetCalFocal.Location = new System.Drawing.Point(14, 117);
            this.lblSetCalFocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetCalFocal.Name = "lblSetCalFocal";
            this.lblSetCalFocal.Size = new System.Drawing.Size(19, 13);
            this.lblSetCalFocal.TabIndex = 54;
            this.lblSetCalFocal.Text = "??";
            // 
            // lblSetCalDistance
            // 
            this.lblSetCalDistance.AutoSize = true;
            this.lblSetCalDistance.Location = new System.Drawing.Point(14, 88);
            this.lblSetCalDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetCalDistance.Name = "lblSetCalDistance";
            this.lblSetCalDistance.Size = new System.Drawing.Size(19, 13);
            this.lblSetCalDistance.TabIndex = 53;
            this.lblSetCalDistance.Text = "??";
            // 
            // lblSetCalHeight
            // 
            this.lblSetCalHeight.AutoSize = true;
            this.lblSetCalHeight.Location = new System.Drawing.Point(14, 59);
            this.lblSetCalHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetCalHeight.Name = "lblSetCalHeight";
            this.lblSetCalHeight.Size = new System.Drawing.Size(19, 13);
            this.lblSetCalHeight.TabIndex = 52;
            this.lblSetCalHeight.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "RoboRio Address:";
            // 
            // txtNetworkTables
            // 
            this.txtNetworkTables.Location = new System.Drawing.Point(610, 13);
            this.txtNetworkTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNetworkTables.Name = "txtNetworkTables";
            this.txtNetworkTables.Size = new System.Drawing.Size(110, 20);
            this.txtNetworkTables.TabIndex = 29;
            this.txtNetworkTables.Text = "10.60.55.2";
            // 
            // tpCamera
            // 
            this.tpCamera.Controls.Add(this.webBrowser1);
            this.tpCamera.Location = new System.Drawing.Point(4, 22);
            this.tpCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCamera.Name = "tpCamera";
            this.tpCamera.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCamera.Size = new System.Drawing.Size(727, 392);
            this.tpCamera.TabIndex = 1;
            this.tpCamera.Text = "Camera";
            this.tpCamera.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(723, 388);
            this.webBrowser1.TabIndex = 0;
            // 
            // tpHelp
            // 
            this.tpHelp.Controls.Add(this.richTextBox1);
            this.tpHelp.Location = new System.Drawing.Point(4, 22);
            this.tpHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpHelp.Name = "tpHelp";
            this.tpHelp.Size = new System.Drawing.Size(727, 392);
            this.tpHelp.TabIndex = 4;
            this.tpHelp.Text = "Help";
            this.tpHelp.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(727, 392);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Output Filter";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 418);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 500);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "indecoTarget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tpTarget.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaRatioL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaRatioH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHueL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatL)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbOutputFilter)).EndInit();
            this.tpCalibration.ResumeLayout(false);
            this.tpCalibration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalDistance)).EndInit();
            this.tpSetup.ResumeLayout(false);
            this.tpSetup.PerformLayout();
            this.tpCamera.ResumeLayout(false);
            this.tpHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpTarget;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbUseAreaFilter;
        private System.Windows.Forms.NumericUpDown nudAreaH;
        private System.Windows.Forms.NumericUpDown nudAreaL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudValH;
        private System.Windows.Forms.NumericUpDown nudValL;
        private System.Windows.Forms.NumericUpDown nudSatH;
        private System.Windows.Forms.NumericUpDown nudSatL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblTargetDistance;
        private System.Windows.Forms.Label lblTargetVisible;
        private System.Windows.Forms.Label lblTargetY;
        private System.Windows.Forms.Label lblTargetX;
        private System.Windows.Forms.CheckBox cbxTargetFrame;
        private System.Windows.Forms.Label lblTargetHeight;
        private System.Windows.Forms.Label lblTargetWidth;
        private System.Windows.Forms.TabPage tpCamera;
        private System.Windows.Forms.TabPage tpCalibration;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudCalDistance;
        private System.Windows.Forms.Label lblCalibrateDistance;
        private System.Windows.Forms.Label lblCalibrateHeight;
        private System.Windows.Forms.Label lblCalDistance;
        private System.Windows.Forms.Label lblCalHeight;
        private System.Windows.Forms.Label lblFocal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tpSetup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNetworkTables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSetCalFocal;
        private System.Windows.Forms.Label lblSetCalDistance;
        private System.Windows.Forms.Label lblSetCalHeight;
        private System.Windows.Forms.Label lblSetSatHigh;
        private System.Windows.Forms.Label lblSetSatLow;
        private System.Windows.Forms.Label lblSetHueHigh;
        private System.Windows.Forms.Label lblSetHueLow;
        private System.Windows.Forms.Label lblSetAreaEnabled;
        private System.Windows.Forms.Label lblSetAreaHigh;
        private System.Windows.Forms.Label lblSetAreaLow;
        private System.Windows.Forms.Label lblSetValHigh;
        private System.Windows.Forms.Label lblSetValLow;
        private System.Windows.Forms.Button btnSaveSetup;
        private System.Windows.Forms.Label lblNetworkTables;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIPCamera;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudCalHeight;
        private System.Windows.Forms.Label lblTargetAngle;
        private System.Windows.Forms.TrackBar tbOutputFilter;
        private System.Windows.Forms.CheckBox cbUseAreaRatioFilter;
        private System.Windows.Forms.NumericUpDown nudAreaRatioH;
        private System.Windows.Forms.NumericUpDown nudAreaRatioL;
        private System.Windows.Forms.Label lblTargetArea;
        private System.Windows.Forms.Label lblTargetAreaRatio;
        private System.Windows.Forms.Label lblSetAreaRatioEnabled;
        private System.Windows.Forms.Label lblSetAreaRatioHigh;
        private System.Windows.Forms.Label lblSetAreaRatioLow;
        private System.Windows.Forms.Label lblSetCamera;
        private System.Windows.Forms.TabPage tpHelp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTargetSteer;
        private System.Windows.Forms.NumericUpDown nudHueH;
        private System.Windows.Forms.NumericUpDown nudHueL;
        private AForge.Controls.VideoSourcePlayer vspTarget;
        private System.Windows.Forms.NumericUpDown nudHeightL;
        private System.Windows.Forms.CheckBox cbUseHeightFilter;
        private System.Windows.Forms.NumericUpDown nudHeightH;
        private System.Windows.Forms.NumericUpDown nudWidthL;
        private System.Windows.Forms.CheckBox cbUseWidthFilter;
        private System.Windows.Forms.NumericUpDown nudWidthH;
        private System.Windows.Forms.Label lblSetHeightEnabled;
        private System.Windows.Forms.Label lblSetHeightHigh;
        private System.Windows.Forms.Label lblSetHeightLow;
        private System.Windows.Forms.Label lblSetWidthEnabled;
        private System.Windows.Forms.Label lblSetWidthHigh;
        private System.Windows.Forms.Label lblSetWidthLow;
        private System.Windows.Forms.Label label6;


    }
}

