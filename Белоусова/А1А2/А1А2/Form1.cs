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
using System.Xml.Serialization;

namespace А1А2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitDefault();
            InitializeComponent();
        }

        public Class1 Sp()
        {
            var Inf = new Class1();

            Inf.Name = textBox1.Text;
            Inf.Surname = textBox2.Text;
            Inf.Otchestvo = textBox3.Text;
            Inf.Group = textBox4.Text;
            Inf.Live = textBox5.Text;
            Inf.Room = textBox6.Text;
            Inf.University = textBox7.Text;
            Inf.Pasport = textBox8.Text;
            Inf.Telephone = textBox9.Text;
            Inf.Get = textBox10.Text;
            Inf.Cost = textBox12.Text;

            Inf.Date1 = dateTimePicker1.Value;
            Inf.Date2 = dateTimePicker2.Value;
            Inf.Date3 = dateTimePicker3.Value;
            Inf.Date4 = dateTimePicker4.Value;

            return Inf;
        }

        void InitDefault ()
        {
          radioButtonItems = new List<string> { };
        }

        List<string> radioButtonItems;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new NewForm();
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                listBox1.Items.Add(form.UT);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Title = "Save", Filter = "Data|*.Data" };
            var result = sfd.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(Class1));
            var file = File.Create(sfd.FileName);
            xs.Serialize(file, Sp());
            file.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Title = "Save", Filter = "Data|*Data" };
            var result = ofd.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(Class1));
            var file = File.OpenRead(ofd.FileName);
            Class1 Inf = (Class1)xs.Deserialize(file);
            file.Close();

            textBox1.Text = Inf.Name;
            textBox2.Text = Inf.Surname;
            textBox3.Text = Inf.Otchestvo;
            textBox4.Text = Inf.Group;
            textBox5.Text = Inf.Live;
            textBox6.Text = Inf.Room;
            textBox7.Text = Inf.University;
            textBox8.Text = Inf.Pasport;
            textBox9.Text = Inf.Telephone;
            textBox10.Text = Inf.Get;
            textBox12.Text = Inf.Cost;

            dateTimePicker1.Value = Inf.Date1;
            dateTimePicker2.Value = Inf.Date2;
            dateTimePicker3.Value = Inf.Date3;
            dateTimePicker4.Value = Inf.Date4;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mcd = new Class1();
            mcd.Name = Name.Text;
            mcd.Surname = Surname.Text;
            mcd.Telephone = Telephone.Text;
            mcd.Pasport = Pasport.Text;
            mcd.University = University.Text;
            mcd.Room = Room.Text;
            mcd.Cost = Cost.Text;
            mcd.Get = Get.Text;
            mcd.Group = Group.Text;
            mcd.Live = Live.Text;
            
            
            
            mcd.Data1 = Data1.Value;
            mcd.Data2 = Data2.Value;
            mcd.Data3 = Data3.Value;
            mcd.Data4 = Data4.Value;

            foreach (MatData ed in listBox.Items)
            {
                mcd.Mat.Add(ed);
            }

            var rpt = new ReportPrintTool(new MatCenXtraReport()
            {
                DataSource = new BindingSource()
                {
                    DataSource = mcd
                }
            });
            rpt.Report.CreateDocument(false);
            rpt.ShowPreview();


        }


    }
}
