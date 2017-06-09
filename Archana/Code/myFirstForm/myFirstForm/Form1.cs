using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dobBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker.Value;
            int years = ((int)ageDays.TotalDays) / 365;
            int day = dateTimePicker.Value.Day;
            string month = dateTimePicker.Value.ToString("MMMM");

            txtMsg.Text = " Hello, " + name + "! You will be" + (years + 1) + " years old on " + day + " " + month + ".";
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
