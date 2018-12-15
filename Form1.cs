using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pranto_Restaurent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Form2 f = new Form2();
                f.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("Username Or Password is Incorrect");
            }
        }
    }
}
