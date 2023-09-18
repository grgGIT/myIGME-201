using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor_Gracia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);

            this.Text = "MyEditor_Gracia";
            this.toolStrip1.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip_ItemClicked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = "MyEditor_Gracia";
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType =  RichTextBoxStreamType.RichText;
                if (openFileDialog1.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.LoadFile(openFileDialog1.FileName, richTextBoxStreamType);
                this.Text = "MyEditor_Gracia (" + openFileDialog1.FileName + ")";
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (saveFileDialog1.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.SaveFile(saveFileDialog1.FileName, richTextBoxStreamType);
                this.Text = "MyEditor_Gracia (" + saveFileDialog1.FileName + ")";
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.BoldtoolStripButton1)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.BoldtoolStripButton1;
            }

           else if (e.ClickedItem == this.italicstoolStripButton2)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicstoolStripButton2;
            }

           else if (e.ClickedItem == this.underlineToolStripButton1)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton1;
            }
            else if (e.ClickedItem == this.ColortoolStripButton3)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                    ColortoolStripButton3.BackColor = colorDialog1.Color;
                }
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton1;
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);

               
            }

        }
        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;
            selectionFont = richTextBox1.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox1.Font;
            }
             if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }
            this.richTextBox1.SelectionFont = newFont;
        }


        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
