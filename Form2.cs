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
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                String a = Interaction.InputBox("Please Enter Quantity");
                int b = Convert.ToInt32(a);

                int sum = 200 * b;
                dataGridView1.Rows.Add("Burger", b, sum);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Only Numbers");

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                String a = Interaction.InputBox("Please Enter Quantity");
                int b = Convert.ToInt32(a);

                int sum = 50 * b;
                dataGridView1.Rows.Add("French Fry", b, sum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Only Numbers");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                String a = Interaction.InputBox("Please Enter Quantity");
                int b = Convert.ToInt32(a);
                int sum = 90 * b;
                dataGridView1.Rows.Add("Chiken Fry", b, sum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Only Numbers");

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {

                String a = Interaction.InputBox("Please Enter Quantity");
                int b = Convert.ToInt32(a);

                int sum = 120 * b;
                dataGridView1.Rows.Add("Sabdwitch", b, sum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Only Numbers");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                String a = Interaction.InputBox("Please Enter Quantity");
                int b = Convert.ToInt32(a);

                int sum = 80 * b;
                dataGridView1.Rows.Add("Pasty", b, sum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Only Numbers");

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                String a = Interaction.InputBox("Please Enter Quantity");
                int b = Convert.ToInt32(a);

                int sum = 50 * b;
                dataGridView1.Rows.Add("Cold Drinks", b, sum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Only Numbers");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                label8.Text = "Total Price is : " + sum.ToString() + " Tk. BDT";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
