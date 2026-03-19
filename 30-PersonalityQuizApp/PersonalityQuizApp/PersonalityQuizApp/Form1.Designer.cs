namespace PersonalityQuizApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.radioCozy = new System.Windows.Forms.RadioButton();
            this.radioForest = new System.Windows.Forms.RadioButton();
            this.radioBeach = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.btnShowResult);
            this.groupBox.Controls.Add(this.radioCity);
            this.groupBox.Controls.Add(this.radioCozy);
            this.groupBox.Controls.Add(this.radioForest);
            this.groupBox.Controls.Add(this.radioBeach);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 300);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Personality Quiz";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(296, 170);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(155, 40);
            this.btnShowResult.TabIndex = 4;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // radioCity
            // 
            this.radioCity.AutoSize = true;
            this.radioCity.Location = new System.Drawing.Point(606, 99);
            this.radioCity.Name = "radioCity";
            this.radioCity.Size = new System.Drawing.Size(118, 26);
            this.radioCity.TabIndex = 3;
            this.radioCity.TabStop = true;
            this.radioCity.Text = "A busy city";
            this.radioCity.UseVisualStyleBackColor = true;
            // 
            // radioCozy
            // 
            this.radioCozy.AutoSize = true;
            this.radioCozy.Location = new System.Drawing.Point(414, 99);
            this.radioCozy.Name = "radioCozy";
            this.radioCozy.Size = new System.Drawing.Size(129, 26);
            this.radioCozy.TabIndex = 2;
            this.radioCozy.TabStop = true;
            this.radioCozy.Text = "A cozy room";
            this.radioCozy.UseVisualStyleBackColor = true;
            // 
            // radioForest
            // 
            this.radioForest.AutoSize = true;
            this.radioForest.Location = new System.Drawing.Point(222, 99);
            this.radioForest.Name = "radioForest";
            this.radioForest.Size = new System.Drawing.Size(137, 26);
            this.radioForest.TabIndex = 1;
            this.radioForest.TabStop = true;
            this.radioForest.Text = "A quiet forest";
            this.radioForest.UseVisualStyleBackColor = true;
            // 
            // radioBeach
            // 
            this.radioBeach.AutoSize = true;
            this.radioBeach.Location = new System.Drawing.Point(34, 99);
            this.radioBeach.Name = "radioBeach";
            this.radioBeach.Size = new System.Drawing.Size(150, 26);
            this.radioBeach.TabIndex = 0;
            this.radioBeach.TabStop = true;
            this.radioBeach.Text = "A sunny beach";
            this.radioBeach.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioCity;
        private System.Windows.Forms.RadioButton radioCozy;
        private System.Windows.Forms.RadioButton radioForest;
        private System.Windows.Forms.RadioButton radioBeach;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button button1;
    }
}

