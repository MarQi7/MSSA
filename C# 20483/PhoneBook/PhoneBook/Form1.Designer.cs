namespace PhoneBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Open_Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Main_Pic = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Entries_Pic1 = new System.Windows.Forms.PictureBox();
            this.Entries_Pic2 = new System.Windows.Forms.PictureBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.AddressGrid = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.WorkNumBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.CellNumBox = new System.Windows.Forms.TextBox();
            this.Edit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entries_Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entries_Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_Button
            // 
            this.Open_Button.BackColor = System.Drawing.Color.Transparent;
            this.Open_Button.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.Open_Button.FlatAppearance.BorderSize = 5;
            this.Open_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_Button.Font = new System.Drawing.Font("Juice ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_Button.ForeColor = System.Drawing.Color.Gold;
            this.Open_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Open_Button.Location = new System.Drawing.Point(240, 396);
            this.Open_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(118, 49);
            this.Open_Button.TabIndex = 0;
            this.Open_Button.Text = "Open";
            this.Open_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Open_Button.UseVisualStyleBackColor = false;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // Main_Pic
            // 
            this.Main_Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Main_Pic.BackgroundImage")));
            this.Main_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Pic.InitialImage = ((System.Drawing.Image)(resources.GetObject("Main_Pic.InitialImage")));
            this.Main_Pic.Location = new System.Drawing.Point(-5, -1);
            this.Main_Pic.Name = "Main_Pic";
            this.Main_Pic.Size = new System.Drawing.Size(601, 828);
            this.Main_Pic.TabIndex = 1;
            this.Main_Pic.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Entries_Pic1
            // 
            this.Entries_Pic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Entries_Pic1.BackgroundImage")));
            this.Entries_Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Entries_Pic1.Location = new System.Drawing.Point(-1, -5);
            this.Entries_Pic1.Name = "Entries_Pic1";
            this.Entries_Pic1.Size = new System.Drawing.Size(608, 835);
            this.Entries_Pic1.TabIndex = 2;
            this.Entries_Pic1.TabStop = false;
            // 
            // Entries_Pic2
            // 
            this.Entries_Pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Entries_Pic2.BackgroundImage")));
            this.Entries_Pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Entries_Pic2.Location = new System.Drawing.Point(-6, -3);
            this.Entries_Pic2.Name = "Entries_Pic2";
            this.Entries_Pic2.Size = new System.Drawing.Size(602, 835);
            this.Entries_Pic2.TabIndex = 3;
            this.Entries_Pic2.TabStop = false;
            // 
            // Search_Button
            // 
            this.Search_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.Gold;
            this.Search_Button.Location = new System.Drawing.Point(376, 26);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(172, 37);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // AddressGrid
            // 
            this.AddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGrid.Location = new System.Drawing.Point(12, 396);
            this.AddressGrid.Name = "AddressGrid";
            this.AddressGrid.RowTemplate.Height = 24;
            this.AddressGrid.Size = new System.Drawing.Size(566, 414);
            this.AddressGrid.TabIndex = 6;
            // 
            // Add_Button
            // 
            this.Add_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.Gold;
            this.Add_Button.Location = new System.Drawing.Point(376, 353);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(172, 37);
            this.Add_Button.TabIndex = 7;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.Gold;
            this.Delete_Button.Location = new System.Drawing.Point(40, 353);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(172, 37);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressBox.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.ForeColor = System.Drawing.Color.Olive;
            this.AddressBox.Location = new System.Drawing.Point(40, 162);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(508, 32);
            this.AddressBox.TabIndex = 9;
            this.AddressBox.Text = "Address";
            this.AddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddressBox.Enter += new System.EventHandler(this.AddressBox_Enter);
            this.AddressBox.Leave += new System.EventHandler(this.AddressBox_Leave);
            // 
            // FNameBox
            // 
            this.FNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FNameBox.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameBox.ForeColor = System.Drawing.Color.Olive;
            this.FNameBox.Location = new System.Drawing.Point(40, 102);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(253, 32);
            this.FNameBox.TabIndex = 10;
            this.FNameBox.Text = "First Name";
            this.FNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FNameBox.Enter += new System.EventHandler(this.FNameBox_Enter);
            this.FNameBox.Leave += new System.EventHandler(this.FNameBox_Leave);
            // 
            // WorkNumBox
            // 
            this.WorkNumBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WorkNumBox.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkNumBox.ForeColor = System.Drawing.Color.Olive;
            this.WorkNumBox.Location = new System.Drawing.Point(40, 287);
            this.WorkNumBox.Name = "WorkNumBox";
            this.WorkNumBox.Size = new System.Drawing.Size(508, 32);
            this.WorkNumBox.TabIndex = 12;
            this.WorkNumBox.Text = "Work Phone (optional)";
            this.WorkNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkNumBox.Enter += new System.EventHandler(this.WorkNumBox_Enter);
            this.WorkNumBox.Leave += new System.EventHandler(this.WorkNumBox_Leave);
            this.WorkNumBox.Validating += new System.ComponentModel.CancelEventHandler(this.WorkNumBox_Validating);
            // 
            // LNameBox
            // 
            this.LNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LNameBox.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameBox.ForeColor = System.Drawing.Color.Olive;
            this.LNameBox.Location = new System.Drawing.Point(295, 102);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(253, 32);
            this.LNameBox.TabIndex = 13;
            this.LNameBox.Text = "Last Name";
            this.LNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LNameBox.Enter += new System.EventHandler(this.LNameBox_Enter);
            this.LNameBox.Leave += new System.EventHandler(this.LNameBox_Leave);
            // 
            // CellNumBox
            // 
            this.CellNumBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CellNumBox.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellNumBox.ForeColor = System.Drawing.Color.Olive;
            this.CellNumBox.Location = new System.Drawing.Point(40, 226);
            this.CellNumBox.Name = "CellNumBox";
            this.CellNumBox.Size = new System.Drawing.Size(508, 32);
            this.CellNumBox.TabIndex = 11;
            this.CellNumBox.Text = "Cell Phone";
            this.CellNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CellNumBox.Enter += new System.EventHandler(this.CellNumBox_Enter);
            this.CellNumBox.Leave += new System.EventHandler(this.CellNumBox_Leave);
            this.CellNumBox.Validating += new System.ComponentModel.CancelEventHandler(this.CellNumBox_Validating);
            // 
            // Edit_Button
            // 
            this.Edit_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.Font = new System.Drawing.Font("Harrington", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Button.ForeColor = System.Drawing.Color.Gold;
            this.Edit_Button.Location = new System.Drawing.Point(40, 26);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(172, 37);
            this.Edit_Button.TabIndex = 4;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 822);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.WorkNumBox);
            this.Controls.Add(this.CellNumBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.AddressGrid);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.Entries_Pic1);
            this.Controls.Add(this.Main_Pic);
            this.Controls.Add(this.Entries_Pic2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entries_Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entries_Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Main_Pic;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Entries_Pic1;
        private System.Windows.Forms.PictureBox Entries_Pic2;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridView AddressGrid;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox WorkNumBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.TextBox CellNumBox;
        private System.Windows.Forms.Button Edit_Button;
    }
}

