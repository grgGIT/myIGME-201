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
    public partial class Form3 : Form
    {
        private int elapsedTimeInSeconds = 0;

        public Form3()
        {
            InitializeComponent();
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTimeInSeconds++; // Increment the elapsed time

            // Check if the elapsed time is 15 seconds
            if (elapsedTimeInSeconds == 15)
            {
                // for when 15 seconds have passed
                // Display a message
                MessageBox.Show("Times up, you suck at ordering. You should submit anyways. OR LEAVE!");

                // Stop the timer if needed
                timer1.Stop();

                // Reset the elapsed time
                elapsedTimeInSeconds = 0;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Count the number of words in the RichTextBox
            int wordCount = CountWords(richTextBox1.Text);

            // Calculate the progress value based on the number of words
            int progressValue = wordCount * 10;

            // Ensure the progress value does not exceed 100
            progressValue = Math.Min(progressValue, 100);

            // Update the ProgressBar value
            progressBar1.Value = progressValue;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                // Set the label text
                label3.Text = "Done, go submit";
                label3.ForeColor = Color.Green;
            }
            else
            {
                // Clear the label text
                label3.Text = "";
            }
        }

        /// just a method to count the number of words in the rich textbox
        private int CountWords(string text)
        {
            // Split the text into words and count them
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font largeFont = new Font("Arial", 36, FontStyle.Bold);

            // Display a MessageBox with the custom font
            MessageBox.Show("YOU ARE WRONG I DONT CARE", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1, 0, false);

            // Dispose of the custom font to release resources
            largeFont.Dispose();
        }
    }
}
