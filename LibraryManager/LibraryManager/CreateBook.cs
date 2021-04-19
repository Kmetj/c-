using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LibraryManager
{
    public partial class CreateBook : Form
    {
        public CreateBook()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            XmlDocument docObject = new XmlDocument();

            docObject.Load(ConfigurationManager.AppSettings.Get("XMLPath"));
            XmlNode libraryNode = docObject.SelectSingleNode("Library");
            XmlNode bookNode = libraryNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "Book", ""));
            
            bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "Name", "")).InnerText = CreateBookNameTextBox.Text;
            bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "Author", "")).InnerText = CreateBookAuthorTextBox.Text;

            bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "Borrowed", ""));
            bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "FirstName", ""));
            bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "lastName", ""));
            bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "From", ""));

            /*bookNode = docObject.SelectSingleNode("Book");
            XmlNode borrowedNode = bookNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "Borrowed", ""));

            borrowedNode = docObject.SelectSingleNode("Borrowed");
            XmlNode firstNameNode = borrowedNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "FirstName", ""));

            firstNameNode = docObject.SelectSingleNode("FirstName");
            XmlNode lastNameNode = firstNameNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "lastName", ""));
            lastNameNode.AppendChild(docObject.CreateNode(XmlNodeType.Element, "From", "")).InnerText="";
            */

            docObject.Save(ConfigurationManager.AppSettings.Get("XMLPath"));
            MessageBox.Show("Book created", "Saved", MessageBoxButtons.OK);
            this.Hide();
            MainPage pMain = new MainPage();
            pMain.Show();
        }
    }
}
