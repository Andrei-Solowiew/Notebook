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
    public partial class formTimeMonday : Form
    {
        string fileName = "tasksMonday.txt";
        public formTimeMonday()
        {
            InitializeComponent();
            //Вывод текста из файла
            if (!File.Exists(fileName))
            File.Create(fileName).Close();
            textTasks.Text = File.ReadAllText(fileName);
        }
        public void SetInputTime(string time)
        {
            inputTime.Text = time;
        }
        public void SetInputTask(string task)
        {
            inputTask.Text = task;
        }
        public void SetResultTask(string task)
        {
            textTasks.Text = task;
        }
        public string GetResultTask()
        {
            return textTasks.Text;
        }
        public string GetLastTask()
        {
            string time = inputTime.Text;
            string task = inputTask.Text;
            return $"{time} {task}";
        }
        public void buttonAdd_Click(object sender, EventArgs e)
        {
            string time = inputTime.Text;
            string task = inputTask.Text;
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine($"{time} {task}");
            sw.Close();
            textTasks.Text = File.ReadAllText(fileName);
        }
        public void buttonClean_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, string.Empty);
            textTasks.Text = File.ReadAllText(fileName);
        }
    }
}
