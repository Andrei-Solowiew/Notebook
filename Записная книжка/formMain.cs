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
        
        // В form load код запускается после того как форма была создана, но до того как она
        // была показана на экран
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
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
