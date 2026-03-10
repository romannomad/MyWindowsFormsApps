namespace UnitConverter
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.radioMilesToKm = new System.Windows.Forms.RadioButton();
            this.radioKmToMiles = new System.Windows.Forms.RadioButton();
            this.radioChangeColor = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioChangeColor);
            this.groupBox.Controls.Add(this.lblResult);
            this.groupBox.Controls.Add(this.btnConvert);
            this.groupBox.Controls.Add(this.txtInput);
            this.groupBox.Controls.Add(this.radioMilesToKm);
            this.groupBox.Controls.Add(this.radioKmToMiles);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(23, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(839, 397);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Conversion Type";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(108, 54);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 38);
            this.lblResult.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(348, 294);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(114, 47);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(478, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(311, 45);
            this.txtInput.TabIndex = 2;
            // 
            // radioMilesToKm
            // 
            this.radioMilesToKm.AutoSize = true;
            this.radioMilesToKm.Location = new System.Drawing.Point(568, 173);
            this.radioMilesToKm.Name = "radioMilesToKm";
            this.radioMilesToKm.Size = new System.Drawing.Size(200, 29);
            this.radioMilesToKm.TabIndex = 1;
            this.radioMilesToKm.TabStop = true;
            this.radioMilesToKm.Text = "Miles -> Kilometers";
            this.radioMilesToKm.UseVisualStyleBackColor = true;
            // 
            // radioKmToMiles
            // 
            this.radioKmToMiles.AutoSize = true;
            this.radioKmToMiles.Location = new System.Drawing.Point(90, 160);
            this.radioKmToMiles.Name = "radioKmToMiles";
            this.radioKmToMiles.Size = new System.Drawing.Size(200, 29);
            this.radioKmToMiles.TabIndex = 0;
            this.radioKmToMiles.TabStop = true;
            this.radioKmToMiles.Text = "Kilometers -> Miles";
            this.radioKmToMiles.UseVisualStyleBackColor = true;
            // 
            // radioChangeColor
            // 
            this.radioChangeColor.AutoSize = true;
            this.radioChangeColor.Location = new System.Drawing.Point(586, 294);
            this.radioChangeColor.Name = "radioChangeColor";
            this.radioChangeColor.Size = new System.Drawing.Size(155, 29);
            this.radioChangeColor.TabIndex = 5;
            this.radioChangeColor.TabStop = true;
            this.radioChangeColor.Text = "Change Color";
            this.radioChangeColor.UseVisualStyleBackColor = true;
            this.radioChangeColor.CheckedChanged += new System.EventHandler(this.radioChangeColor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 490);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton radioMilesToKm;
        private System.Windows.Forms.RadioButton radioKmToMiles;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton radioChangeColor;
    }
}

