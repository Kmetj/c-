
namespace LibraryManager
{
    partial class MainPage
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
            this.AllBooksButton = new System.Windows.Forms.Button();
            this.AvaliableBooksButton = new System.Windows.Forms.Button();
            this.RentedBooksButton = new System.Windows.Forms.Button();
            this.CreateBookButton = new System.Windows.Forms.Button();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.RentBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksButton
            // 
            this.AllBooksButton.Location = new System.Drawing.Point(21, 21);
            this.AllBooksButton.Name = "AllBooksButton";
            this.AllBooksButton.Size = new System.Drawing.Size(139, 42);
            this.AllBooksButton.TabIndex = 0;
            this.AllBooksButton.Text = "All books";
            this.AllBooksButton.UseVisualStyleBackColor = true;
            this.AllBooksButton.Click += new System.EventHandler(this.AllBooksButton_Click);
            // 
            // AvaliableBooksButton
            // 
            this.AvaliableBooksButton.Location = new System.Drawing.Point(21, 69);
            this.AvaliableBooksButton.Name = "AvaliableBooksButton";
            this.AvaliableBooksButton.Size = new System.Drawing.Size(139, 42);
            this.AvaliableBooksButton.TabIndex = 1;
            this.AvaliableBooksButton.Text = "Avaliable books";
            this.AvaliableBooksButton.UseVisualStyleBackColor = true;
            this.AvaliableBooksButton.Click += new System.EventHandler(this.AvaliableBooksButton_Click);
            // 
            // RentedBooksButton
            // 
            this.RentedBooksButton.Location = new System.Drawing.Point(21, 117);
            this.RentedBooksButton.Name = "RentedBooksButton";
            this.RentedBooksButton.Size = new System.Drawing.Size(139, 42);
            this.RentedBooksButton.TabIndex = 2;
            this.RentedBooksButton.Text = "Rented books";
            this.RentedBooksButton.UseVisualStyleBackColor = true;
            // 
            // CreateBookButton
            // 
            this.CreateBookButton.Location = new System.Drawing.Point(21, 165);
            this.CreateBookButton.Name = "CreateBookButton";
            this.CreateBookButton.Size = new System.Drawing.Size(139, 42);
            this.CreateBookButton.TabIndex = 3;
            this.CreateBookButton.Text = "Create new book";
            this.CreateBookButton.UseVisualStyleBackColor = true;
            this.CreateBookButton.Click += new System.EventHandler(this.CreateBookButton_Click);
            // 
            // EditBookButton
            // 
            this.EditBookButton.Location = new System.Drawing.Point(21, 213);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(139, 42);
            this.EditBookButton.TabIndex = 4;
            this.EditBookButton.Text = "Edit existing book";
            this.EditBookButton.UseVisualStyleBackColor = true;
            // 
            // RentBookButton
            // 
            this.RentBookButton.Location = new System.Drawing.Point(21, 261);
            this.RentBookButton.Name = "RentBookButton";
            this.RentBookButton.Size = new System.Drawing.Size(139, 42);
            this.RentBookButton.TabIndex = 5;
            this.RentBookButton.Text = "Rent a book";
            this.RentBookButton.UseVisualStyleBackColor = true;
            this.RentBookButton.Click += new System.EventHandler(this.RentBookButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Location = new System.Drawing.Point(21, 309);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(139, 42);
            this.DeleteBookButton.TabIndex = 6;
            this.DeleteBookButton.Text = "Delete book";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(476, 330);
            this.dataGridView1.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.RentBookButton);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.CreateBookButton);
            this.Controls.Add(this.RentedBooksButton);
            this.Controls.Add(this.AvaliableBooksButton);
            this.Controls.Add(this.AllBooksButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllBooksButton;
        private System.Windows.Forms.Button AvaliableBooksButton;
        private System.Windows.Forms.Button RentedBooksButton;
        private System.Windows.Forms.Button CreateBookButton;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.Button RentBookButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}