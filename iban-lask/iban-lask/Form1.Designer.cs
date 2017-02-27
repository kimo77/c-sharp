namespace iban_lask
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
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.attnLbl = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(13, 13);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(259, 20);
            this.accountTextBox.TabIndex = 0;
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(13, 40);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(38, 13);
            this.ResultLbl.TabIndex = 1;
            this.ResultLbl.Text = "IBAN: ";
            // 
            // attnLbl
            // 
            this.attnLbl.AutoSize = true;
            this.attnLbl.ForeColor = System.Drawing.Color.Red;
            this.attnLbl.Location = new System.Drawing.Point(13, 68);
            this.attnLbl.Name = "attnLbl";
            this.attnLbl.Size = new System.Drawing.Size(0, 13);
            this.attnLbl.TabIndex = 2;
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(13, 97);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.attnLbl);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.accountTextBox);
            this.Name = "Form1";
            this.Text = "Bank account to IBAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Label attnLbl;
        private System.Windows.Forms.Button convertBtn;
    }
}

