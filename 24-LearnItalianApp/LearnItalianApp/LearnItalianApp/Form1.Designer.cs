namespace LearnItalianApp
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(385, 335);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(143, 52);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(168, 249);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(628, 32);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Click the button below to learn a new Italian word";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(289, 104);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(0, 54);
            this.lblWords.TabIndex = 2;
            this.lblWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(668, 27);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(229, 32);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "Words learned: 0";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(737, 335);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(160, 52);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Change Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Learn Italian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnColor;
    }
}

