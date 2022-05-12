using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Button btn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn = new Button();
            btn.SetBounds(300, 50, 64, 24);
            btn.Text = "Buton";
            this.Controls.Add(btn);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn.Click += Btn_Click;
            button2.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click pe buton");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn.Click -= Btn_Click;
            btn.Click += Btn_Click1;
            button3.Enabled = false;
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Alt handler de eveniment");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn.Click += Btn_Click2;
            button4.Enabled = false;
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Inca un handler de eveniment");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn.Click -= Btn_Click1;
            btn.Click -= Btn_Click2;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(btn);
            btn.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Doriti sa inchideti fereastra?", "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
