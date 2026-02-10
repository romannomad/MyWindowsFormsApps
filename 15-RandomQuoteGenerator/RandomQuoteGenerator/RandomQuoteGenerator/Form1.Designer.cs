namespace RandomQuoteGenerator
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
            this.btnQuote = new System.Windows.Forms.Button();
            this.lblQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuote
            // 
            this.btnQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.Location = new System.Drawing.Point(78, 170);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(192, 98);
            this.btnQuote.TabIndex = 0;
            this.btnQuote.Text = "Show Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // lblQuote
            // 
            this.lblQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(289, 9);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(499, 432);
            this.lblQuote.TabIndex = 1;
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.btnQuote);
            this.Name = "Form1";
            this.Text = "Random Quote Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Label lblQuote;
    }
}

