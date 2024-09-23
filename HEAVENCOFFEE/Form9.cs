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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 tela3 = new Form7();
            tela3.ShowDialog();
            this.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 tela3 = new Form8();
            tela3.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12 tela3 = new Form12();
            tela3.ShowDialog();
            this.Visible = true;
        }
    }
}
