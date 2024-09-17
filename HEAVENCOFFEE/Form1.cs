using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEAVENCOFFEE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 tela3 = new Form2();
            tela3.ShowDialog();
            this.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form3 tela3 = new Form3();
            tela3.ShowDialog();
            this.Visible = true;

        }
    }
}
