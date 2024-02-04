using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Записная_книжка
{
    public partial class formCalendar : Form
    {
        public formCalendar()
        {
            InitializeComponent();
        }

        private void formCalendar_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            DayOfWeek today = currentDate.DayOfWeek;
            int currentNum = Convert.ToInt32(today);
            DateTime start = currentDate.AddDays(-1 * (currentNum -1));
            buttonMonday.Text = start.ToString("dd.MM");
            buttonTuesday.Text = start.AddDays(1).ToString("dd.MM");
            buttonWednesday.Text = start.AddDays(2).ToString("dd.MM");
            buttonThursday.Text = start.AddDays(3).ToString("dd.MM");
            buttonFriday.Text = start.AddDays(4).ToString("dd.MM");
        }

        private void buttonMonday_Click(object sender, EventArgs e)
        {
            formTimeMonday monday = new formTimeMonday();
            monday.Show();
        }
        private void buttonTuesday_Click(object sender, EventArgs e)
        {
            formTimeTuesday tuesday = new formTimeTuesday();
            tuesday.Show();
        }
        private void buttonWednesday_Click(object sender, EventArgs e)
        {
            formTimeWednesday wednesday = new formTimeWednesday();
            wednesday.Show();
        }
        private void buttonThursday_Click(object sender, EventArgs e)
        {
            formTimeThursday thursday = new formTimeThursday();
            thursday.Show();
        }

        private void buttonFriday_Click(object sender, EventArgs e)
        {
            formTimeFriday friday = new formTimeFriday();
            friday.Show();
        }
    }
}
