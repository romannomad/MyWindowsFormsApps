namespace CheckboxListSelector
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
            this.chkApple = new System.Windows.Forms.CheckBox();
            this.chkBanana = new System.Windows.Forms.CheckBox();
            this.chkOrange = new System.Windows.Forms.CheckBox();
            this.chkApricot = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkApple
            // 
            this.chkApple.AutoSize = true;
            this.chkApple.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApple.Location = new System.Drawing.Point(89, 56);
            this.chkApple.Name = "chkApple";
            this.chkApple.Size = new System.Drawing.Size(98, 33);
            this.chkApple.TabIndex = 0;
            this.chkApple.Text = "Apple";
            this.chkApple.UseVisualStyleBackColor = true;
            // 
            // chkBanana
            // 
            this.chkBanana.AutoSize = true;
            this.chkBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBanana.Location = new System.Drawing.Point(89, 104);
            this.chkBanana.Name = "chkBanana";
            this.chkBanana.Size = new System.Drawing.Size(116, 33);
            this.chkBanana.TabIndex = 1;
            this.chkBanana.Text = "Banana";
            this.chkBanana.UseVisualStyleBackColor = true;
            // 
            // chkOrange
            // 
            this.chkOrange.AutoSize = true;
            this.chkOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOrange.Location = new System.Drawing.Point(89, 158);
            this.chkOrange.Name = "chkOrange";
            this.chkOrange.Size = new System.Drawing.Size(116, 33);
            this.chkOrange.TabIndex = 2;
            this.chkOrange.Text = "Orange";
            this.chkOrange.UseVisualStyleBackColor = true;
            // 
            // chkApricot
            // 
            this.chkApricot.AutoSize = true;
            this.chkApricot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApricot.Location = new System.Drawing.Point(89, 210);
            this.chkApricot.Name = "chkApricot";
            this.chkApricot.Size = new System.Drawing.Size(110, 33);
            this.chkApricot.TabIndex = 3;
            this.chkApricot.Text = "Apricot";
            this.chkApricot.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(412, 56);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(247, 82);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Selected";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(412, 226);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(247, 87);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkApricot);
            this.Controls.Add(this.chkOrange);
            this.Controls.Add(this.chkBanana);
            this.Controls.Add(this.chkApple);
            this.Name = "Form1";
            this.Text = "Checkbox List Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkApple;
        private System.Windows.Forms.CheckBox chkBanana;
        private System.Windows.Forms.CheckBox chkOrange;
        private System.Windows.Forms.CheckBox chkApricot;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblResult;
    }
}

