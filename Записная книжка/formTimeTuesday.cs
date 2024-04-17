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
using System.Globalization;

namespace Записная_книжка
{
    public partial class formTimeTuesday : Form
    {
        string fileName = "tasksTuesday.txt";
        public formTimeTuesday()
        {
            InitializeComponent();
            if (!File.Exists(fileName))
                File.Create(fileName).Close();
            textTasks.Text = File.ReadAllText(fileName);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string time = inputTime.Text;
            string task = inputTask.Text;
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine($"{time} {task}");
            sw.Close();
            textTasks.Text = File.ReadAllText(fileName);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, string.Empty);
            textTasks.Text = File.ReadAllText(fileName);
        }
    }
}
