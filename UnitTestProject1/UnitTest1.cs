using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Записная_книжка;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestCase1()
        {
            formTimeMonday monday = new formTimeMonday();
            monday.buttonClean_Click(null, EventArgs.Empty);
            monday.SetInputTime("10:00");
            monday.SetInputTask("задача1");
            monday.buttonAdd_Click(null, EventArgs.Empty);
            string expectedText = "10:00 задача1";
            string last_task = monday.GetLastTask();
            Assert.AreEqual(expectedText, last_task);
        }
        [TestMethod]
        public async Task TestCase2()
        {
            formContacts contacts = new formContacts();
            contacts.SetName("Валерий Шпекл");
            contacts.SetContact("88005553535");
            contacts.buttonAdd_Click(null, EventArgs.Empty);
            string expected = "Валерий Шпекл\n88005553535";
            Assert.AreEqual(expected, contacts.GetLastData());
        }
        [TestMethod]
        public async Task TestCase3()
        {
            formPlanning planning = new formPlanning();
            planning.SetInfo("Здесь информация");
            planning.btnAdd_Click(null, EventArgs.Empty);
            string expected = "Здесь информация";
            Assert.AreEqual(expected, planning.GetLastInfo());
        }
    }
}