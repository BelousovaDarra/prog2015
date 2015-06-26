using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace А1А2
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        public EmployedData UT { get; set; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UT = new EmployedData();
            UT.Start = dateTimePicker1.Value;
            UT.End = dateTimePicker2.Value;
            UT.Obshe = textBox1.Text;
            UT.Komn = textBox2.Text;
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
