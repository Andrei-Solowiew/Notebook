using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Записная_книжка
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            formContacts form_contacts = new formContacts();
            form_contacts.Show();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            formCalendar form_calendar = new formCalendar();
            form_calendar.Show();
        }

        private void buttonPlanning_Click(object sender, EventArgs e)
        {
            formPlanning form_planning = new formPlanning();
            form_planning.Show();
        }
    }
}
