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
    public partial class Employed : Form
    {
        public Employed()
        {
            InitializeComponent();
        }

        public EmployedData SSS { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SSS = new EmployedData();
            SSS.Start = dateTimePicker1.Value;
            SSS.End = dateTimePicker2.Value;
            SSS.Obshe = textBox1.Text;
            SSS.Komn = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Employed_Load(object sender, EventArgs e)
        {

        }
    }
}
