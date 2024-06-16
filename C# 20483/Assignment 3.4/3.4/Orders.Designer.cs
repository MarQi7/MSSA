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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.Title = new System.Windows.Forms.Label();
            this.OrderGridButton = new System.Windows.Forms.Button();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Coffee_Choice = new System.Windows.Forms.GroupBox();
            this.DeleteOrder_Button = new System.Windows.Forms.Button();
            this.Exit_OrderView_Button = new System.Windows.Forms.Button();
            this.ClearSearch_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.None_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Option_3 = new System.Windows.Forms.Button();
            this.Option_4 = new System.Windows.Forms.Button();
            this.Option_2 = new System.Windows.Forms.Button();
            this.Option_1 = new System.Windows.Forms.Button();
            this.Orders_Grid = new System.Windows.Forms.DataGridView();
            this.OrderWindow = new System.Windows.Forms.RichTextBox();
            this.Coffee_Choice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Forte", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(16, 11);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "Beanie Man";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderGridButton
            // 
            this.OrderGridButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.OrderGridButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrderGridButton.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.OrderGridButton.FlatAppearance.BorderSize = 5;
            this.OrderGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderGridButton.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGridButton.Location = new System.Drawing.Point(863, 460);
            this.OrderGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrderGridButton.Name = "OrderGridButton";
            this.OrderGridButton.Size = new System.Drawing.Size(188, 79);
            this.OrderGridButton.TabIndex = 2;
            this.OrderGridButton.Text = "View Order Details";
            this.OrderGridButton.UseVisualStyleBackColor = false;
            this.OrderGridButton.Click += new System.EventHandler(this.OrderGridButton_Click);
            // 
            // Name_Box
            // 
            this.Name_Box.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Name_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Box.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Box.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name_Box.Location = new System.Drawing.Point(51, 137);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Box.MaxLength = 32;
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(703, 82);
            this.Name_Box.TabIndex = 7;
            this.Name_Box.Text = "Enter name here";
            this.Name_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Box.Enter += new System.EventHandler(this.Name_Box_Enter);
            this.Name_Box.Leave += new System.EventHandler(this.Name_Box_Leave);
            // 
            // Coffee_Choice
            // 
            this.Coffee_Choice.BackColor = System.Drawing.Color.Transparent;
            this.Coffee_Choice.Controls.Add(this.DeleteOrder_Button);
            this.Coffee_Choice.Controls.Add(this.Exit_OrderView_Button);
            this.Coffee_Choice.Controls.Add(this.ClearSearch_Button);
            this.Coffee_Choice.Controls.Add(this.Search_Button);
            this.Coffee_Choice.Controls.Add(this.Search_Box);
            this.Coffee_Choice.Controls.Add(this.Submit_Button);
            this.Coffee_Choice.Controls.Add(this.None_Button);
            this.Coffee_Choice.Controls.Add(this.Back_Button);
            this.Coffee_Choice.Controls.Add(this.Option_3);
            this.Coffee_Choice.Controls.Add(this.Option_4);
            this.Coffee_Choice.Controls.Add(this.Option_2);
            this.Coffee_Choice.Controls.Add(this.Option_1);
            this.Coffee_Choice.Controls.Add(this.Name_Box);
            this.Coffee_Choice.Controls.Add(this.Orders_Grid);
            this.Coffee_Choice.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffee_Choice.ForeColor = System.Drawing.Color.White;
            this.Coffee_Choice.Location = new System.Drawing.Point(27, 84);
            this.Coffee_Choice.Margin = new System.Windows.Forms.Padding(4);
            this.Coffee_Choice.Name = "Coffee_Choice";
            this.Coffee_Choice.Padding = new System.Windows.Forms.Padding(4);
            this.Coffee_Choice.Size = new System.Drawing.Size(807, 462);
            this.Coffee_Choice.TabIndex = 8;
            this.Coffee_Choice.TabStop = false;
            this.Coffee_Choice.Text = "Roast Selection";
            // 
            // DeleteOrder_Button
            // 
            this.DeleteOrder_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.DeleteOrder_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteOrder_Button.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.DeleteOrder_Button.FlatAppearance.BorderSize = 5;
            this.DeleteOrder_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrder_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrder_Button.ForeColor = System.Drawing.Color.Black;
            this.DeleteOrder_Button.Location = new System.Drawing.Point(419, 332);
            this.DeleteOrder_Button.Margin = new System.Windows.Forms.Padding(1);
            this.DeleteOrder_Button.Name = "DeleteOrder_Button";
            this.DeleteOrder_Button.Size = new System.Drawing.Size(336, 92);
            this.DeleteOrder_Button.TabIndex = 14;
            this.DeleteOrder_Button.Text = "Delete Order";
            this.DeleteOrder_Button.UseVisualStyleBackColor = false;
            this.DeleteOrder_Button.Click += new System.EventHandler(this.DeleteOrder_Button_Click);
            // 
            // Exit_OrderView_Button
            // 
            this.Exit_OrderView_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Exit_OrderView_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exit_OrderView_Button.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Exit_OrderView_Button.FlatAppearance.BorderSize = 5;
            this.Exit_OrderView_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_OrderView_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_OrderView_Button.ForeColor = System.Drawing.Color.Black;
            this.Exit_OrderView_Button.Location = new System.Drawing.Point(51, 332);
            this.Exit_OrderView_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Exit_OrderView_Button.Name = "Exit_OrderView_Button";
            this.Exit_OrderView_Button.Size = new System.Drawing.Size(336, 92);
            this.Exit_OrderView_Button.TabIndex = 13;
            this.Exit_OrderView_Button.Text = "Exit";
            this.Exit_OrderView_Button.UseVisualStyleBackColor = false;
            this.Exit_OrderView_Button.Click += new System.EventHandler(this.Exit_OrderView_Button_Click);
            // 
            // ClearSearch_Button
            // 
            this.ClearSearch_Button.BackColor = System.Drawing.Color.Wheat;
            this.ClearSearch_Button.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearch_Button.ForeColor = System.Drawing.Color.Black;
            this.ClearSearch_Button.Location = new System.Drawing.Point(592, 245);
            this.ClearSearch_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ClearSearch_Button.Name = "ClearSearch_Button";
            this.ClearSearch_Button.Size = new System.Drawing.Size(163, 38);
            this.ClearSearch_Button.TabIndex = 12;
            this.ClearSearch_Button.Text = "Clear Search";
            this.ClearSearch_Button.UseVisualStyleBackColor = false;
            this.ClearSearch_Button.Click += new System.EventHandler(this.ClearSearch_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.Wheat;
            this.Search_Button.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.ForeColor = System.Drawing.Color.Black;
            this.Search_Button.Location = new System.Drawing.Point(419, 245);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(163, 38);
            this.Search_Button.TabIndex = 11;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Search_Box
            // 
            this.Search_Box.BackColor = System.Drawing.Color.Wheat;
            this.Search_Box.ForeColor = System.Drawing.Color.Goldenrod;
            this.Search_Box.Location = new System.Drawing.Point(51, 245);
            this.Search_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(335, 31);
            this.Search_Box.TabIndex = 10;
            this.Search_Box.Text = "Enter Name Here";
            this.Search_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_Box.Enter += new System.EventHandler(this.Search_Box_Enter);
            this.Search_Box.Leave += new System.EventHandler(this.Search_Box_Leave);
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Submit_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Submit_Button.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Submit_Button.FlatAppearance.BorderSize = 5;
            this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.ForeColor = System.Drawing.Color.Black;
            this.Submit_Button.Location = new System.Drawing.Point(419, 332);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(336, 92);
            this.Submit_Button.TabIndex = 8;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // None_Button
            // 
            this.None_Button.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.None_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.None_Button.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.None_Button.FlatAppearance.BorderSize = 5;
            this.None_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.None_Button.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None_Button.ForeColor = System.Drawing.Color.Black;
            this.None_Button.Location = new System.Drawing.Point(419, 332);
            this.None_Button.Margin = new System.Windows.Forms.Padding(1);
            this.None_Button.Name = "None_Button";
            this.None_Button.Size = new System.Drawing.Size(336, 92);
            this.None_Button.TabIndex = 7;
            this.None_Button.Text = "None";
            this.None_Button.UseVisualStyleBackColor = false;
            this.None_Button.Click += new System.EventHandler(this.None_Button_Click);
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
            this.Back_Button.Location = new System.Drawing.Point(51, 332);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(336, 92);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "Go Back";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
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
            this.Option_3.Location = new System.Drawing.Point(51, 191);
            this.Option_3.Margin = new System.Windows.Forms.Padding(1);
            this.Option_3.Name = "Option_3";
            this.Option_3.Size = new System.Drawing.Size(336, 92);
            this.Option_3.TabIndex = 5;
            this.Option_3.Text = "Dark";
            this.Option_3.UseVisualStyleBackColor = false;
            this.Option_3.Click += new System.EventHandler(this.Option_3_Click);
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
            this.Option_4.Location = new System.Drawing.Point(419, 191);
            this.Option_4.Margin = new System.Windows.Forms.Padding(1);
            this.Option_4.Name = "Option_4";
            this.Option_4.Size = new System.Drawing.Size(336, 92);
            this.Option_4.TabIndex = 3;
            this.Option_4.Text = "Bold";
            this.Option_4.UseVisualStyleBackColor = false;
            this.Option_4.Click += new System.EventHandler(this.Option_4_Click);
            // 
            // Option_2
            // 
            this.Option_2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Option_2.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Option_2.FlatAppearance.BorderSize = 5;
            this.Option_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_2.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_2.ForeColor = System.Drawing.Color.Black;
            this.Option_2.Location = new System.Drawing.Point(419, 49);
            this.Option_2.Margin = new System.Windows.Forms.Padding(4);
            this.Option_2.Name = "Option_2";
            this.Option_2.Size = new System.Drawing.Size(336, 92);
            this.Option_2.TabIndex = 1;
            this.Option_2.Text = "Medium";
            this.Option_2.UseVisualStyleBackColor = false;
            this.Option_2.Click += new System.EventHandler(this.Option_2_Click);
            // 
            // Option_1
            // 
            this.Option_1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Option_1.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Option_1.FlatAppearance.BorderSize = 5;
            this.Option_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_1.Font = new System.Drawing.Font("Monotype Corsiva", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_1.ForeColor = System.Drawing.Color.Black;
            this.Option_1.Location = new System.Drawing.Point(51, 49);
            this.Option_1.Margin = new System.Windows.Forms.Padding(4);
            this.Option_1.Name = "Option_1";
            this.Option_1.Size = new System.Drawing.Size(336, 92);
            this.Option_1.TabIndex = 0;
            this.Option_1.Text = "Light";
            this.Option_1.UseVisualStyleBackColor = false;
            this.Option_1.Click += new System.EventHandler(this.Option_1_Click);
            // 
            // Orders_Grid
            // 
            this.Orders_Grid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Wheat;
            this.Orders_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Orders_Grid.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Orders_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Orders_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Orders_Grid.GridColor = System.Drawing.Color.Black;
            this.Orders_Grid.Location = new System.Drawing.Point(4, 33);
            this.Orders_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Orders_Grid.Name = "Orders_Grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Orders_Grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Orders_Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Orders_Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Monotype Corsiva", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders_Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Orders_Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Wheat;
            this.Orders_Grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Orders_Grid.RowTemplate.Height = 16;
            this.Orders_Grid.Size = new System.Drawing.Size(799, 278);
            this.Orders_Grid.TabIndex = 9;
            // 
            // OrderWindow
            // 
            this.OrderWindow.BackColor = System.Drawing.Color.Linen;
            this.OrderWindow.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderWindow.ForeColor = System.Drawing.Color.Black;
            this.OrderWindow.Location = new System.Drawing.Point(863, 96);
            this.OrderWindow.Margin = new System.Windows.Forms.Padding(4);
            this.OrderWindow.Name = "OrderWindow";
            this.OrderWindow.Size = new System.Drawing.Size(187, 338);
            this.OrderWindow.TabIndex = 9;
            this.OrderWindow.Text = "Next Order :\n";
            this.OrderWindow.WordWrap = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.OrderWindow);
            this.Controls.Add(this.OrderGridButton);
            this.Controls.Add(this.Coffee_Choice);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orders";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Coffee_Choice.ResumeLayout(false);
            this.Coffee_Choice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button OrderGridButton;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.GroupBox Coffee_Choice;
        private System.Windows.Forms.Button None_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Option_3;
        private System.Windows.Forms.Button Option_4;
        private System.Windows.Forms.Button Option_2;
        private System.Windows.Forms.Button Option_1;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.DataGridView Orders_Grid;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Button ClearSearch_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.RichTextBox OrderWindow;
        private System.Windows.Forms.Button DeleteOrder_Button;
        private System.Windows.Forms.Button Exit_OrderView_Button;
    }
}

