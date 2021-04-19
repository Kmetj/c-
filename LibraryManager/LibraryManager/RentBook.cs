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
    public partial class RentBook : Form
    {
        public RentBook()
        {
            InitializeComponent();
        }

        private void RentBookButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(ConfigurationManager.AppSettings.Get("XMLPath"));
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["Name"] == RentBookNameTextBox.Text && row["Author"] == RentBookAuthorTextBox.Text)
                {
                    row["FirstName"] = RentBookFnameTextBox.Text;
                    row["lastName"] = RentBookLNameTextBox.Text;
                    if (monthCalendar1.SelectionRange.Start < DateTime.Now)
                    {
                        row["Borrowed"] = monthCalendar1.SelectionRange.Start.ToShortDateString();

                        System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(ConfigurationManager.AppSettings.Get("XMLPath"));
                        ds.WriteXml(xmlSW, XmlWriteMode.WriteSchema);
                        xmlSW.Close();
                        MessageBox.Show("Book rented", "Success", MessageBoxButtons.OK);
                        this.Hide();
                        MainPage pMain = new MainPage();
                        pMain.Show();
                    }
                    else MessageBox.Show("Cant set date from the future", "Incorect date", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("The book does not exist", "Book not found", MessageBoxButtons.OK);
                    this.Hide();
                    MainPage pMain = new MainPage();
                    pMain.Show();
                }
            }

        }
    }
}
