using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CreateBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBook createBook = new CreateBook();
            createBook.Show();
        }

        private void AllBooksButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(ConfigurationManager.AppSettings.Get("XMLPath"));
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AvaliableBooksButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(ConfigurationManager.AppSettings.Get("XMLPath"));
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                object value = row["Borrowed"];
                if(value==DBNull.Value)
                {
                    row.Delete();
                }
            }
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void RentBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentBook rentBook = new RentBook();
            rentBook.Show();
        }
    }
}
