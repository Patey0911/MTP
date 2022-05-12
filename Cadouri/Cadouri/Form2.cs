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

namespace Cadouri
{
    public partial class Form2 : Form
    {
        private string nume, prenume, cnp, adresa, sex, data_nasterii, varsta, data;

    public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            prenume = textBox2.Text;
            cnp = textBox3.Text;
            adresa = textBox4.Text;
            data = dateTimePicker1.Value.ToString();
            if (cnp.Length == 13)
            {
                Copil a = new Copil(nume, prenume, cnp, adresa, data);
                string dir = @"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + nume;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                    string path = @"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + nume + "\\" + nume + ".txt";
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(a.Nume);
                        sw.WriteLine(a.Prenume);
                        sw.WriteLine(a.Cnp);
                        sw.WriteLine(a.Adresa);
                        sw.WriteLine(a.Data);
                        sw.WriteLine(a.Sex);
                        sw.WriteLine(a.Data_nasterii);
                        this.Close();
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Numele exista!");
                    MessageBox.Show("Numele Exista");
                }
            }
            else
            {
                errorProvider2.SetError(textBox3, "CNP-ul nu are 13 cifre!!!");
                MessageBox.Show("CNP-ul nu are 13 cifre!!!")
            }
        }
    }
}
