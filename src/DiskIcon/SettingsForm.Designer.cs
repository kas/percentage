namespace DiskIcon
{
    partial class SettingsForm
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.batteryFontDialog = new System.Windows.Forms.FontDialog();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.diskName3 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.diskColor3 = new System.Windows.Forms.TextBox();
            this.diskColor3Button = new System.Windows.Forms.Button();
            this.diskColor3Opacity = new System.Windows.Forms.TrackBar();
            this.label61 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.diskName2 = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.diskColor2 = new System.Windows.Forms.TextBox();
            this.diskColor2Button = new System.Windows.Forms.Button();
            this.diskColor2Opacity = new System.Windows.Forms.TrackBar();
            this.label59 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.diskInterval = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.diskBorderText = new System.Windows.Forms.TextBox();
            this.diskBorderButton = new System.Windows.Forms.Button();
            this.diskBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label51 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.diskBackgroundText = new System.Windows.Forms.TextBox();
            this.diskBackgroundButton = new System.Windows.Forms.Button();
            this.diskBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label53 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.diskName1 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.diskColor1 = new System.Windows.Forms.TextBox();
            this.diskColor1Button = new System.Windows.Forms.Button();
            this.diskColor1Opacity = new System.Windows.Forms.TrackBar();
            this.label55 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.diskPointWidth = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskColor3Opacity)).BeginInit();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskColor2Opacity)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskInterval)).BeginInit();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskBorderOpacity)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskBackgroundOpacity)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskColor1Opacity)).BeginInit();
            this.panel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // batteryFontDialog
            // 
            this.batteryFontDialog.AllowScriptChange = false;
            this.batteryFontDialog.ShowEffects = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(350, 233);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(104, 29);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(242, 233);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 29);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 240);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 15);
            this.label46.TabIndex = 24;
            this.label46.Text = "* - required restart";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.diskName3);
            this.panel28.Controls.Add(this.label60);
            this.panel28.Controls.Add(this.diskColor3);
            this.panel28.Controls.Add(this.diskColor3Button);
            this.panel28.Controls.Add(this.diskColor3Opacity);
            this.panel28.Controls.Add(this.label61);
            this.panel28.Location = new System.Drawing.Point(4, 102);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(450, 32);
            this.panel28.TabIndex = 117;
            // 
            // diskName3
            // 
            this.diskName3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskName3.FormattingEnabled = true;
            this.diskName3.Location = new System.Drawing.Point(56, 4);
            this.diskName3.Name = "diskName3";
            this.diskName3.Size = new System.Drawing.Size(103, 23);
            this.diskName3.TabIndex = 81;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(5, 8);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(43, 15);
            this.label60.TabIndex = 72;
            this.label60.Text = "Disk 3*";
            // 
            // diskColor3
            // 
            this.diskColor3.Location = new System.Drawing.Point(164, 4);
            this.diskColor3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor3.Name = "diskColor3";
            this.diskColor3.Size = new System.Drawing.Size(94, 23);
            this.diskColor3.TabIndex = 71;
            // 
            // diskColor3Button
            // 
            this.diskColor3Button.Location = new System.Drawing.Point(263, 3);
            this.diskColor3Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor3Button.Name = "diskColor3Button";
            this.diskColor3Button.Size = new System.Drawing.Size(49, 25);
            this.diskColor3Button.TabIndex = 75;
            this.diskColor3Button.Text = "Color";
            this.diskColor3Button.UseVisualStyleBackColor = true;
            // 
            // diskColor3Opacity
            // 
            this.diskColor3Opacity.AutoSize = false;
            this.diskColor3Opacity.Location = new System.Drawing.Point(366, 6);
            this.diskColor3Opacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor3Opacity.Maximum = 255;
            this.diskColor3Opacity.Name = "diskColor3Opacity";
            this.diskColor3Opacity.Size = new System.Drawing.Size(78, 18);
            this.diskColor3Opacity.TabIndex = 77;
            this.diskColor3Opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(317, 8);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(48, 15);
            this.label61.TabIndex = 79;
            this.label61.Text = "Opacity";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.diskName2);
            this.panel27.Controls.Add(this.label58);
            this.panel27.Controls.Add(this.diskColor2);
            this.panel27.Controls.Add(this.diskColor2Button);
            this.panel27.Controls.Add(this.diskColor2Opacity);
            this.panel27.Controls.Add(this.label59);
            this.panel27.Location = new System.Drawing.Point(4, 70);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(450, 32);
            this.panel27.TabIndex = 116;
            // 
            // diskName2
            // 
            this.diskName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskName2.FormattingEnabled = true;
            this.diskName2.Location = new System.Drawing.Point(56, 4);
            this.diskName2.Name = "diskName2";
            this.diskName2.Size = new System.Drawing.Size(103, 23);
            this.diskName2.TabIndex = 81;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(5, 8);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(43, 15);
            this.label58.TabIndex = 72;
            this.label58.Text = "Disk 2*";
            // 
            // diskColor2
            // 
            this.diskColor2.Location = new System.Drawing.Point(164, 4);
            this.diskColor2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor2.Name = "diskColor2";
            this.diskColor2.Size = new System.Drawing.Size(94, 23);
            this.diskColor2.TabIndex = 71;
            // 
            // diskColor2Button
            // 
            this.diskColor2Button.Location = new System.Drawing.Point(263, 3);
            this.diskColor2Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor2Button.Name = "diskColor2Button";
            this.diskColor2Button.Size = new System.Drawing.Size(49, 25);
            this.diskColor2Button.TabIndex = 75;
            this.diskColor2Button.Text = "Color";
            this.diskColor2Button.UseVisualStyleBackColor = true;
            // 
            // diskColor2Opacity
            // 
            this.diskColor2Opacity.AutoSize = false;
            this.diskColor2Opacity.Location = new System.Drawing.Point(366, 6);
            this.diskColor2Opacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor2Opacity.Maximum = 255;
            this.diskColor2Opacity.Name = "diskColor2Opacity";
            this.diskColor2Opacity.Size = new System.Drawing.Size(78, 18);
            this.diskColor2Opacity.TabIndex = 77;
            this.diskColor2Opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(317, 8);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(48, 15);
            this.label59.TabIndex = 79;
            this.label59.Text = "Opacity";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label48);
            this.panel22.Controls.Add(this.diskInterval);
            this.panel22.Controls.Add(this.label49);
            this.panel22.Location = new System.Drawing.Point(4, 196);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(450, 32);
            this.panel22.TabIndex = 113;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(5, 8);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(92, 15);
            this.label48.TabIndex = 82;
            this.label48.Text = "Update interval*";
            // 
            // diskInterval
            // 
            this.diskInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.diskInterval.Location = new System.Drawing.Point(98, 4);
            this.diskInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.diskInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.diskInterval.Name = "diskInterval";
            this.diskInterval.Size = new System.Drawing.Size(65, 23);
            this.diskInterval.TabIndex = 81;
            this.diskInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(165, 8);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(23, 15);
            this.label49.TabIndex = 89;
            this.label49.Text = "ms";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.label50);
            this.panel23.Controls.Add(this.diskBorderText);
            this.panel23.Controls.Add(this.diskBorderButton);
            this.panel23.Controls.Add(this.diskBorderOpacity);
            this.panel23.Controls.Add(this.label51);
            this.panel23.Location = new System.Drawing.Point(4, 164);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(450, 32);
            this.panel23.TabIndex = 112;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(5, 8);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(42, 15);
            this.label50.TabIndex = 84;
            this.label50.Text = "Border";
            // 
            // diskBorderText
            // 
            this.diskBorderText.Location = new System.Drawing.Point(164, 4);
            this.diskBorderText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskBorderText.Name = "diskBorderText";
            this.diskBorderText.Size = new System.Drawing.Size(94, 23);
            this.diskBorderText.TabIndex = 83;
            // 
            // diskBorderButton
            // 
            this.diskBorderButton.Location = new System.Drawing.Point(263, 3);
            this.diskBorderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskBorderButton.Name = "diskBorderButton";
            this.diskBorderButton.Size = new System.Drawing.Size(49, 25);
            this.diskBorderButton.TabIndex = 85;
            this.diskBorderButton.Text = "Color";
            this.diskBorderButton.UseVisualStyleBackColor = true;
            // 
            // diskBorderOpacity
            // 
            this.diskBorderOpacity.AutoSize = false;
            this.diskBorderOpacity.Location = new System.Drawing.Point(366, 6);
            this.diskBorderOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskBorderOpacity.Maximum = 255;
            this.diskBorderOpacity.Name = "diskBorderOpacity";
            this.diskBorderOpacity.Size = new System.Drawing.Size(78, 18);
            this.diskBorderOpacity.TabIndex = 86;
            this.diskBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(317, 8);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(48, 15);
            this.label51.TabIndex = 87;
            this.label51.Text = "Opacity";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.label52);
            this.panel24.Controls.Add(this.diskBackgroundText);
            this.panel24.Controls.Add(this.diskBackgroundButton);
            this.panel24.Controls.Add(this.diskBackgroundOpacity);
            this.panel24.Controls.Add(this.label53);
            this.panel24.Location = new System.Drawing.Point(4, 132);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(450, 32);
            this.panel24.TabIndex = 111;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(5, 8);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(71, 15);
            this.label52.TabIndex = 74;
            this.label52.Text = "Background";
            // 
            // diskBackgroundText
            // 
            this.diskBackgroundText.Location = new System.Drawing.Point(164, 4);
            this.diskBackgroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskBackgroundText.Name = "diskBackgroundText";
            this.diskBackgroundText.Size = new System.Drawing.Size(94, 23);
            this.diskBackgroundText.TabIndex = 73;
            // 
            // diskBackgroundButton
            // 
            this.diskBackgroundButton.Location = new System.Drawing.Point(263, 3);
            this.diskBackgroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskBackgroundButton.Name = "diskBackgroundButton";
            this.diskBackgroundButton.Size = new System.Drawing.Size(49, 25);
            this.diskBackgroundButton.TabIndex = 76;
            this.diskBackgroundButton.Text = "Color";
            this.diskBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // diskBackgroundOpacity
            // 
            this.diskBackgroundOpacity.AutoSize = false;
            this.diskBackgroundOpacity.Location = new System.Drawing.Point(366, 6);
            this.diskBackgroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskBackgroundOpacity.Maximum = 255;
            this.diskBackgroundOpacity.Name = "diskBackgroundOpacity";
            this.diskBackgroundOpacity.Size = new System.Drawing.Size(78, 18);
            this.diskBackgroundOpacity.TabIndex = 78;
            this.diskBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(317, 8);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(48, 15);
            this.label53.TabIndex = 80;
            this.label53.Text = "Opacity";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.diskName1);
            this.panel25.Controls.Add(this.label54);
            this.panel25.Controls.Add(this.diskColor1);
            this.panel25.Controls.Add(this.diskColor1Button);
            this.panel25.Controls.Add(this.diskColor1Opacity);
            this.panel25.Controls.Add(this.label55);
            this.panel25.Location = new System.Drawing.Point(4, 38);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(450, 32);
            this.panel25.TabIndex = 110;
            // 
            // diskName1
            // 
            this.diskName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskName1.FormattingEnabled = true;
            this.diskName1.Location = new System.Drawing.Point(56, 4);
            this.diskName1.Name = "diskName1";
            this.diskName1.Size = new System.Drawing.Size(103, 23);
            this.diskName1.TabIndex = 80;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(5, 8);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(43, 15);
            this.label54.TabIndex = 72;
            this.label54.Text = "Disk 1*";
            // 
            // diskColor1
            // 
            this.diskColor1.Location = new System.Drawing.Point(164, 4);
            this.diskColor1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor1.Name = "diskColor1";
            this.diskColor1.Size = new System.Drawing.Size(94, 23);
            this.diskColor1.TabIndex = 71;
            // 
            // diskColor1Button
            // 
            this.diskColor1Button.Location = new System.Drawing.Point(263, 3);
            this.diskColor1Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor1Button.Name = "diskColor1Button";
            this.diskColor1Button.Size = new System.Drawing.Size(49, 25);
            this.diskColor1Button.TabIndex = 75;
            this.diskColor1Button.Text = "Color";
            this.diskColor1Button.UseVisualStyleBackColor = true;
            // 
            // diskColor1Opacity
            // 
            this.diskColor1Opacity.AutoSize = false;
            this.diskColor1Opacity.Location = new System.Drawing.Point(366, 6);
            this.diskColor1Opacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskColor1Opacity.Maximum = 255;
            this.diskColor1Opacity.Name = "diskColor1Opacity";
            this.diskColor1Opacity.Size = new System.Drawing.Size(78, 18);
            this.diskColor1Opacity.TabIndex = 77;
            this.diskColor1Opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(317, 8);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(48, 15);
            this.label55.TabIndex = 79;
            this.label55.Text = "Opacity";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label56);
            this.panel26.Controls.Add(this.diskPointWidth);
            this.panel26.Controls.Add(this.label57);
            this.panel26.Location = new System.Drawing.Point(4, 6);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(450, 32);
            this.panel26.TabIndex = 109;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(5, 8);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(68, 15);
            this.label56.TabIndex = 69;
            this.label56.Text = "Point width";
            // 
            // diskPointWidth
            // 
            this.diskPointWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diskPointWidth.FormattingEnabled = true;
            this.diskPointWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.diskPointWidth.Location = new System.Drawing.Point(98, 4);
            this.diskPointWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diskPointWidth.Name = "diskPointWidth";
            this.diskPointWidth.Size = new System.Drawing.Size(67, 23);
            this.diskPointWidth.TabIndex = 68;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(167, 8);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(19, 15);
            this.label57.TabIndex = 70;
            this.label57.Text = "px";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(458, 266);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskColor3Opacity)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskColor2Opacity)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskInterval)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskBorderOpacity)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskBackgroundOpacity)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diskColor1Opacity)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog batteryFontDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.ComboBox diskName3;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox diskColor3;
        private System.Windows.Forms.Button diskColor3Button;
        private System.Windows.Forms.TrackBar diskColor3Opacity;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.ComboBox diskName2;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox diskColor2;
        private System.Windows.Forms.Button diskColor2Button;
        private System.Windows.Forms.TrackBar diskColor2Opacity;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown diskInterval;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox diskBorderText;
        private System.Windows.Forms.Button diskBorderButton;
        private System.Windows.Forms.TrackBar diskBorderOpacity;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox diskBackgroundText;
        private System.Windows.Forms.Button diskBackgroundButton;
        private System.Windows.Forms.TrackBar diskBackgroundOpacity;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.ComboBox diskName1;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox diskColor1;
        private System.Windows.Forms.Button diskColor1Button;
        private System.Windows.Forms.TrackBar diskColor1Opacity;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox diskPointWidth;
        private System.Windows.Forms.Label label57;
    }
}