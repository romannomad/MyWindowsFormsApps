namespace ThemeSwitcher
{
    partial class Form1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.radioContrast = new System.Windows.Forms.RadioButton();
            this.radioDark = new System.Windows.Forms.RadioButton();
            this.radioLight = new System.Windows.Forms.RadioButton();
            this.radioOrange = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioOrange);
            this.groupBox.Controls.Add(this.lblPreview);
            this.groupBox.Controls.Add(this.radioContrast);
            this.groupBox.Controls.Add(this.radioDark);
            this.groupBox.Controls.Add(this.radioLight);
            this.groupBox.Location = new System.Drawing.Point(71, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(682, 239);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(181, 171);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(277, 42);
            this.lblPreview.TabIndex = 3;
            this.lblPreview.Text = "Theme Preview";
            // 
            // radioContrast
            // 
            this.radioContrast.AutoSize = true;
            this.radioContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContrast.Location = new System.Drawing.Point(371, 74);
            this.radioContrast.Name = "radioContrast";
            this.radioContrast.Size = new System.Drawing.Size(107, 29);
            this.radioContrast.TabIndex = 2;
            this.radioContrast.TabStop = true;
            this.radioContrast.Text = "Contrast";
            this.radioContrast.UseVisualStyleBackColor = true;
            this.radioContrast.CheckedChanged += new System.EventHandler(this.radioContrast_CheckedChanged);
            // 
            // radioDark
            // 
            this.radioDark.AutoSize = true;
            this.radioDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDark.Location = new System.Drawing.Point(228, 75);
            this.radioDark.Name = "radioDark";
            this.radioDark.Size = new System.Drawing.Size(74, 29);
            this.radioDark.TabIndex = 1;
            this.radioDark.TabStop = true;
            this.radioDark.Text = "Dark";
            this.radioDark.UseVisualStyleBackColor = true;
            this.radioDark.CheckedChanged += new System.EventHandler(this.radioDark_CheckedChanged);
            // 
            // radioLight
            // 
            this.radioLight.AutoSize = true;
            this.radioLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLight.Location = new System.Drawing.Point(61, 75);
            this.radioLight.Name = "radioLight";
            this.radioLight.Size = new System.Drawing.Size(75, 29);
            this.radioLight.TabIndex = 0;
            this.radioLight.TabStop = true;
            this.radioLight.Text = "Light";
            this.radioLight.UseVisualStyleBackColor = true;
            this.radioLight.CheckedChanged += new System.EventHandler(this.radioLight_CheckedChanged);
            // 
            // radioOrange
            // 
            this.radioOrange.AutoSize = true;
            this.radioOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOrange.Location = new System.Drawing.Point(525, 75);
            this.radioOrange.Name = "radioOrange";
            this.radioOrange.Size = new System.Drawing.Size(99, 29);
            this.radioOrange.TabIndex = 4;
            this.radioOrange.TabStop = true;
            this.radioOrange.Text = "Orange";
            this.radioOrange.UseVisualStyleBackColor = true;
            this.radioOrange.CheckedChanged += new System.EventHandler(this.radioOrange_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 494);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Theme Switcher";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.RadioButton radioContrast;
        private System.Windows.Forms.RadioButton radioDark;
        private System.Windows.Forms.RadioButton radioLight;
        private System.Windows.Forms.RadioButton radioOrange;
    }
}

