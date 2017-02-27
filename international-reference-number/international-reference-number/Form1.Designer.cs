namespace international_reference_number
{
    partial class mainForm
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
            this.insertTextBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finRbtn = new System.Windows.Forms.RadioButton();
            this.newRbtn = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertTextBox
            // 
            this.insertTextBox.Location = new System.Drawing.Point(12, 95);
            this.insertTextBox.Name = "insertTextBox";
            this.insertTextBox.Size = new System.Drawing.Size(337, 20);
            this.insertTextBox.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 127);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(92, 28);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(110, 127);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(92, 28);
            this.checkBtn.TabIndex = 1;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finRbtn);
            this.groupBox1.Controls.Add(this.newRbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // finRbtn
            // 
            this.finRbtn.AutoSize = true;
            this.finRbtn.Location = new System.Drawing.Point(7, 44);
            this.finRbtn.Name = "finRbtn";
            this.finRbtn.Size = new System.Drawing.Size(163, 17);
            this.finRbtn.TabIndex = 1;
            this.finRbtn.Text = "Use finnish reference number";
            this.finRbtn.UseVisualStyleBackColor = true;
            // 
            // newRbtn
            // 
            this.newRbtn.AutoSize = true;
            this.newRbtn.Checked = true;
            this.newRbtn.Location = new System.Drawing.Point(7, 20);
            this.newRbtn.Name = "newRbtn";
            this.newRbtn.Size = new System.Drawing.Size(133, 17);
            this.newRbtn.TabIndex = 0;
            this.newRbtn.TabStop = true;
            this.newRbtn.Text = "New reference number";
            this.newRbtn.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Location = new System.Drawing.Point(12, 166);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(337, 13);
            this.resultTextBox.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 199);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.insertTextBox);
            this.Name = "mainForm";
            this.Text = "International reference number";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertTextBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton finRbtn;
        private System.Windows.Forms.RadioButton newRbtn;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

