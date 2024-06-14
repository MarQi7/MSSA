namespace _3._4
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.Title = new System.Windows.Forms.Label();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.OrderGridButton = new System.Windows.Forms.Button();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Coffee_Choice = new System.Windows.Forms.GroupBox();
            this.Option_1 = new System.Windows.Forms.Button();
            this.Option_2 = new System.Windows.Forms.Button();
            this.Option_4 = new System.Windows.Forms.Button();
            this.Option_3 = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Skip_Submit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.Coffee_Choice.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Forte", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "Beanie Man";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderGrid
            // 
            this.OrderGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderGrid.GridColor = System.Drawing.SystemColors.Control;
            this.OrderGrid.Location = new System.Drawing.Point(647, 68);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGrid.Size = new System.Drawing.Size(141, 299);
            this.OrderGrid.TabIndex = 1;
            // 
            // OrderGridButton
            // 
            this.OrderGridButton.Location = new System.Drawing.Point(647, 374);
            this.OrderGridButton.Name = "OrderGridButton";
            this.OrderGridButton.Size = new System.Drawing.Size(141, 64);
            this.OrderGridButton.TabIndex = 2;
            this.OrderGridButton.Text = "View Order Details";
            this.OrderGridButton.UseVisualStyleBackColor = true;
            this.OrderGridButton.Click += new System.EventHandler(this.OrderGridButton_Click);
            // 
            // Name_Box
            // 
            this.Name_Box.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Box.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Box.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name_Box.Location = new System.Drawing.Point(38, 111);
            this.Name_Box.MaxLength = 32;
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(528, 82);
            this.Name_Box.TabIndex = 7;
            this.Name_Box.Text = "Enter name here";
            this.Name_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Box.Enter += new System.EventHandler(this.Name_Box_Enter);
            this.Name_Box.Leave += new System.EventHandler(this.Name_Box_Leave);
            // 
            // Coffee_Choice
            // 
            this.Coffee_Choice.BackColor = System.Drawing.Color.Transparent;
            this.Coffee_Choice.Controls.Add(this.Skip_Submit_Button);
            this.Coffee_Choice.Controls.Add(this.Back_Button);
            this.Coffee_Choice.Controls.Add(this.Option_3);
            this.Coffee_Choice.Controls.Add(this.Option_4);
            this.Coffee_Choice.Controls.Add(this.Option_2);
            this.Coffee_Choice.Controls.Add(this.Option_1);
            this.Coffee_Choice.Controls.Add(this.Name_Box);
            this.Coffee_Choice.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffee_Choice.ForeColor = System.Drawing.Color.White;
            this.Coffee_Choice.Location = new System.Drawing.Point(20, 68);
            this.Coffee_Choice.Name = "Coffee_Choice";
            this.Coffee_Choice.Size = new System.Drawing.Size(605, 375);
            this.Coffee_Choice.TabIndex = 8;
            this.Coffee_Choice.TabStop = false;
            this.Coffee_Choice.Text = "Menu";
            // 
            // Option_1
            // 
            this.Option_1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Option_1.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Option_1.FlatAppearance.BorderSize = 5;
            this.Option_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_1.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_1.ForeColor = System.Drawing.Color.Black;
            this.Option_1.Location = new System.Drawing.Point(38, 40);
            this.Option_1.Name = "Option_1";
            this.Option_1.Size = new System.Drawing.Size(252, 75);
            this.Option_1.TabIndex = 0;
            this.Option_1.Text = "Arabica";
            this.Option_1.UseVisualStyleBackColor = false;
            this.Option_1.Click += new System.EventHandler(this.Cold_Brew_Button_Click);
            // 
            // Option_2
            // 
            this.Option_2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Option_2.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Option_2.FlatAppearance.BorderSize = 5;
            this.Option_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_2.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_2.ForeColor = System.Drawing.Color.Black;
            this.Option_2.Location = new System.Drawing.Point(314, 40);
            this.Option_2.Name = "Option_2";
            this.Option_2.Size = new System.Drawing.Size(252, 75);
            this.Option_2.TabIndex = 1;
            this.Option_2.Text = "Robusta";
            this.Option_2.UseVisualStyleBackColor = false;
            this.Option_2.Click += new System.EventHandler(this.Latte_Button_Click);
            // 
            // Option_4
            // 
            this.Option_4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Option_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Option_4.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Option_4.FlatAppearance.BorderSize = 5;
            this.Option_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_4.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_4.ForeColor = System.Drawing.Color.Black;
            this.Option_4.Location = new System.Drawing.Point(314, 155);
            this.Option_4.Margin = new System.Windows.Forms.Padding(1);
            this.Option_4.Name = "Option_4";
            this.Option_4.Size = new System.Drawing.Size(252, 75);
            this.Option_4.TabIndex = 3;
            this.Option_4.Text = "Excelsa";
            this.Option_4.UseVisualStyleBackColor = false;
            this.Option_4.Click += new System.EventHandler(this.Americano_Button_Click);
            // 
            // Option_3
            // 
            this.Option_3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Option_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Option_3.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Option_3.FlatAppearance.BorderSize = 5;
            this.Option_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_3.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_3.ForeColor = System.Drawing.Color.Black;
            this.Option_3.Location = new System.Drawing.Point(38, 155);
            this.Option_3.Margin = new System.Windows.Forms.Padding(1);
            this.Option_3.Name = "Option_3";
            this.Option_3.Size = new System.Drawing.Size(252, 75);
            this.Option_3.TabIndex = 5;
            this.Option_3.Text = "Liberica";
            this.Option_3.UseVisualStyleBackColor = false;
            this.Option_3.Click += new System.EventHandler(this.Frappe_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Back_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Back_Button.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Back_Button.FlatAppearance.BorderSize = 5;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.ForeColor = System.Drawing.Color.Black;
            this.Back_Button.Location = new System.Drawing.Point(38, 270);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(252, 75);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "Go Back";
            this.Back_Button.UseVisualStyleBackColor = false;
            // 
            // Skip_Submit_Button
            // 
            this.Skip_Submit_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Skip_Submit_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Skip_Submit_Button.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Skip_Submit_Button.FlatAppearance.BorderSize = 5;
            this.Skip_Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip_Submit_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip_Submit_Button.ForeColor = System.Drawing.Color.Black;
            this.Skip_Submit_Button.Location = new System.Drawing.Point(314, 270);
            this.Skip_Submit_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Skip_Submit_Button.Name = "Skip_Submit_Button";
            this.Skip_Submit_Button.Size = new System.Drawing.Size(252, 75);
            this.Skip_Submit_Button.TabIndex = 7;
            this.Skip_Submit_Button.Text = "None";
            this.Skip_Submit_Button.UseVisualStyleBackColor = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderGridButton);
            this.Controls.Add(this.Coffee_Choice);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.Title);
            this.Name = "Orders";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.Coffee_Choice.ResumeLayout(false);
            this.Coffee_Choice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Button OrderGridButton;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.GroupBox Coffee_Choice;
        private System.Windows.Forms.Button Skip_Submit_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Option_3;
        private System.Windows.Forms.Button Option_4;
        private System.Windows.Forms.Button Option_2;
        private System.Windows.Forms.Button Option_1;
    }
}

