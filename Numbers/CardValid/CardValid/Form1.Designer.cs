namespace CardValid
{
    partial class Window
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
            this.check_btn = new System.Windows.Forms.Button();
            this.cardnumber = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(232, 71);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 20);
            this.check_btn.TabIndex = 0;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // cardnumber
            // 
            this.cardnumber.Location = new System.Drawing.Point(47, 71);
            this.cardnumber.Name = "cardnumber";
            this.cardnumber.Size = new System.Drawing.Size(175, 20);
            this.cardnumber.TabIndex = 1;
            this.cardnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(44, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Enter the credit card number that yout want to validate";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 253);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cardnumber);
            this.Controls.Add(this.check_btn);
            this.Name = "Window";
            this.Text = "Credit Card Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox cardnumber;
        private System.Windows.Forms.Label title;
    }
}

