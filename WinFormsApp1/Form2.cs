using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Form1.Student_Name;
            textBox2.Text = Form1.Roll_;
            textBox3.Text = Form1.Reg_Id;
            textBox4.Text = Form1.Semester_;
            textBox5.Text = Form1.Blood_Group_;
            textBox6.Text = Form1.Gender_;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
