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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                // Check if the control is an image (PictureBox)
                if (control is PictureBox pictureBox)
                {
                    float sizeIncreaseFactor =1.3f;
                    // Increase the size of the PictureBox
                    pictureBox2.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox2.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox3.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox3.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox4.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox4.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox5.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox5.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox6.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox6.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox7.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox7.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox8.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox8.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox9.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox9.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox10.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox10.Height = (int)(pictureBox.Height * sizeIncreaseFactor);

                    pictureBox11.Width = (int)(pictureBox.Width * sizeIncreaseFactor);
                    pictureBox11.Height = (int)(pictureBox.Height * sizeIncreaseFactor);



                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            
           
        }
    }
}
