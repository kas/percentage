namespace RamIcon
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.ramInterval = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.ramBorderText = new System.Windows.Forms.TextBox();
            this.ramBorderButton = new System.Windows.Forms.Button();
            this.ramBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.ramBackgroundText = new System.Windows.Forms.TextBox();
            this.ramBackgroundButton = new System.Windows.Forms.Button();
            this.ramBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.ramForegroundText = new System.Windows.Forms.TextBox();
            this.ramForegroundButton = new System.Windows.Forms.Button();
            this.ramForegroundOpacity = new System.Windows.Forms.TrackBar();
            this.label22 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.ramPointWidth = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramInterval)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramBorderOpacity)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramBackgroundOpacity)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramForegroundOpacity)).BeginInit();
            this.panel11.SuspendLayout();
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
            this.buttonOk.Location = new System.Drawing.Point(355, 171);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(104, 28);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(247, 171);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 178);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 15);
            this.label46.TabIndex = 24;
            this.label46.Text = "* - required restart";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label20);
            this.panel15.Controls.Add(this.ramInterval);
            this.panel15.Controls.Add(this.label17);
            this.panel15.Location = new System.Drawing.Point(8, 135);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(450, 31);
            this.panel15.TabIndex = 99;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 8);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 15);
            this.label20.TabIndex = 82;
            this.label20.Text = "Update interval*";
            // 
            // ramInterval
            // 
            this.ramInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ramInterval.Location = new System.Drawing.Point(98, 4);
            this.ramInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ramInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ramInterval.Name = "ramInterval";
            this.ramInterval.Size = new System.Drawing.Size(65, 23);
            this.ramInterval.TabIndex = 81;
            this.ramInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(165, 8);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 15);
            this.label17.TabIndex = 89;
            this.label17.Text = "ms";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label19);
            this.panel14.Controls.Add(this.ramBorderText);
            this.panel14.Controls.Add(this.ramBorderButton);
            this.panel14.Controls.Add(this.ramBorderOpacity);
            this.panel14.Controls.Add(this.label18);
            this.panel14.Location = new System.Drawing.Point(8, 103);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(450, 31);
            this.panel14.TabIndex = 98;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 8);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 15);
            this.label19.TabIndex = 84;
            this.label19.Text = "Border";
            // 
            // ramBorderText
            // 
            this.ramBorderText.Location = new System.Drawing.Point(98, 4);
            this.ramBorderText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramBorderText.Name = "ramBorderText";
            this.ramBorderText.Size = new System.Drawing.Size(94, 23);
            this.ramBorderText.TabIndex = 83;
            // 
            // ramBorderButton
            // 
            this.ramBorderButton.Location = new System.Drawing.Point(201, 3);
            this.ramBorderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramBorderButton.Name = "ramBorderButton";
            this.ramBorderButton.Size = new System.Drawing.Size(49, 25);
            this.ramBorderButton.TabIndex = 85;
            this.ramBorderButton.Text = "Color";
            this.ramBorderButton.UseVisualStyleBackColor = true;
            // 
            // ramBorderOpacity
            // 
            this.ramBorderOpacity.AutoSize = false;
            this.ramBorderOpacity.Location = new System.Drawing.Point(315, 6);
            this.ramBorderOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramBorderOpacity.Maximum = 255;
            this.ramBorderOpacity.Name = "ramBorderOpacity";
            this.ramBorderOpacity.Size = new System.Drawing.Size(132, 18);
            this.ramBorderOpacity.TabIndex = 86;
            this.ramBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(264, 8);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 87;
            this.label18.Text = "Opacity";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label23);
            this.panel13.Controls.Add(this.ramBackgroundText);
            this.panel13.Controls.Add(this.ramBackgroundButton);
            this.panel13.Controls.Add(this.ramBackgroundOpacity);
            this.panel13.Controls.Add(this.label21);
            this.panel13.Location = new System.Drawing.Point(8, 71);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(450, 31);
            this.panel13.TabIndex = 97;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 8);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 15);
            this.label23.TabIndex = 74;
            this.label23.Text = "Background";
            // 
            // ramBackgroundText
            // 
            this.ramBackgroundText.Location = new System.Drawing.Point(98, 4);
            this.ramBackgroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramBackgroundText.Name = "ramBackgroundText";
            this.ramBackgroundText.Size = new System.Drawing.Size(94, 23);
            this.ramBackgroundText.TabIndex = 73;
            // 
            // ramBackgroundButton
            // 
            this.ramBackgroundButton.Location = new System.Drawing.Point(201, 3);
            this.ramBackgroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramBackgroundButton.Name = "ramBackgroundButton";
            this.ramBackgroundButton.Size = new System.Drawing.Size(49, 25);
            this.ramBackgroundButton.TabIndex = 76;
            this.ramBackgroundButton.Text = "Color";
            this.ramBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // ramBackgroundOpacity
            // 
            this.ramBackgroundOpacity.AutoSize = false;
            this.ramBackgroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.ramBackgroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramBackgroundOpacity.Maximum = 255;
            this.ramBackgroundOpacity.Name = "ramBackgroundOpacity";
            this.ramBackgroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.ramBackgroundOpacity.TabIndex = 78;
            this.ramBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(264, 8);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 15);
            this.label21.TabIndex = 80;
            this.label21.Text = "Opacity";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label25);
            this.panel12.Controls.Add(this.ramForegroundText);
            this.panel12.Controls.Add(this.ramForegroundButton);
            this.panel12.Controls.Add(this.ramForegroundOpacity);
            this.panel12.Controls.Add(this.label22);
            this.panel12.Location = new System.Drawing.Point(8, 39);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(450, 31);
            this.panel12.TabIndex = 96;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 8);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 15);
            this.label25.TabIndex = 72;
            this.label25.Text = "Foreground";
            // 
            // ramForegroundText
            // 
            this.ramForegroundText.Location = new System.Drawing.Point(98, 4);
            this.ramForegroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramForegroundText.Name = "ramForegroundText";
            this.ramForegroundText.Size = new System.Drawing.Size(94, 23);
            this.ramForegroundText.TabIndex = 71;
            // 
            // ramForegroundButton
            // 
            this.ramForegroundButton.Location = new System.Drawing.Point(201, 3);
            this.ramForegroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramForegroundButton.Name = "ramForegroundButton";
            this.ramForegroundButton.Size = new System.Drawing.Size(49, 25);
            this.ramForegroundButton.TabIndex = 75;
            this.ramForegroundButton.Text = "Color";
            this.ramForegroundButton.UseVisualStyleBackColor = true;
            // 
            // ramForegroundOpacity
            // 
            this.ramForegroundOpacity.AutoSize = false;
            this.ramForegroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.ramForegroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramForegroundOpacity.Maximum = 255;
            this.ramForegroundOpacity.Name = "ramForegroundOpacity";
            this.ramForegroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.ramForegroundOpacity.TabIndex = 77;
            this.ramForegroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(264, 8);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 15);
            this.label22.TabIndex = 79;
            this.label22.Text = "Opacity";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label27);
            this.panel11.Controls.Add(this.ramPointWidth);
            this.panel11.Controls.Add(this.label26);
            this.panel11.Location = new System.Drawing.Point(8, 7);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(450, 31);
            this.panel11.TabIndex = 95;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 8);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 15);
            this.label27.TabIndex = 69;
            this.label27.Text = "Point width";
            // 
            // ramPointWidth
            // 
            this.ramPointWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ramPointWidth.FormattingEnabled = true;
            this.ramPointWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.ramPointWidth.Location = new System.Drawing.Point(98, 4);
            this.ramPointWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ramPointWidth.Name = "ramPointWidth";
            this.ramPointWidth.Size = new System.Drawing.Size(67, 23);
            this.ramPointWidth.TabIndex = 68;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(167, 8);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 15);
            this.label26.TabIndex = 70;
            this.label26.Text = "px";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(466, 206);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "RamIcon Settings";
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramInterval)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramBorderOpacity)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramBackgroundOpacity)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ramForegroundOpacity)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog batteryFontDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown ramInterval;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ramBorderText;
        private System.Windows.Forms.Button ramBorderButton;
        private System.Windows.Forms.TrackBar ramBorderOpacity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox ramBackgroundText;
        private System.Windows.Forms.Button ramBackgroundButton;
        private System.Windows.Forms.TrackBar ramBackgroundOpacity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ramForegroundText;
        private System.Windows.Forms.Button ramForegroundButton;
        private System.Windows.Forms.TrackBar ramForegroundOpacity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox ramPointWidth;
        private System.Windows.Forms.Label label26;
    }
}