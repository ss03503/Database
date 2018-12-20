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
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
            comboBox1.Items.Add("Carding");
            comboBox1.Items.Add("Blowroom");
            comboBox1.Items.Add("Simplex");
            comboBox1.Items.Add("Drawing");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                comboBox2.Items.Add("Maintenance Schedule");
                comboBox2.Items.Add("Job Description");
                comboBox2.Items.Add("Machine History");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(comboBox2.Text=="Maintenance Schedule")
            {
                Maintenance work = new Maintenance();
                work.Show();
            }
            else if(comboBox2.Text == "Job Description")
            {
                this.Hide();
                JobDescrip work = new JobDescrip();
                work.Show();
            }
        }

        private void department_Load(object sender, EventArgs e)
        {

        }
    }
}
