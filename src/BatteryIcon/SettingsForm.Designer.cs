namespace BatteryIcon
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.batteryInterval = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.batteryBorderText = new System.Windows.Forms.TextBox();
            this.batteryBorderButton = new System.Windows.Forms.Button();
            this.batteryBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.batteryBackgroundText = new System.Windows.Forms.TextBox();
            this.batteryBackgroundButton = new System.Windows.Forms.Button();
            this.batteryBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.batteryForegroundText = new System.Windows.Forms.TextBox();
            this.batteryForegroundButton = new System.Windows.Forms.Button();
            this.batteryForegroundOpacity = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.batteryScaling = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.batteryFontText = new System.Windows.Forms.TextBox();
            this.batteryFontButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryInterval)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryBorderOpacity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryBackgroundOpacity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryForegroundOpacity)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.buttonOk.Location = new System.Drawing.Point(354, 171);
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
            this.buttonCancel.Location = new System.Drawing.Point(246, 171);
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
            this.label46.Location = new System.Drawing.Point(13, 178);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 15);
            this.label46.TabIndex = 24;
            this.label46.Text = "* - required restart";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.batteryInterval);
            this.panel5.Controls.Add(this.label40);
            this.panel5.Location = new System.Drawing.Point(7, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 32);
            this.panel5.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Update interval*";
            // 
            // batteryInterval
            // 
            this.batteryInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.batteryInterval.Location = new System.Drawing.Point(98, 4);
            this.batteryInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.batteryInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.batteryInterval.Name = "batteryInterval";
            this.batteryInterval.Size = new System.Drawing.Size(65, 23);
            this.batteryInterval.TabIndex = 36;
            this.batteryInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(165, 8);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(23, 15);
            this.label40.TabIndex = 44;
            this.label40.Text = "ms";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.batteryBorderText);
            this.panel4.Controls.Add(this.batteryBorderButton);
            this.panel4.Controls.Add(this.batteryBorderOpacity);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(7, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 32);
            this.panel4.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Border";
            // 
            // batteryBorderText
            // 
            this.batteryBorderText.Location = new System.Drawing.Point(98, 4);
            this.batteryBorderText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryBorderText.Name = "batteryBorderText";
            this.batteryBorderText.Size = new System.Drawing.Size(94, 23);
            this.batteryBorderText.TabIndex = 38;
            // 
            // batteryBorderButton
            // 
            this.batteryBorderButton.Location = new System.Drawing.Point(201, 3);
            this.batteryBorderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryBorderButton.Name = "batteryBorderButton";
            this.batteryBorderButton.Size = new System.Drawing.Size(49, 25);
            this.batteryBorderButton.TabIndex = 40;
            this.batteryBorderButton.Text = "Color";
            this.batteryBorderButton.UseVisualStyleBackColor = true;
            // 
            // batteryBorderOpacity
            // 
            this.batteryBorderOpacity.AutoSize = false;
            this.batteryBorderOpacity.Location = new System.Drawing.Point(315, 6);
            this.batteryBorderOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryBorderOpacity.Maximum = 255;
            this.batteryBorderOpacity.Name = "batteryBorderOpacity";
            this.batteryBorderOpacity.Size = new System.Drawing.Size(132, 18);
            this.batteryBorderOpacity.TabIndex = 41;
            this.batteryBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Opacity";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.batteryBackgroundText);
            this.panel3.Controls.Add(this.batteryBackgroundButton);
            this.panel3.Controls.Add(this.batteryBackgroundOpacity);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(7, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 32);
            this.panel3.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Background";
            // 
            // batteryBackgroundText
            // 
            this.batteryBackgroundText.Location = new System.Drawing.Point(98, 4);
            this.batteryBackgroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryBackgroundText.Name = "batteryBackgroundText";
            this.batteryBackgroundText.Size = new System.Drawing.Size(94, 23);
            this.batteryBackgroundText.TabIndex = 27;
            // 
            // batteryBackgroundButton
            // 
            this.batteryBackgroundButton.Location = new System.Drawing.Point(201, 3);
            this.batteryBackgroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryBackgroundButton.Name = "batteryBackgroundButton";
            this.batteryBackgroundButton.Size = new System.Drawing.Size(49, 25);
            this.batteryBackgroundButton.TabIndex = 30;
            this.batteryBackgroundButton.Text = "Color";
            this.batteryBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // batteryBackgroundOpacity
            // 
            this.batteryBackgroundOpacity.AutoSize = false;
            this.batteryBackgroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.batteryBackgroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryBackgroundOpacity.Maximum = 255;
            this.batteryBackgroundOpacity.Name = "batteryBackgroundOpacity";
            this.batteryBackgroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.batteryBackgroundOpacity.TabIndex = 33;
            this.batteryBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Opacity";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.batteryForegroundText);
            this.panel2.Controls.Add(this.batteryForegroundButton);
            this.panel2.Controls.Add(this.batteryForegroundOpacity);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(7, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 32);
            this.panel2.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Foreground";
            // 
            // batteryForegroundText
            // 
            this.batteryForegroundText.Location = new System.Drawing.Point(98, 4);
            this.batteryForegroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryForegroundText.Name = "batteryForegroundText";
            this.batteryForegroundText.Size = new System.Drawing.Size(94, 23);
            this.batteryForegroundText.TabIndex = 25;
            // 
            // batteryForegroundButton
            // 
            this.batteryForegroundButton.Location = new System.Drawing.Point(201, 3);
            this.batteryForegroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryForegroundButton.Name = "batteryForegroundButton";
            this.batteryForegroundButton.Size = new System.Drawing.Size(49, 25);
            this.batteryForegroundButton.TabIndex = 29;
            this.batteryForegroundButton.Text = "Color";
            this.batteryForegroundButton.UseVisualStyleBackColor = true;
            // 
            // batteryForegroundOpacity
            // 
            this.batteryForegroundOpacity.AutoSize = false;
            this.batteryForegroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.batteryForegroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryForegroundOpacity.Maximum = 255;
            this.batteryForegroundOpacity.Name = "batteryForegroundOpacity";
            this.batteryForegroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.batteryForegroundOpacity.TabIndex = 32;
            this.batteryForegroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Opacity";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.batteryScaling);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.batteryFontText);
            this.panel1.Controls.Add(this.batteryFontButton);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 32);
            this.panel1.TabIndex = 53;
            // 
            // batteryScaling
            // 
            this.batteryScaling.AutoSize = true;
            this.batteryScaling.Location = new System.Drawing.Point(377, 7);
            this.batteryScaling.Name = "batteryScaling";
            this.batteryScaling.Size = new System.Drawing.Size(64, 19);
            this.batteryScaling.TabIndex = 32;
            this.batteryScaling.Text = "Scaling";
            this.batteryScaling.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 8);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "Font";
            // 
            // batteryFontText
            // 
            this.batteryFontText.Location = new System.Drawing.Point(98, 4);
            this.batteryFontText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryFontText.Name = "batteryFontText";
            this.batteryFontText.ReadOnly = true;
            this.batteryFontText.Size = new System.Drawing.Size(210, 23);
            this.batteryFontText.TabIndex = 23;
            // 
            // batteryFontButton
            // 
            this.batteryFontButton.Location = new System.Drawing.Point(312, 3);
            this.batteryFontButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.batteryFontButton.Name = "batteryFontButton";
            this.batteryFontButton.Size = new System.Drawing.Size(49, 25);
            this.batteryFontButton.TabIndex = 31;
            this.batteryFontButton.Text = "Font";
            this.batteryFontButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(462, 205);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "BatteryIcon Settings";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryInterval)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryBorderOpacity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryBackgroundOpacity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryForegroundOpacity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog batteryFontDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown batteryInterval;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox batteryBorderText;
        private System.Windows.Forms.Button batteryBorderButton;
        private System.Windows.Forms.TrackBar batteryBorderOpacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox batteryBackgroundText;
        private System.Windows.Forms.Button batteryBackgroundButton;
        private System.Windows.Forms.TrackBar batteryBackgroundOpacity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox batteryForegroundText;
        private System.Windows.Forms.Button batteryForegroundButton;
        private System.Windows.Forms.TrackBar batteryForegroundOpacity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox batteryScaling;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox batteryFontText;
        private System.Windows.Forms.Button batteryFontButton;
    }
}