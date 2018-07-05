namespace Dinner_2
{
    partial class DinnerViewer
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
            this.dinnerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dinnerLabel
            // 
            this.dinnerLabel.AutoSize = true;
            this.dinnerLabel.Font = new System.Drawing.Font("MS UI Gothic", 100F);
            this.dinnerLabel.Location = new System.Drawing.Point(55, 157);
            this.dinnerLabel.Name = "dinnerLabel";
            this.dinnerLabel.Size = new System.Drawing.Size(399, 134);
            this.dinnerLabel.TabIndex = 0;
            this.dinnerLabel.Text = "dinner";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.button1.Location = new System.Drawing.Point(317, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickBtn);
            // 
            // DinnerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dinnerLabel);
            this.Name = "DinnerViewer";
            this.Text = "DinnerViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Button button1;
    }
}