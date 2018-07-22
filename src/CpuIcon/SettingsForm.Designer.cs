namespace CpuIcon
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cpuBorderText = new System.Windows.Forms.TextBox();
            this.cpuBorderButton = new System.Windows.Forms.Button();
            this.cpuBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cpuBackgroundText = new System.Windows.Forms.TextBox();
            this.cpuBackgroundButton = new System.Windows.Forms.Button();
            this.cpuBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cpuForegroundText = new System.Windows.Forms.TextBox();
            this.cpuForegroundButton = new System.Windows.Forms.Button();
            this.cpuForegroundOpacity = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.cpuPointWidth = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuInterval)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBorderOpacity)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBackgroundOpacity)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuForegroundOpacity)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.buttonOk.Location = new System.Drawing.Point(348, 172);
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
            this.buttonCancel.Location = new System.Drawing.Point(239, 172);
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
            this.label46.Location = new System.Drawing.Point(13, 179);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(103, 15);
            this.label46.TabIndex = 24;
            this.label46.Text = "* - required restart";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.cpuInterval);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(2, 133);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(450, 32);
            this.panel10.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Update interval*";
            // 
            // cpuInterval
            // 
            this.cpuInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cpuInterval.Location = new System.Drawing.Point(98, 4);
            this.cpuInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.cpuInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cpuInterval.Name = "cpuInterval";
            this.cpuInterval.Size = new System.Drawing.Size(65, 23);
            this.cpuInterval.TabIndex = 59;
            this.cpuInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "ms";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.cpuBorderText);
            this.panel9.Controls.Add(this.cpuBorderButton);
            this.panel9.Controls.Add(this.cpuBorderOpacity);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(2, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(450, 32);
            this.panel9.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "Border";
            // 
            // cpuBorderText
            // 
            this.cpuBorderText.Location = new System.Drawing.Point(98, 4);
            this.cpuBorderText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuBorderText.Name = "cpuBorderText";
            this.cpuBorderText.Size = new System.Drawing.Size(94, 23);
            this.cpuBorderText.TabIndex = 61;
            // 
            // cpuBorderButton
            // 
            this.cpuBorderButton.Location = new System.Drawing.Point(201, 3);
            this.cpuBorderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuBorderButton.Name = "cpuBorderButton";
            this.cpuBorderButton.Size = new System.Drawing.Size(49, 25);
            this.cpuBorderButton.TabIndex = 63;
            this.cpuBorderButton.Text = "Color";
            this.cpuBorderButton.UseVisualStyleBackColor = true;
            // 
            // cpuBorderOpacity
            // 
            this.cpuBorderOpacity.AutoSize = false;
            this.cpuBorderOpacity.Location = new System.Drawing.Point(315, 6);
            this.cpuBorderOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuBorderOpacity.Maximum = 255;
            this.cpuBorderOpacity.Name = "cpuBorderOpacity";
            this.cpuBorderOpacity.Size = new System.Drawing.Size(132, 18);
            this.cpuBorderOpacity.TabIndex = 64;
            this.cpuBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Opacity";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.cpuBackgroundText);
            this.panel8.Controls.Add(this.cpuBackgroundButton);
            this.panel8.Controls.Add(this.cpuBackgroundOpacity);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(2, 69);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(450, 32);
            this.panel8.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Background";
            // 
            // cpuBackgroundText
            // 
            this.cpuBackgroundText.Location = new System.Drawing.Point(98, 4);
            this.cpuBackgroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuBackgroundText.Name = "cpuBackgroundText";
            this.cpuBackgroundText.Size = new System.Drawing.Size(94, 23);
            this.cpuBackgroundText.TabIndex = 51;
            // 
            // cpuBackgroundButton
            // 
            this.cpuBackgroundButton.Location = new System.Drawing.Point(201, 3);
            this.cpuBackgroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuBackgroundButton.Name = "cpuBackgroundButton";
            this.cpuBackgroundButton.Size = new System.Drawing.Size(49, 25);
            this.cpuBackgroundButton.TabIndex = 54;
            this.cpuBackgroundButton.Text = "Color";
            this.cpuBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // cpuBackgroundOpacity
            // 
            this.cpuBackgroundOpacity.AutoSize = false;
            this.cpuBackgroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.cpuBackgroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuBackgroundOpacity.Maximum = 255;
            this.cpuBackgroundOpacity.Name = "cpuBackgroundOpacity";
            this.cpuBackgroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.cpuBackgroundOpacity.TabIndex = 56;
            this.cpuBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Opacity";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.cpuForegroundText);
            this.panel7.Controls.Add(this.cpuForegroundButton);
            this.panel7.Controls.Add(this.cpuForegroundOpacity);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(2, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 32);
            this.panel7.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Foreground";
            // 
            // cpuForegroundText
            // 
            this.cpuForegroundText.Location = new System.Drawing.Point(98, 4);
            this.cpuForegroundText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuForegroundText.Name = "cpuForegroundText";
            this.cpuForegroundText.Size = new System.Drawing.Size(94, 23);
            this.cpuForegroundText.TabIndex = 49;
            // 
            // cpuForegroundButton
            // 
            this.cpuForegroundButton.Location = new System.Drawing.Point(201, 3);
            this.cpuForegroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuForegroundButton.Name = "cpuForegroundButton";
            this.cpuForegroundButton.Size = new System.Drawing.Size(49, 25);
            this.cpuForegroundButton.TabIndex = 53;
            this.cpuForegroundButton.Text = "Color";
            this.cpuForegroundButton.UseVisualStyleBackColor = true;
            // 
            // cpuForegroundOpacity
            // 
            this.cpuForegroundOpacity.AutoSize = false;
            this.cpuForegroundOpacity.Location = new System.Drawing.Point(315, 6);
            this.cpuForegroundOpacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuForegroundOpacity.Maximum = 255;
            this.cpuForegroundOpacity.Name = "cpuForegroundOpacity";
            this.cpuForegroundOpacity.Size = new System.Drawing.Size(132, 18);
            this.cpuForegroundOpacity.TabIndex = 55;
            this.cpuForegroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "Opacity";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label44);
            this.panel6.Controls.Add(this.cpuPointWidth);
            this.panel6.Controls.Add(this.label45);
            this.panel6.Location = new System.Drawing.Point(2, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(450, 32);
            this.panel6.TabIndex = 76;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(5, 8);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 15);
            this.label44.TabIndex = 47;
            this.label44.Text = "Point width";
            // 
            // cpuPointWidth
            // 
            this.cpuPointWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpuPointWidth.FormattingEnabled = true;
            this.cpuPointWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.cpuPointWidth.Location = new System.Drawing.Point(98, 4);
            this.cpuPointWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cpuPointWidth.Name = "cpuPointWidth";
            this.cpuPointWidth.Size = new System.Drawing.Size(67, 23);
            this.cpuPointWidth.TabIndex = 46;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(167, 8);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(19, 15);
            this.label45.TabIndex = 48;
            this.label45.Text = "px";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(455, 205);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuInterval)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBorderOpacity)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuBackgroundOpacity)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuForegroundOpacity)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog batteryFontDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cpuInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpuBorderText;
        private System.Windows.Forms.Button cpuBorderButton;
        private System.Windows.Forms.TrackBar cpuBorderOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cpuBackgroundText;
        private System.Windows.Forms.Button cpuBackgroundButton;
        private System.Windows.Forms.TrackBar cpuBackgroundOpacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cpuForegroundText;
        private System.Windows.Forms.Button cpuForegroundButton;
        private System.Windows.Forms.TrackBar cpuForegroundOpacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cpuPointWidth;
        private System.Windows.Forms.Label label45;
    }
}