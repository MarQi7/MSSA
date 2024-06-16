namespace StudentRegistrar
{
    partial class StudentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecords));
            this.Student_Grid = new System.Windows.Forms.DataGridView();
            this.student_record_label = new System.Windows.Forms.Label();
            this.Student_Record = new System.Windows.Forms.GroupBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.Combo_Grade = new System.Windows.Forms.ComboBox();
            this.Combo_MoA = new System.Windows.Forms.ComboBox();
            this.Text_Address = new System.Windows.Forms.TextBox();
            this.Text_Lname = new System.Windows.Forms.TextBox();
            this.Text_Fname = new System.Windows.Forms.TextBox();
            this.Text_ID = new System.Windows.Forms.TextBox();
            this.s_Grade = new System.Windows.Forms.Label();
            this.s_MoA = new System.Windows.Forms.Label();
            this.s_Address = new System.Windows.Forms.Label();
            this.s_LName = new System.Windows.Forms.Label();
            this.s_FName = new System.Windows.Forms.Label();
            this.s_ID = new System.Windows.Forms.Label();
            this.Add_Record = new System.Windows.Forms.Button();
            this.Delete_Record = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Grid)).BeginInit();
            this.Student_Record.SuspendLayout();
            this.SuspendLayout();
            // 
            // Student_Grid
            // 
            this.Student_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Student_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Grid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.Student_Grid.Location = new System.Drawing.Point(54, 98);
            this.Student_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Student_Grid.Name = "Student_Grid";
            this.Student_Grid.Size = new System.Drawing.Size(776, 240);
            this.Student_Grid.TabIndex = 0;
            // 
            // student_record_label
            // 
            this.student_record_label.AutoSize = true;
            this.student_record_label.BackColor = System.Drawing.Color.Transparent;
            this.student_record_label.Font = new System.Drawing.Font("Sylfaen", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_record_label.ForeColor = System.Drawing.Color.Transparent;
            this.student_record_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.student_record_label.Location = new System.Drawing.Point(259, 21);
            this.student_record_label.Name = "student_record_label";
            this.student_record_label.Size = new System.Drawing.Size(366, 62);
            this.student_record_label.TabIndex = 6;
            this.student_record_label.Text = "Student Records";
            // 
            // Student_Record
            // 
            this.Student_Record.Controls.Add(this.submit_button);
            this.Student_Record.Controls.Add(this.Combo_Grade);
            this.Student_Record.Controls.Add(this.Combo_MoA);
            this.Student_Record.Controls.Add(this.Text_Address);
            this.Student_Record.Controls.Add(this.Text_Lname);
            this.Student_Record.Controls.Add(this.Text_Fname);
            this.Student_Record.Controls.Add(this.Text_ID);
            this.Student_Record.Controls.Add(this.s_Grade);
            this.Student_Record.Controls.Add(this.s_MoA);
            this.Student_Record.Controls.Add(this.s_Address);
            this.Student_Record.Controls.Add(this.s_LName);
            this.Student_Record.Controls.Add(this.s_FName);
            this.Student_Record.Controls.Add(this.s_ID);
            this.Student_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Record.Location = new System.Drawing.Point(54, 456);
            this.Student_Record.Name = "Student_Record";
            this.Student_Record.Size = new System.Drawing.Size(776, 261);
            this.Student_Record.TabIndex = 7;
            this.Student_Record.TabStop = false;
            this.Student_Record.Text = "Student Record";
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(347, 209);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(86, 33);
            this.submit_button.TabIndex = 12;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // Combo_Grade
            // 
            this.Combo_Grade.FormattingEnabled = true;
            this.Combo_Grade.Location = new System.Drawing.Point(503, 157);
            this.Combo_Grade.Name = "Combo_Grade";
            this.Combo_Grade.Size = new System.Drawing.Size(242, 26);
            this.Combo_Grade.TabIndex = 11;
            // 
            // Combo_MoA
            // 
            this.Combo_MoA.FormattingEnabled = true;
            this.Combo_MoA.Location = new System.Drawing.Point(503, 103);
            this.Combo_MoA.Name = "Combo_MoA";
            this.Combo_MoA.Size = new System.Drawing.Size(242, 26);
            this.Combo_MoA.TabIndex = 10;
            // 
            // Text_Address
            // 
            this.Text_Address.Location = new System.Drawing.Point(503, 45);
            this.Text_Address.Name = "Text_Address";
            this.Text_Address.Size = new System.Drawing.Size(242, 24);
            this.Text_Address.TabIndex = 9;
            // 
            // Text_Lname
            // 
            this.Text_Lname.Location = new System.Drawing.Point(164, 159);
            this.Text_Lname.Name = "Text_Lname";
            this.Text_Lname.Size = new System.Drawing.Size(156, 24);
            this.Text_Lname.TabIndex = 8;
            // 
            // Text_Fname
            // 
            this.Text_Fname.Location = new System.Drawing.Point(164, 105);
            this.Text_Fname.Name = "Text_Fname";
            this.Text_Fname.Size = new System.Drawing.Size(156, 24);
            this.Text_Fname.TabIndex = 7;
            // 
            // Text_ID
            // 
            this.Text_ID.Location = new System.Drawing.Point(164, 45);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(156, 24);
            this.Text_ID.TabIndex = 6;
            this.Text_ID.Validating += new System.ComponentModel.CancelEventHandler(this.Text_ID_Validating);
            // 
            // s_Grade
            // 
            this.s_Grade.AutoSize = true;
            this.s_Grade.Location = new System.Drawing.Point(344, 165);
            this.s_Grade.Name = "s_Grade";
            this.s_Grade.Size = new System.Drawing.Size(54, 18);
            this.s_Grade.TabIndex = 5;
            this.s_Grade.Text = "Grade";
            // 
            // s_MoA
            // 
            this.s_MoA.AutoSize = true;
            this.s_MoA.Location = new System.Drawing.Point(344, 108);
            this.s_MoA.Name = "s_MoA";
            this.s_MoA.Size = new System.Drawing.Size(158, 18);
            this.s_MoA.TabIndex = 4;
            this.s_MoA.Text = "Month of Admission";
            // 
            // s_Address
            // 
            this.s_Address.AutoSize = true;
            this.s_Address.Location = new System.Drawing.Point(344, 48);
            this.s_Address.Name = "s_Address";
            this.s_Address.Size = new System.Drawing.Size(69, 18);
            this.s_Address.TabIndex = 3;
            this.s_Address.Text = "Address";
            // 
            // s_LName
            // 
            this.s_LName.AutoSize = true;
            this.s_LName.Location = new System.Drawing.Point(50, 165);
            this.s_LName.Name = "s_LName";
            this.s_LName.Size = new System.Drawing.Size(89, 18);
            this.s_LName.TabIndex = 2;
            this.s_LName.Text = "Last Name";
            // 
            // s_FName
            // 
            this.s_FName.AutoSize = true;
            this.s_FName.Location = new System.Drawing.Point(50, 108);
            this.s_FName.Name = "s_FName";
            this.s_FName.Size = new System.Drawing.Size(91, 18);
            this.s_FName.TabIndex = 1;
            this.s_FName.Text = "First Name";
            // 
            // s_ID
            // 
            this.s_ID.AutoSize = true;
            this.s_ID.Location = new System.Drawing.Point(50, 48);
            this.s_ID.Name = "s_ID";
            this.s_ID.Size = new System.Drawing.Size(86, 18);
            this.s_ID.TabIndex = 0;
            this.s_ID.Text = "Student ID";
            // 
            // Add_Record
            // 
            this.Add_Record.BackColor = System.Drawing.Color.PapayaWhip;
            this.Add_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Record.FlatAppearance.BorderSize = 10;
            this.Add_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Record.Location = new System.Drawing.Point(148, 370);
            this.Add_Record.Name = "Add_Record";
            this.Add_Record.Size = new System.Drawing.Size(169, 55);
            this.Add_Record.TabIndex = 8;
            this.Add_Record.Text = "Add Record";
            this.Add_Record.UseVisualStyleBackColor = false;
            this.Add_Record.Click += new System.EventHandler(this.Add_Record_Click);
            // 
            // Delete_Record
            // 
            this.Delete_Record.BackColor = System.Drawing.Color.PapayaWhip;
            this.Delete_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete_Record.FlatAppearance.BorderSize = 10;
            this.Delete_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Record.Location = new System.Drawing.Point(577, 370);
            this.Delete_Record.Name = "Delete_Record";
            this.Delete_Record.Size = new System.Drawing.Size(169, 55);
            this.Delete_Record.TabIndex = 9;
            this.Delete_Record.Text = "Delete Record";
            this.Delete_Record.UseVisualStyleBackColor = false;
            this.Delete_Record.Click += new System.EventHandler(this.Delete_Record_Click);
            // 
            // StudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 747);
            this.Controls.Add(this.Delete_Record);
            this.Controls.Add(this.Add_Record);
            this.Controls.Add(this.Student_Record);
            this.Controls.Add(this.student_record_label);
            this.Controls.Add(this.Student_Grid);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentRecords";
            this.Text = "StudentRecords";
            this.Load += new System.EventHandler(this.StudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Grid)).EndInit();
            this.Student_Record.ResumeLayout(false);
            this.Student_Record.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Student_Grid;
        private System.Windows.Forms.Label student_record_label;
        private System.Windows.Forms.GroupBox Student_Record;
        private System.Windows.Forms.Button Add_Record;
        private System.Windows.Forms.Label s_FName;
        private System.Windows.Forms.Label s_ID;
        private System.Windows.Forms.Button Delete_Record;
        private System.Windows.Forms.ComboBox Combo_MoA;
        private System.Windows.Forms.TextBox Text_Address;
        private System.Windows.Forms.TextBox Text_Lname;
        private System.Windows.Forms.TextBox Text_Fname;
        private System.Windows.Forms.TextBox Text_ID;
        private System.Windows.Forms.Label s_Grade;
        private System.Windows.Forms.Label s_MoA;
        private System.Windows.Forms.Label s_Address;
        private System.Windows.Forms.Label s_LName;
        private System.Windows.Forms.ComboBox Combo_Grade;
        private System.Windows.Forms.Button submit_button;
    }
}