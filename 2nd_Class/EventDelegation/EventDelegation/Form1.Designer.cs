namespace EventDelegation
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
            this.AcctNum = new System.Windows.Forms.Label();
            this.AcctBal = new System.Windows.Forms.Label();
            this.AcctNumBox = new System.Windows.Forms.TextBox();
            this.AcctBalBox = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcctNum
            // 
            this.AcctNum.AutoSize = true;
            this.AcctNum.Location = new System.Drawing.Point(206, 110);
            this.AcctNum.Name = "AcctNum";
            this.AcctNum.Size = new System.Drawing.Size(115, 13);
            this.AcctNum.TabIndex = 0;
            this.AcctNum.Text = "Bank Account Number";
            // 
            // AcctBal
            // 
            this.AcctBal.AutoSize = true;
            this.AcctBal.Location = new System.Drawing.Point(206, 231);
            this.AcctBal.Name = "AcctBal";
            this.AcctBal.Size = new System.Drawing.Size(117, 13);
            this.AcctBal.TabIndex = 1;
            this.AcctBal.Text = "Bank Account Balance";
            // 
            // AcctNumBox
            // 
            this.AcctNumBox.Location = new System.Drawing.Point(480, 105);
            this.AcctNumBox.Name = "AcctNumBox";
            this.AcctNumBox.Size = new System.Drawing.Size(100, 20);
            this.AcctNumBox.TabIndex = 2;
            // 
            // AcctBalBox
            // 
            this.AcctBalBox.Location = new System.Drawing.Point(480, 226);
            this.AcctBalBox.Name = "AcctBalBox";
            this.AcctBalBox.Size = new System.Drawing.Size(100, 20);
            this.AcctBalBox.TabIndex = 3;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(358, 320);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Check";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.AcctBalBox);
            this.Controls.Add(this.AcctNumBox);
            this.Controls.Add(this.AcctBal);
            this.Controls.Add(this.AcctNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AcctNum;
        private System.Windows.Forms.Label AcctBal;
        private System.Windows.Forms.TextBox AcctNumBox;
        private System.Windows.Forms.TextBox AcctBalBox;
        private System.Windows.Forms.Button Generate;
    }
}

