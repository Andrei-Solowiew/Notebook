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
    public partial class formPlanning : Form
    {
        string fileName = "Planning.txt";
        public formPlanning()
        {
            InitializeComponent();
            if (!File.Exists(fileName))
                File.Create(fileName).Close();
            textInfo.Text = File.ReadAllText(fileName);
        }
        public void SetInfo(string info)
        {
            inputInfo.Text = info;
        }
        public string GetLastInfo()
        {
            return inputInfo.Text;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            string info = inputInfo.Text;
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine($"{info}");
            sw.Close();
            textInfo.Text = File.ReadAllText(fileName);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, string.Empty);
            textInfo.Text = File.ReadAllText(fileName);
        }
    }
}
