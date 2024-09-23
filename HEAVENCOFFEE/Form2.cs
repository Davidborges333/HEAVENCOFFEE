using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEAVENCOFFEE
{
    public partial class Form2 : Form
    {
        private object lblError;
        private object txtEmail;
        private object txtPassword;

       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 tela3 = new Form9();
            tela3.ShowDialog();
            this.Visible = true;
        }
    }
    }



