using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;


namespace Q2_U3_NOTbROKEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Visible = false;
                    pictureBox.Enabled = false;
                    pictureBox.MouseEnter += new EventHandler(this.PictureBox__MouseEnter);
                    pictureBox.MouseLeave += new EventHandler(this.PictureBox__MouseLeave);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.CheckedChanged += new EventHandler(this.RadioButton__CheckedChanged);
                    if (radioButton == this.radioButton1)
                        radioButton.Tag = (object)this.pictureBox1;
                    else if (radioButton == this.radioButton2)
                        radioButton.Tag = (object)this.pictureBox2;
                    else if (radioButton == this.radioButton3)
                        radioButton.Tag = (object)this.pictureBox3;
                    else if (radioButton == this.radioButton4)
                        radioButton.Tag = (object)this.pictureBox4;
                    else if (radioButton == this.radioButton5)
                        radioButton.Tag = (object)this.pictureBox5;
                    else if (radioButton == this.radioButton6)
                        radioButton.Tag = (object)this.pictureBox6;
                    else if (radioButton == this.radioButton7)
                        radioButton.Tag = (object)this.pictureBox7;
                    else if (radioButton == this.radioButton8)
                        radioButton.Tag = (object)this.pictureBox8;
                    else if (radioButton == this.radioButton9)
                        radioButton.Tag = (object)this.pictureBox9;
                    else if (radioButton == this.radioButton10)
                        radioButton.Tag = (object)this.pictureBox10;
                    else if (radioButton == this.radioButton11)
                        radioButton.Tag = (object)this.pictureBox11;
                    else if (radioButton == this.radioButton12)
                        radioButton.Tag = (object)this.pictureBox12;
                    else if (radioButton == this.radioButton13)
                        radioButton.Tag = (object)this.pictureBox13;
                    else if (radioButton == this.radioButton14)
                        radioButton.Tag = (object)this.pictureBox14;
                    else if (radioButton == this.radioButton15)
                        radioButton.Tag = (object)this.pictureBox15;
                    else if (radioButton == this.radioButton16)
                        radioButton.Tag = (object)this.pictureBox16;
                }
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;
                    textBox.MouseHover += new EventHandler(this.TextBox__MouseHover);
                    textBox.Validating += new CancelEventHandler(this.TxtBox__Validating);
                    textBox.KeyPress += new KeyPressEventHandler(this.TxtBox__KeyPress);
                    textBox.Text = "0";
                    if (textBox == this.textBox1)
                        textBox.Tag = (object)23;
                    if (textBox == this.textBox2)
                        textBox.Tag = (object)25;
                    if (textBox == this.textBox3)
                        textBox.Tag = (object)32;
                    if (textBox == this.textBox4)
                        textBox.Tag = (object)40;
                    if (textBox == this.textBox5)
                        textBox.Tag = (object)42;
                    if (textBox == this.textBox6)
                        textBox.Tag = (object)34;
                    if (textBox == this.textBox7)
                        textBox.Tag = (object)15;
                    if (textBox == this.textBox8)
                        textBox.Tag = (object)8;
                    if (textBox == this.textBox9)
                        textBox.Tag = (object)14;
                    if (textBox == this.textBox10)
                        textBox.Tag = (object)1;
                    if (textBox == this.textBox11)
                        textBox.Tag = (object)43;
                    if (textBox == this.textBox12)
                        textBox.Tag = (object)2;
                    if (textBox == this.textBox13)
                        textBox.Tag = (object)44;
                    if (textBox == this.textBox14)
                        textBox.Tag = (object)26;
                    if (textBox == this.textBox15)
                        textBox.Tag = (object)35;
                    if (textBox == this.textBox16)
                        textBox.Tag = (object)3;
                }
            }
            foreach (Control control in (ArrangedElementCollection)this.groupBox2.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);
                    List<RadioButton> radioButtonList = new List<RadioButton>();
                    if (radioButton == this.radioButton17)
                    {
                        radioButtonList.Add(this.radioButton1);
                        radioButtonList.Add(this.radioButton2);
                        radioButtonList.Add(this.radioButton3);
                        radioButtonList.Add(this.radioButton4);
                        radioButtonList.Add(this.radioButton5);
                        radioButtonList.Add(this.radioButton6);
                        radioButtonList.Add(this.radioButton7);
                        radioButtonList.Add(this.radioButton8);
                        radioButtonList.Add(this.radioButton9);
                        radioButtonList.Add(this.radioButton10);
                        radioButtonList.Add(this.radioButton11);
                        radioButtonList.Add(this.radioButton12);
                        radioButtonList.Add(this.radioButton13);
                        radioButtonList.Add(this.radioButton14);
                        radioButtonList.Add(this.radioButton15);
                        radioButtonList.Add(this.radioButton16);
                    }
                    if (radioButton == this.radioButton18)
                    {
                        radioButtonList.Add(this.radioButton3);
                        radioButtonList.Add(this.radioButton5);
                        radioButtonList.Add(this.radioButton7);
                        radioButtonList.Add(this.radioButton8);
                        radioButtonList.Add(this.radioButton9);
                        radioButtonList.Add(this.radioButton13);
                        radioButtonList.Add(this.radioButton15);
                    }
                    if (radioButton == this.radioButton19)
                    {
                        radioButtonList.Add(this.radioButton1);
                        radioButtonList.Add(this.radioButton2);
                        radioButtonList.Add(this.radioButton4);
                        radioButtonList.Add(this.radioButton6);
                        radioButtonList.Add(this.radioButton11);
                        radioButtonList.Add(this.radioButton14);
                    }
                    if (radioButton == this.radioButton20)
                        radioButtonList.Add(this.radioButton16);
                    if (radioButton == this.radioButton21)
                    {
                        radioButtonList.Add(this.radioButton10);
                        radioButtonList.Add(this.radioButton12);
                    }
                    radioButton.Tag = (object)radioButtonList;
                }
            }
            this.radioButton17.Checked = true;
            this.radioButton1.Checked = true;
            this.pictureBox1.Visible = true;
            this.pictureBox1.Enabled = true;
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);
            this.button1.Enabled = false;
            this.button1.Click += new EventHandler(this.Button1_Click);
            this.toolStripProgressBar1.Maximum = 240;
            this.toolStripProgressBar1.Value = 240;
            this.timer1.Interval = 500;
            this.timer1.Tick += new EventHandler(this.Timer1__Tick);
        }

        private void TextBox__MouseHover(object sender, EventArgs e) => this.toolTip1.Show("Which # President?", (IWin32Window)sender);

        private void Timer1__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;
            if (this.toolStripProgressBar1.Value != 0)
                return;
            this.timer1.Stop();
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    control.Text = "0";
            }
            this.toolStripProgressBar1.Value = 240;
        }

        private void Button1_Click(object sender, EventArgs e) => Application.Exit();

        private void TxtBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.toolStripProgressBar1.Value == 240)
                this.timer1.Start();
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TxtBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
            bool flag = true;
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox2 = (TextBox)control;
                    if (Convert.ToInt32(textBox2.Text) != (int)textBox2.Tag)
                        flag = false;
                }
            }
            if (flag)
            {
                this.timer1.Stop();
                this.button1.Enabled = true;
                this.webBrowser1.Navigate("https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif");
            }
            if (!(textBox1.Text != "0"))
                return;
            this.errorProvider.SetError((Control)textBox1, (string)null);
            e.Cancel = false;
            if (Convert.ToInt32(textBox1.Text) != (int)textBox1.Tag)
            {
                this.errorProvider.SetError((Control)textBox1, "That is the wrong number.");
                e.Cancel = true;
            }
        }

        private void WebBrowser1__DocumentCompleted(
          object sender,
          WebBrowserDocumentCompletedEventArgs e)
        {
            this.groupBox1.Text = this.webBrowser1.Url.ToString();
            foreach (HtmlElement htmlElement in this.webBrowser1.Document.GetElementsByTagName("a"))
                htmlElement.SetAttribute("title", "Professor Schuh for President!");
        }

        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height *= 2;
            pictureBox.Width *= 2;
            pictureBox.BringToFront();
        }

        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height /= 2;
            pictureBox.Width /= 2;
        }

        private void FilterRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            List<RadioButton> tag = (List<RadioButton>)((Control)sender).Tag;
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (tag.Contains(radioButton))
                    {
                        radioButton.Enabled = true;
                        radioButton.Visible = true;
                    }
                    else
                    {
                        radioButton.Enabled = false;
                        radioButton.Visible = false;
                    }
                }
            }
            tag[0].Checked = true;
        }

        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (!radioButton.Checked)
                return;
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (radioButton.Tag == pictureBox)
                    {
                        pictureBox.Visible = true;
                        pictureBox.Enabled = true;
                    }
                    else
                    {
                        pictureBox.Visible = false;
                        pictureBox.Enabled = false;
                    }
                }
            }
            this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/" + radioButton.Text);
        }


        private void InitializeComponent()
        {
            this.components = (IContainer)new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new WebBrowser();
            this.groupBox1 = new GroupBox();
            this.button1 = new Button();
            this.radioButton1 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.radioButton4 = new RadioButton();
            this.radioButton5 = new RadioButton();
            this.radioButton6 = new RadioButton();
            this.radioButton7 = new RadioButton();
            this.radioButton8 = new RadioButton();
            this.radioButton9 = new RadioButton();
            this.radioButton10 = new RadioButton();
            this.radioButton11 = new RadioButton();
            this.radioButton12 = new RadioButton();
            this.radioButton13 = new RadioButton();
            this.radioButton14 = new RadioButton();
            this.radioButton15 = new RadioButton();
            this.radioButton16 = new RadioButton();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox7 = new TextBox();
            this.textBox8 = new TextBox();
            this.textBox9 = new TextBox();
            this.textBox10 = new TextBox();
            this.textBox11 = new TextBox();
            this.textBox12 = new TextBox();
            this.textBox13 = new TextBox();
            this.textBox14 = new TextBox();
            this.textBox15 = new TextBox();
            this.textBox16 = new TextBox();
            this.pictureBox1 = new PictureBox();
            this.statusStrip1 = new StatusStrip();
            this.toolStripProgressBar1 = new ToolStripProgressBar();
            this.timer1 = new Timer(this.components);
            this.pictureBox2 = new PictureBox();
            this.pictureBox3 = new PictureBox();
            this.pictureBox4 = new PictureBox();
            this.pictureBox5 = new PictureBox();
            this.pictureBox6 = new PictureBox();
            this.pictureBox7 = new PictureBox();
            this.pictureBox8 = new PictureBox();
            this.pictureBox9 = new PictureBox();
            this.pictureBox10 = new PictureBox();
            this.pictureBox11 = new PictureBox();
            this.pictureBox12 = new PictureBox();
            this.pictureBox13 = new PictureBox();
            this.pictureBox14 = new PictureBox();
            this.pictureBox15 = new PictureBox();
            this.pictureBox16 = new PictureBox();
            this.errorProvider = new ErrorProvider(this.components);
            this.toolTip1 = new ToolTip(this.components);
            this.groupBox2 = new GroupBox();
            this.radioButton21 = new RadioButton();
            this.radioButton20 = new RadioButton();
            this.radioButton19 = new RadioButton();
            this.radioButton18 = new RadioButton();
            this.radioButton17 = new RadioButton();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((ISupportInitialize)this.pictureBox2).BeginInit();
            ((ISupportInitialize)this.pictureBox3).BeginInit();
            ((ISupportInitialize)this.pictureBox4).BeginInit();
            ((ISupportInitialize)this.pictureBox5).BeginInit();
            ((ISupportInitialize)this.pictureBox6).BeginInit();
            ((ISupportInitialize)this.pictureBox7).BeginInit();
            ((ISupportInitialize)this.pictureBox8).BeginInit();
            ((ISupportInitialize)this.pictureBox9).BeginInit();
            ((ISupportInitialize)this.pictureBox10).BeginInit();
            ((ISupportInitialize)this.pictureBox11).BeginInit();
            ((ISupportInitialize)this.pictureBox12).BeginInit();
            ((ISupportInitialize)this.pictureBox13).BeginInit();
            ((ISupportInitialize)this.pictureBox14).BeginInit();
            ((ISupportInitialize)this.pictureBox15).BeginInit();
            ((ISupportInitialize)this.pictureBox16).BeginInit();
            ((ISupportInitialize)this.errorProvider).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            this.webBrowser1.Dock = DockStyle.Fill;
            this.webBrowser1.Location = new Point(3, 16);
            this.webBrowser1.MinimumSize = new Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new Size(626, 541);
            this.webBrowser1.TabIndex = 0;
            this.groupBox1.Controls.Add((Control)this.webBrowser1);
            this.groupBox1.Location = new Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(632, 560);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.button1.CausesValidation = false;
            this.button1.Location = new Point(906, 587);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(110, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Benjamin Harrison";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(171, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(104, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "William McKinley";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new Point(12, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new Size(124, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Franklin D Roosevelt";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new Point(171, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new Size(100, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ronald Reagan";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new Point(12, 58);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new Size(101, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "William J Clinton";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new Point(171, 58);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new Size((int)sbyte.MaxValue, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Dwight D Eisenhower";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new Point(12, 81);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new Size(107, 17);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "James Buchanan";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new Point(171, 81);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new Size(104, 17);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Martin VanBuren";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new Point(12, 104);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new Size(95, 17);
            this.radioButton9.TabIndex = 10;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Franklin Pierce";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new Point(171, 104);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new Size(120, 17);
            this.radioButton10.TabIndex = 11;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "George Washington";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new Point(12, (int)sbyte.MaxValue);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new Size(101, 17);
            this.radioButton11.TabIndex = 12;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "George W Bush";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new Point(171, (int)sbyte.MaxValue);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new Size(83, 17);
            this.radioButton12.TabIndex = 13;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "John Adams";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new Point(12, 150);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new Size(96, 17);
            this.radioButton13.TabIndex = 14;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Barack Obama";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new Point(171, 150);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new Size(122, 17);
            this.radioButton14.TabIndex = 15;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Theodore Roosevelt";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new Point(12, 173);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new Size(102, 17);
            this.radioButton15.TabIndex = 16;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "John F Kennedy";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new Point(171, 173);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new Size(109, 17);
            this.radioButton16.TabIndex = 17;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "Thomas Jefferson";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.textBox1.Location = new Point(138, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(27, 20);
            this.textBox1.TabIndex = 18;
            this.toolTip1.SetToolTip((Control)this.textBox1, "Which Number President?");
            this.textBox2.Location = new Point(319, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(27, 20);
            this.textBox2.TabIndex = 19;
            this.textBox3.Location = new Point(138, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(27, 20);
            this.textBox3.TabIndex = 20;
            this.toolTip1.SetToolTip((Control)this.textBox3, "Which Number President?\r\n");
            this.textBox4.Location = new Point(319, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(27, 20);
            this.textBox4.TabIndex = 21;
            this.textBox5.Location = new Point(138, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(27, 20);
            this.textBox5.TabIndex = 22;
            this.toolTip1.SetToolTip((Control)this.textBox5, "Which Number President?\r\n");
            this.textBox6.Location = new Point(319, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(27, 20);
            this.textBox6.TabIndex = 23;
            this.textBox7.Location = new Point(138, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Size(27, 20);
            this.textBox7.TabIndex = 24;
            this.textBox8.Location = new Point(319, 81);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(27, 20);
            this.textBox8.TabIndex = 25;
            this.textBox9.Location = new Point(138, 103);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Size(27, 20);
            this.textBox9.TabIndex = 26;
            this.textBox10.Location = new Point(319, 103);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Size(27, 20);
            this.textBox10.TabIndex = 27;
            this.textBox11.Location = new Point(138, (int)sbyte.MaxValue);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Size(27, 20);
            this.textBox11.TabIndex = 28;
            this.textBox12.Location = new Point(319, 126);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Size(27, 20);
            this.textBox12.TabIndex = 29;
            this.textBox13.Location = new Point(138, 150);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Size(27, 20);
            this.textBox13.TabIndex = 30;
            this.textBox14.Location = new Point(319, 150);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Size(27, 20);
            this.textBox14.TabIndex = 31;
            this.textBox15.Location = new Point(138, 173);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Size(27, 20);
            this.textBox15.TabIndex = 32;
            this.textBox16.Location = new Point(319, 173);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Size(27, 20);
            this.textBox16.TabIndex = 33;
            this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(12, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(153, 209);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.statusStrip1.Items.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.toolStripProgressBar1
            });
            this.statusStrip1.Location = new Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(984, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new Size(750, 16);
            this.toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
            this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
            this.pictureBox2.Location = new Point(12, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(153, 209);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
            this.pictureBox3.Location = new Point(12, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(153, 209);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
            this.pictureBox4.Location = new Point(12, 205);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(153, 209);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            this.pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
            this.pictureBox5.Location = new Point(12, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(153, 209);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            this.pictureBox6.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
            this.pictureBox6.Location = new Point(12, 205);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(153, 209);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            this.pictureBox7.Image = (Image)componentResourceManager.GetObject("pictureBox7.Image");
            this.pictureBox7.Location = new Point(12, 205);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(153, 209);
            this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            this.pictureBox8.Image = (Image)componentResourceManager.GetObject("pictureBox8.Image");
            this.pictureBox8.Location = new Point(12, 205);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(153, 209);
            this.pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 42;
            this.pictureBox8.TabStop = false;
            this.pictureBox9.Image = (Image)componentResourceManager.GetObject("pictureBox9.Image");
            this.pictureBox9.Location = new Point(12, 205);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new Size(153, 209);
            this.pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 43;
            this.pictureBox9.TabStop = false;
            this.pictureBox10.Image = (Image)componentResourceManager.GetObject("pictureBox10.Image");
            this.pictureBox10.Location = new Point(12, 205);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new Size(153, 209);
            this.pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 44;
            this.pictureBox10.TabStop = false;
            this.pictureBox11.Image = (Image)componentResourceManager.GetObject("pictureBox11.Image");
            this.pictureBox11.Location = new Point(12, 205);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new Size(153, 209);
            this.pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 45;
            this.pictureBox11.TabStop = false;
            this.pictureBox12.Image = (Image)componentResourceManager.GetObject("pictureBox12.Image");
            this.pictureBox12.Location = new Point(12, 205);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new Size(153, 209);
            this.pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 46;
            this.pictureBox12.TabStop = false;
            this.pictureBox13.Image = (Image)componentResourceManager.GetObject("pictureBox13.Image");
            this.pictureBox13.Location = new Point(12, 205);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new Size(153, 209);
            this.pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 47;
            this.pictureBox13.TabStop = false;
            this.pictureBox14.Image = (Image)componentResourceManager.GetObject("pictureBox14.Image");
            this.pictureBox14.Location = new Point(12, 205);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new Size(153, 209);
            this.pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 48;
            this.pictureBox14.TabStop = false;
            this.pictureBox15.Image = (Image)componentResourceManager.GetObject("pictureBox15.Image");
            this.pictureBox15.Location = new Point(12, 205);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new Size(153, 209);
            this.pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 49;
            this.pictureBox15.TabStop = false;
            this.pictureBox16.Image = (Image)componentResourceManager.GetObject("pictureBox16.Image");
            this.pictureBox16.Location = new Point(12, 205);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new Size(153, 209);
            this.pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 50;
            this.pictureBox16.TabStop = false;
            this.errorProvider.ContainerControl = (ContainerControl)this;
            this.toolTip1.IsBalloon = true;
            this.groupBox2.Controls.Add((Control)this.radioButton21);
            this.groupBox2.Controls.Add((Control)this.radioButton20);
            this.groupBox2.Controls.Add((Control)this.radioButton19);
            this.groupBox2.Controls.Add((Control)this.radioButton18);
            this.groupBox2.Controls.Add((Control)this.radioButton17);
            this.groupBox2.Location = new Point(197, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(149, 133);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new Point(11, 108);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new Size(70, 17);
            this.radioButton21.TabIndex = 4;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "Federalist";
            this.radioButton21.UseVisualStyleBackColor = true;
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new Point(11, 85);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new Size(136, 17);
            this.radioButton20.TabIndex = 3;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "Democratic-Republican";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new Point(11, 62);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new Size(79, 17);
            this.radioButton19.TabIndex = 2;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "Republican";
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new Point(11, 39);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new Size(71, 17);
            this.radioButton18.TabIndex = 1;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "Democrat";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new Point(11, 16);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new Size(36, 17);
            this.radioButton17.TabIndex = 0;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "All";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(984, 650);
            this.ControlBox = false;
            this.Controls.Add((Control)this.groupBox2);
            this.Controls.Add((Control)this.pictureBox16);
            this.Controls.Add((Control)this.pictureBox15);
            this.Controls.Add((Control)this.pictureBox14);
            this.Controls.Add((Control)this.pictureBox13);
            this.Controls.Add((Control)this.pictureBox12);
            this.Controls.Add((Control)this.pictureBox11);
            this.Controls.Add((Control)this.pictureBox10);
            this.Controls.Add((Control)this.pictureBox9);
            this.Controls.Add((Control)this.pictureBox8);
            this.Controls.Add((Control)this.pictureBox7);
            this.Controls.Add((Control)this.pictureBox6);
            this.Controls.Add((Control)this.pictureBox5);
            this.Controls.Add((Control)this.pictureBox4);
            this.Controls.Add((Control)this.pictureBox3);
            this.Controls.Add((Control)this.pictureBox2);
            this.Controls.Add((Control)this.statusStrip1);
            this.Controls.Add((Control)this.pictureBox1);
            this.Controls.Add((Control)this.textBox16);
            this.Controls.Add((Control)this.textBox15);
            this.Controls.Add((Control)this.textBox14);
            this.Controls.Add((Control)this.textBox13);
            this.Controls.Add((Control)this.textBox12);
            this.Controls.Add((Control)this.textBox11);
            this.Controls.Add((Control)this.textBox10);
            this.Controls.Add((Control)this.textBox9);
            this.Controls.Add((Control)this.textBox8);
            this.Controls.Add((Control)this.textBox7);
            this.Controls.Add((Control)this.textBox6);
            this.Controls.Add((Control)this.textBox5);
            this.Controls.Add((Control)this.textBox4);
            this.Controls.Add((Control)this.textBox3);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.radioButton16);
            this.Controls.Add((Control)this.radioButton15);
            this.Controls.Add((Control)this.radioButton14);
            this.Controls.Add((Control)this.radioButton13);
            this.Controls.Add((Control)this.radioButton12);
            this.Controls.Add((Control)this.radioButton11);
            this.Controls.Add((Control)this.radioButton10);
            this.Controls.Add((Control)this.radioButton9);
            this.Controls.Add((Control)this.radioButton8);
            this.Controls.Add((Control)this.radioButton7);
            this.Controls.Add((Control)this.radioButton6);
            this.Controls.Add((Control)this.radioButton5);
            this.Controls.Add((Control)this.radioButton4);
            this.Controls.Add((Control)this.radioButton3);
            this.Controls.Add((Control)this.radioButton2);
            this.Controls.Add((Control)this.radioButton1);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.groupBox1);
            this.Name = nameof(Form1);
            this.Text = "Presidents";
            this.groupBox1.ResumeLayout(false);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((ISupportInitialize)this.pictureBox2).EndInit();
            ((ISupportInitialize)this.pictureBox3).EndInit();
            ((ISupportInitialize)this.pictureBox4).EndInit();
            ((ISupportInitialize)this.pictureBox5).EndInit();
            ((ISupportInitialize)this.pictureBox6).EndInit();
            ((ISupportInitialize)this.pictureBox7).EndInit();
            ((ISupportInitialize)this.pictureBox8).EndInit();
            ((ISupportInitialize)this.pictureBox9).EndInit();
            ((ISupportInitialize)this.pictureBox10).EndInit();
            ((ISupportInitialize)this.pictureBox11).EndInit();
            ((ISupportInitialize)this.pictureBox12).EndInit();
            ((ISupportInitialize)this.pictureBox13).EndInit();
            ((ISupportInitialize)this.pictureBox14).EndInit();
            ((ISupportInitialize)this.pictureBox15).EndInit();
            ((ISupportInitialize)this.pictureBox16).EndInit();
            ((ISupportInitialize)this.errorProvider).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

