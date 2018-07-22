namespace NetIcon
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
            this.panel21 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.networkMaxBandwidth = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.networkInterval = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.networkBorderText = new System.Windows.Forms.TextBox();
            this.networkBorderButton = new System.Windows.Forms.Button();
            this.networkBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label29 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.networkBackgroundText = new System.Windows.Forms.TextBox();
            this.networkBackgroundButton = new System.Windows.Forms.Button();
            this.networkBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label33 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.networkForegroundText = new System.Windows.Forms.TextBox();
            this.networkForegroundButton = new System.Windows.Forms.Button();
            this.networkForegroundOpacity = new System.Windows.Forms.TrackBar();
            this.label34 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.networkPointWidth = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkMaxBandwidth)).BeginInit();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkInterval)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkBorderOpacity)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkBackgroundOpacity)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkForegroundOpacity)).BeginInit();
            this.panel16.SuspendLayout();
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
            this.buttonOk.Location = new System.Drawing.Point(345, 204);
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
            this.buttonCancel.Location = new System.Drawing.Point(236, 204);
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
            this.label46.Location = new System.Drawing.Point(13, 211);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 15);
            this.label46.TabIndex = 24;
            this.label46.Text = "* - required restart";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label24);
            this.panel21.Controls.Add(this.networkMaxBandwidth);
            this.panel21.Controls.Add(this.label32);
            this.panel21.Location = new System.Drawing.Point(-2, 166);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(450, 32);
            this.panel21.TabIndex = 104;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 8);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 15);
            this.label24.TabIndex = 39;
            this.label24.Text = "Max bandwidth";
            // 
            // networkMaxBandwidth
            // 
            this.networkMaxBandwidth.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.networkMaxBandwidth.Location = new System.Drawing.Point(98, 4);
            this.networkMaxBandwidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkMaxBandwidth.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.networkMaxBandwidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.networkMaxBandwidth.Name = "networkMaxBandwidth";
            this.networkMaxBandwidth.Size = new System.Drawing.Size(96, 23);
            this.networkMaxBandwidth.TabIndex = 38;
            this.networkMaxBandwidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(198, 8);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 15);
            this.label32.TabIndex = 45;
            this.label32.Text = "kbytes/s";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label31);
            this.panel20.Controls.Add(this.networkInterval);
            this.panel20.Controls.Add(this.label28);
            this.panel20.Location = new System.Drawing.Point(-2, 134);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(450, 32);
            this.panel20.TabIndex = 103;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 8);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 15);
            this.label31.TabIndex = 82;
            this.label31.Text = "Update interval*";
            // 
            // networkInterval
            // 
            this.networkInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.networkInterval.Location = new System.Drawing.Point(98, 4);
            this.networkInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.networkInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.networkInterval.Name = "networkInterval";
            this.networkInterval.Size = new System.Drawing.Size(65, 23);
            this.networkInterval.TabIndex = 81;
            this.networkInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(165, 8);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 15);
            this.label28.TabIndex = 89;
            this.label28.Text = "ms";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label30);
            this.panel19.Controls.Add(this.networkBorderText);
            this.panel19.Controls.Add(this.networkBorderButton);
            this.panel19.Controls.Add(this.networkBorderOpacity);
            this.panel19.Controls.Add(this.label29);
            this.panel19.Location = new System.Drawing.Point(-2, 102);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(450, 32);
            this.panel19.TabIndex = 102;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 8);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 15);
            this.label30.TabIndex = 84;
            this.label30.Text = "Border";
            // 
            // networkBorderText
            // 
            this.networkBorderText.Location = new System.Drawing.Point(98, 4);
            this.networkBorderText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkBorderText.Name = "networkBorderText";
            this.networkBorderText.Size = new System.Drawing.Size(94, 23);
            this.networkBorderText.TabIndex = 83;
            // 
            // networkBorderButton
            // 
            this.networkBorderButton.Location = new System.Drawing.Point(201, 3);
            this.networkBorderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkBorderButton.Name = "networkBorderButton";
            this.networkBorderButton.Size = new System.Drawing.Size(49, 25);
            this.networkBorderButton.TabIndex = 85;
            this.networkBorderButton.Text = "Color";
            this.networkBorderButton.UseVisualStyleBackColor = true;
            // 
            // networkBorderOpacity
            // 
            this.networkBorderOpacity.AutoSize = false;
            this.networkBorderOpacity.Location = new System.Drawing.Point(315, 6);
            this.networkBorderOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkBorderOpacity.Maximum = 255;
            this.networkBorderOpacity.Name = "networkBorderOpacity";
            this.networkBorderOpacity.Size = new System.Drawing.Size(132, 18);
            this.networkBorderOpacity.TabIndex = 86;
            this.networkBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(264, 8);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 15);
            this.label29.TabIndex = 87;
            this.label29.Text = "Opacity";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label35);
            this.panel18.Controls.Add(this.networkBackgroundText);
            this.panel18.Controls.Add(this.networkBackgroundButton);
            this.panel18.Controls.Add(this.networkBackgroundOpacity);
            this.panel18.Controls.Add(this.label33);
            this.panel18.Location = new System.Drawing.Point(-2, 70);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(450, 32);
            this.panel18.TabIndex = 101;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 8);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 15);
            this.label35.TabIndex = 74;
            this.label35.Text = "Background";
            // 
            // networkBackgroundText
            // 
            this.networkBackgroundText.Location = new System.Drawing.Point(98, 4);
            this.networkBackgroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkBackgroundText.Name = "networkBackgroundText";
            this.networkBackgroundText.Size = new System.Drawing.Size(94, 23);
            this.networkBackgroundText.TabIndex = 73;
            // 
            // networkBackgroundButton
            // 
            this.networkBackgroundButton.Location = new System.Drawing.Point(201, 3);
            this.networkBackgroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkBackgroundButton.Name = "networkBackgroundButton";
            this.networkBackgroundButton.Size = new System.Drawing.Size(49, 25);
            this.networkBackgroundButton.TabIndex = 76;
            this.networkBackgroundButton.Text = "Color";
            this.networkBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // networkBackgroundOpacity
            // 
            this.networkBackgroundOpacity.AutoSize = false;
            this.networkBackgroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.networkBackgroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkBackgroundOpacity.Maximum = 255;
            this.networkBackgroundOpacity.Name = "networkBackgroundOpacity";
            this.networkBackgroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.networkBackgroundOpacity.TabIndex = 78;
            this.networkBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(264, 8);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(48, 15);
            this.label33.TabIndex = 80;
            this.label33.Text = "Opacity";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label36);
            this.panel17.Controls.Add(this.networkForegroundText);
            this.panel17.Controls.Add(this.networkForegroundButton);
            this.panel17.Controls.Add(this.networkForegroundOpacity);
            this.panel17.Controls.Add(this.label34);
            this.panel17.Location = new System.Drawing.Point(-2, 38);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(450, 32);
            this.panel17.TabIndex = 100;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(5, 8);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 15);
            this.label36.TabIndex = 72;
            this.label36.Text = "Foreground";
            // 
            // networkForegroundText
            // 
            this.networkForegroundText.Location = new System.Drawing.Point(98, 4);
            this.networkForegroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkForegroundText.Name = "networkForegroundText";
            this.networkForegroundText.Size = new System.Drawing.Size(94, 23);
            this.networkForegroundText.TabIndex = 71;
            // 
            // networkForegroundButton
            // 
            this.networkForegroundButton.Location = new System.Drawing.Point(201, 3);
            this.networkForegroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkForegroundButton.Name = "networkForegroundButton";
            this.networkForegroundButton.Size = new System.Drawing.Size(49, 25);
            this.networkForegroundButton.TabIndex = 75;
            this.networkForegroundButton.Text = "Color";
            this.networkForegroundButton.UseVisualStyleBackColor = true;
            // 
            // networkForegroundOpacity
            // 
            this.networkForegroundOpacity.AutoSize = false;
            this.networkForegroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.networkForegroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkForegroundOpacity.Maximum = 255;
            this.networkForegroundOpacity.Name = "networkForegroundOpacity";
            this.networkForegroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.networkForegroundOpacity.TabIndex = 77;
            this.networkForegroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(264, 8);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 15);
            this.label34.TabIndex = 79;
            this.label34.Text = "Opacity";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label38);
            this.panel16.Controls.Add(this.networkPointWidth);
            this.panel16.Controls.Add(this.label37);
            this.panel16.Location = new System.Drawing.Point(-2, 6);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(450, 32);
            this.panel16.TabIndex = 99;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(5, 8);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(68, 15);
            this.label38.TabIndex = 69;
            this.label38.Text = "Point width";
            // 
            // networkPointWidth
            // 
            this.networkPointWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkPointWidth.FormattingEnabled = true;
            this.networkPointWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.networkPointWidth.Location = new System.Drawing.Point(98, 4);
            this.networkPointWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.networkPointWidth.Name = "networkPointWidth";
            this.networkPointWidth.Size = new System.Drawing.Size(67, 23);
            this.networkPointWidth.TabIndex = 68;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(167, 8);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(19, 15);
            this.label37.TabIndex = 70;
            this.label37.Text = "px";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(452, 237);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkMaxBandwidth)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkInterval)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkBorderOpacity)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkBackgroundOpacity)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkForegroundOpacity)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog batteryFontDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown networkMaxBandwidth;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown networkInterval;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox networkBorderText;
        private System.Windows.Forms.Button networkBorderButton;
        private System.Windows.Forms.TrackBar networkBorderOpacity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox networkBackgroundText;
        private System.Windows.Forms.Button networkBackgroundButton;
        private System.Windows.Forms.TrackBar networkBackgroundOpacity;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox networkForegroundText;
        private System.Windows.Forms.Button networkForegroundButton;
        private System.Windows.Forms.TrackBar networkForegroundOpacity;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox networkPointWidth;
        private System.Windows.Forms.Label label37;
    }
}