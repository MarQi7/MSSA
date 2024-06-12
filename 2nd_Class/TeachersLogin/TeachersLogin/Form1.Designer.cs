namespace TeachersLogin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Eng_box = new System.Windows.Forms.ComboBox();
            this.Math_box = new System.Windows.Forms.ComboBox();
            this.Sci_box = new System.Windows.Forms.ComboBox();
            this.Tech_box = new System.Windows.Forms.ComboBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Star_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserBox.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserBox.Location = new System.Drawing.Point(398, 211);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(316, 46);
            this.UserBox.TabIndex = 0;
            this.UserBox.Text = "User Name";
            this.UserBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserBox.Enter += new System.EventHandler(this.UserBox_Enter);
            this.UserBox.Leave += new System.EventHandler(this.UserBox_Leave);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassBox.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PassBox.Location = new System.Drawing.Point(398, 289);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(316, 46);
            this.PassBox.TabIndex = 1;
            this.PassBox.Text = "Password";
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginLabel.Location = new System.Drawing.Point(378, 119);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(354, 63);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Teachers Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentGrid
            // 
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StudentGrid.Location = new System.Drawing.Point(133, 161);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.RowTemplate.Height = 24;
            this.StudentGrid.Size = new System.Drawing.Size(864, 184);
            this.StudentGrid.TabIndex = 3;
            // 
            // ID_box
            // 
            this.ID_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ID_box.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ID_box.Location = new System.Drawing.Point(317, 73);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(187, 33);
            this.ID_box.TabIndex = 4;
            this.ID_box.Text = "Student ID";
            this.ID_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_box.Enter += new System.EventHandler(this.ID_box_Enter);
            this.ID_box.Validating += new System.ComponentModel.CancelEventHandler(this.ID_box_Validating);
            // 
            // Name_box
            // 
            this.Name_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name_box.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name_box.Location = new System.Drawing.Point(620, 73);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(187, 33);
            this.Name_box.TabIndex = 13;
            this.Name_box.Text = "Name";
            this.Name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_box.Enter += new System.EventHandler(this.Name_box_Enter);
            // 
            // Eng_box
            // 
            this.Eng_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Eng_box.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eng_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Eng_box.FormattingEnabled = true;
            this.Eng_box.Location = new System.Drawing.Point(568, 119);
            this.Eng_box.Name = "Eng_box";
            this.Eng_box.Size = new System.Drawing.Size(164, 29);
            this.Eng_box.TabIndex = 14;
            this.Eng_box.Text = "English grade";
            // 
            // Math_box
            // 
            this.Math_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Math_box.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Math_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Math_box.FormattingEnabled = true;
            this.Math_box.Location = new System.Drawing.Point(738, 119);
            this.Math_box.Name = "Math_box";
            this.Math_box.Size = new System.Drawing.Size(164, 29);
            this.Math_box.TabIndex = 15;
            this.Math_box.Text = "Math grade";
            // 
            // Sci_box
            // 
            this.Sci_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sci_box.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sci_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Sci_box.FormattingEnabled = true;
            this.Sci_box.Location = new System.Drawing.Point(228, 119);
            this.Sci_box.Name = "Sci_box";
            this.Sci_box.Size = new System.Drawing.Size(164, 29);
            this.Sci_box.TabIndex = 16;
            this.Sci_box.Text = "Science grade";
            // 
            // Tech_box
            // 
            this.Tech_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tech_box.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tech_box.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Tech_box.FormattingEnabled = true;
            this.Tech_box.Location = new System.Drawing.Point(398, 119);
            this.Tech_box.Name = "Tech_box";
            this.Tech_box.Size = new System.Drawing.Size(164, 29);
            this.Tech_box.TabIndex = 17;
            this.Tech_box.Text = "Technology grade";
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Location = new System.Drawing.Point(182, 359);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(187, 33);
            this.Search_button.TabIndex = 18;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.Color.White;
            this.Delete_button.Location = new System.Drawing.Point(568, 359);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(187, 33);
            this.Delete_button.TabIndex = 19;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(761, 359);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(187, 33);
            this.Add_button.TabIndex = 20;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Star_button
            // 
            this.Star_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Star_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star_button.ForeColor = System.Drawing.Color.White;
            this.Star_button.Location = new System.Drawing.Point(376, 359);
            this.Star_button.Name = "Star_button";
            this.Star_button.Size = new System.Drawing.Size(187, 33);
            this.Star_button.TabIndex = 21;
            this.Star_button.Text = "Print Star Student";
            this.Star_button.UseVisualStyleBackColor = false;
            this.Star_button.Click += new System.EventHandler(this.Star_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login_button.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(463, 351);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(187, 33);
            this.Login_button.TabIndex = 22;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 705);
            this.Controls.Add(this.Star_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Tech_box);
            this.Controls.Add(this.Sci_box);
            this.Controls.Add(this.Math_box);
            this.Controls.Add(this.Eng_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.StudentGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.ComboBox Eng_box;
        private System.Windows.Forms.ComboBox Math_box;
        private System.Windows.Forms.ComboBox Sci_box;
        private System.Windows.Forms.ComboBox Tech_box;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Star_button;
        private System.Windows.Forms.Button Login_button;
    }
}

