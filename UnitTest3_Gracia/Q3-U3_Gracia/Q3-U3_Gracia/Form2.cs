using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3_U3_Gracia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //chicken
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                // Make the PictureBox visible
                pictureBox3.Visible = true;
                button1.Visible = true;
            }
            else
            {
                // If the radio button is not checked, you may want to hide the PictureBox
                pictureBox3.Visible = false;
            }
        }

        //mac
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Make the PictureBox visible
                pictureBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                // If the radio button is not checked, you may want to hide the PictureBox
                pictureBox1.Visible = false;
            }

        }

        //ribs
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Make the PictureBox visible
                pictureBox2.Visible = true;
                button1.Visible = true;
            }
            else
            {
                // If the radio button is not checked, you may want to hide the PictureBox
                pictureBox2.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("PREPARE FOR OUR DELICIOUSNESS? ARE U SURE?");
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            button1.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form3 form3 = new Form3();

            // Show Form2
            form3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
