namespace StudentRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login_Button = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(396, 516);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(100, 34);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_Button_MouseClick);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(326, 469);
            this.password_box.MaxLength = 32;
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(239, 27);
            this.password_box.TabIndex = 1;
            this.password_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Transparent;
            this.pass_label.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pass_label.Location = new System.Drawing.Point(410, 446);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(78, 19);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Password";
            
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.BackColor = System.Drawing.Color.Transparent;
            this.user_label.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.user_label.Location = new System.Drawing.Point(410, 377);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(78, 19);
            this.user_label.TabIndex = 4;
            this.user_label.Text = "Username";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(326, 400);
            this.username_box.MaxLength = 20;
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(239, 27);
            this.username_box.TabIndex = 3;
            this.username_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(255, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Registrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.Login_Button);
            this.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
    }
}

