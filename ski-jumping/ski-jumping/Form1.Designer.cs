namespace ski_jumping
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
            this.KPointNud = new System.Windows.Forms.NumericUpDown();
            this.KPointLbl = new System.Windows.Forms.Label();
            this.JumpLengthNud = new System.Windows.Forms.NumericUpDown();
            this.JumpLengthLbl = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KPointNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpLengthNud)).BeginInit();
            this.SuspendLayout();
            // 
            // KPointNud
            // 
            this.KPointNud.Location = new System.Drawing.Point(86, 5);
            this.KPointNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.KPointNud.Name = "KPointNud";
            this.KPointNud.Size = new System.Drawing.Size(59, 20);
            this.KPointNud.TabIndex = 0;
            // 
            // KPointLbl
            // 
            this.KPointLbl.AutoSize = true;
            this.KPointLbl.Location = new System.Drawing.Point(13, 12);
            this.KPointLbl.Name = "KPointLbl";
            this.KPointLbl.Size = new System.Drawing.Size(40, 13);
            this.KPointLbl.TabIndex = 1;
            this.KPointLbl.Text = "K-point";
            // 
            // JumpLengthNud
            // 
            this.JumpLengthNud.Location = new System.Drawing.Point(86, 31);
            this.JumpLengthNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.JumpLengthNud.Name = "JumpLengthNud";
            this.JumpLengthNud.Size = new System.Drawing.Size(59, 20);
            this.JumpLengthNud.TabIndex = 0;
            // 
            // JumpLengthLbl
            // 
            this.JumpLengthLbl.AutoSize = true;
            this.JumpLengthLbl.Location = new System.Drawing.Point(13, 38);
            this.JumpLengthLbl.Name = "JumpLengthLbl";
            this.JumpLengthLbl.Size = new System.Drawing.Size(64, 13);
            this.JumpLengthLbl.TabIndex = 1;
            this.JumpLengthLbl.Text = "Jump length";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(16, 227);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(129, 23);
            this.CalcBtn.TabIndex = 2;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(16, 69);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(129, 35);
            this.resultTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.JumpLengthLbl);
            this.Controls.Add(this.KPointLbl);
            this.Controls.Add(this.JumpLengthNud);
            this.Controls.Add(this.KPointNud);
            this.Name = "Form1";
            this.Text = "Ski jumping";
            ((System.ComponentModel.ISupportInitialize)(this.KPointNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumpLengthNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown KPointNud;
        private System.Windows.Forms.Label KPointLbl;
        private System.Windows.Forms.NumericUpDown JumpLengthNud;
        private System.Windows.Forms.Label JumpLengthLbl;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

