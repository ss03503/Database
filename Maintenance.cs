using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
            comboBox1.Items.Add("Daily");
            comboBox1.Items.Add("Weekly");
            comboBox1.Items.Add("Half Monthly");
            comboBox1.Items.Add("Monthly");
            comboBox1.Items.Add("Quarterly");
            comboBox1.Items.Add("Half Yearly");
            comboBox1.Items.Add("Yearly");

            comboBox2.Items.Add("Doffer");
            comboBox2.Items.Add("Waste Pipe");
            comboBox2.Items.Add("Chute");
            comboBox2.Items.Add("Compressor");
            comboBox2.Items.Add("Filter");
            comboBox2.Items.Add("Other");

            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.Items.Add("4");
            comboBox3.Items.Add("5");
            comboBox3.Items.Add("6");
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
