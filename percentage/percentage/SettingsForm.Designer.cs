namespace percentage
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textFont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textForeground = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBackground = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEditForeground = new System.Windows.Forms.Button();
            this.buttonEditBackground = new System.Windows.Forms.Button();
            this.buttonEditFont = new System.Windows.Forms.Button();
            this.sliderForeground = new System.Windows.Forms.TrackBar();
            this.sliderBackground = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sliderBorder = new System.Windows.Forms.TrackBar();
            this.buttonEditBorder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBorder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sliderForeground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // textFont
            // 
            this.textFont.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFont.Location = new System.Drawing.Point(155, 27);
            this.textFont.Name = "textFont";
            this.textFont.ReadOnly = true;
            this.textFont.Size = new System.Drawing.Size(460, 33);
            this.textFont.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Foreground:";
            // 
            // textForeground
            // 
            this.textForeground.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textForeground.Location = new System.Drawing.Point(155, 76);
            this.textForeground.Name = "textForeground";
            this.textForeground.Size = new System.Drawing.Size(142, 33);
            this.textForeground.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Background:";
            // 
            // textBackground
            // 
            this.textBackground.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBackground.Location = new System.Drawing.Point(155, 125);
            this.textBackground.Name = "textBackground";
            this.textBackground.Size = new System.Drawing.Size(142, 33);
            this.textBackground.TabIndex = 4;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(530, 282);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(168, 46);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(361, 282);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(154, 46);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEditForeground
            // 
            this.buttonEditForeground.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditForeground.Location = new System.Drawing.Point(307, 78);
            this.buttonEditForeground.Name = "buttonEditForeground";
            this.buttonEditForeground.Size = new System.Drawing.Size(77, 31);
            this.buttonEditForeground.TabIndex = 8;
            this.buttonEditForeground.Text = "Color";
            this.buttonEditForeground.UseVisualStyleBackColor = true;
            this.buttonEditForeground.Click += new System.EventHandler(this.buttonEditForeground_Click);
            // 
            // buttonEditBackground
            // 
            this.buttonEditBackground.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBackground.Location = new System.Drawing.Point(307, 127);
            this.buttonEditBackground.Name = "buttonEditBackground";
            this.buttonEditBackground.Size = new System.Drawing.Size(77, 31);
            this.buttonEditBackground.TabIndex = 9;
            this.buttonEditBackground.Text = "Color";
            this.buttonEditBackground.UseVisualStyleBackColor = true;
            this.buttonEditBackground.Click += new System.EventHandler(this.buttonEditBackground_Click);
            // 
            // buttonEditFont
            // 
            this.buttonEditFont.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFont.Location = new System.Drawing.Point(621, 27);
            this.buttonEditFont.Name = "buttonEditFont";
            this.buttonEditFont.Size = new System.Drawing.Size(95, 33);
            this.buttonEditFont.TabIndex = 10;
            this.buttonEditFont.Text = "Font";
            this.buttonEditFont.UseVisualStyleBackColor = true;
            this.buttonEditFont.Click += new System.EventHandler(this.buttonEditFont_Click);
            // 
            // sliderForeground
            // 
            this.sliderForeground.AutoSize = false;
            this.sliderForeground.Location = new System.Drawing.Point(559, 78);
            this.sliderForeground.Maximum = 255;
            this.sliderForeground.Name = "sliderForeground";
            this.sliderForeground.Size = new System.Drawing.Size(168, 31);
            this.sliderForeground.TabIndex = 12;
            this.sliderForeground.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderForeground.Scroll += new System.EventHandler(this.sliderForeground_Scroll);
            // 
            // sliderBackground
            // 
            this.sliderBackground.AutoSize = false;
            this.sliderBackground.Location = new System.Drawing.Point(559, 127);
            this.sliderBackground.Maximum = 255;
            this.sliderBackground.Name = "sliderBackground";
            this.sliderBackground.Size = new System.Drawing.Size(168, 31);
            this.sliderBackground.TabIndex = 13;
            this.sliderBackground.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderBackground.Scroll += new System.EventHandler(this.sliderBackground_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Transparency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Transparency:";
            // 
            // numericUpdateInterval
            // 
            this.numericUpdateInterval.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpdateInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpdateInterval.Location = new System.Drawing.Point(202, 217);
            this.numericUpdateInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpdateInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpdateInterval.Name = "numericUpdateInterval";
            this.numericUpdateInterval.Size = new System.Drawing.Size(102, 33);
            this.numericUpdateInterval.TabIndex = 16;
            this.numericUpdateInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Update interval:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Transparency:";
            // 
            // sliderBorder
            // 
            this.sliderBorder.AutoSize = false;
            this.sliderBorder.Location = new System.Drawing.Point(558, 176);
            this.sliderBorder.Maximum = 255;
            this.sliderBorder.Name = "sliderBorder";
            this.sliderBorder.Size = new System.Drawing.Size(168, 31);
            this.sliderBorder.TabIndex = 21;
            this.sliderBorder.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderBorder.Scroll += new System.EventHandler(this.sliderBorder_Scroll);
            // 
            // buttonEditBorder
            // 
            this.buttonEditBorder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBorder.Location = new System.Drawing.Point(306, 176);
            this.buttonEditBorder.Name = "buttonEditBorder";
            this.buttonEditBorder.Size = new System.Drawing.Size(77, 31);
            this.buttonEditBorder.TabIndex = 20;
            this.buttonEditBorder.Text = "Color";
            this.buttonEditBorder.UseVisualStyleBackColor = true;
            this.buttonEditBorder.Click += new System.EventHandler(this.buttonEditBorder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Border:";
            // 
            // textBorder
            // 
            this.textBorder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBorder.Location = new System.Drawing.Point(154, 174);
            this.textBorder.Name = "textBorder";
            this.textBorder.Size = new System.Drawing.Size(142, 33);
            this.textBorder.TabIndex = 18;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 350);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sliderBorder);
            this.Controls.Add(this.buttonEditBorder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpdateInterval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sliderBackground);
            this.Controls.Add(this.sliderForeground);
            this.Controls.Add(this.buttonEditFont);
            this.Controls.Add(this.buttonEditBackground);
            this.Controls.Add(this.buttonEditForeground);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textForeground);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.sliderForeground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textForeground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBackground;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditForeground;
        private System.Windows.Forms.Button buttonEditBackground;
        private System.Windows.Forms.Button buttonEditFont;
        private System.Windows.Forms.TrackBar sliderForeground;
        private System.Windows.Forms.TrackBar sliderBackground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpdateInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar sliderBorder;
        private System.Windows.Forms.Button buttonEditBorder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBorder;
    }
}