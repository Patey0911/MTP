using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Spital
{
    public partial class Form2 : Form
    {
        string nume, parola;
        string[] autentificare;
        string sep = ",";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            int k = 0, i = 0;
            nume = textBox1.Text;
            parola = textBox2.Text;
            string textFile = @"C:\Users\mihal\Desktop\MTP\Sql_Spital\Sql_Spital\Autentificare.txt";
            string[] lines = File.ReadAllLines(textFile);
            foreach (string line in lines)
            {
                autentificare = line.Split(sep.ToCharArray());
                if ((autentificare[0] == nume) && (autentificare[1] == parola))
                {
                    k = 1;
                }
            }
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 30;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            if (k == 0)
            {
                MessageBox.Show("Autentificare Esuata!!!");
            }
            else
            {
                this.Close();
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
