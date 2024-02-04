using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Записная_книжка
{
    public partial class formContacts : Form
    {
        string fileName = "Contacts.txt";
        public formContacts()
        {
            InitializeComponent();
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
            textContacts.Text = File.ReadAllText(fileName);
        }
        public void SetName(string name)
        {
            inputName.Text = name;
        }
        public void SetContact(string contact)
        {
            inputContact.Text = contact;
        }
        public string GetLastData()
        {
            string name = inputName.Text;
            string contact = inputContact.Text;
            return $"{name}\n{contact}";
        }
        private void inputTime_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string contact = inputContact.Text;
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine($"{name}\n{contact}");
            sw.WriteLine(" ");
            sw.Close();
            textContacts.Text = File.ReadAllText(fileName);
        }

        private void formContacts_Load(object sender, EventArgs e)
        {

        }
    }
}
