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
        private string nume, prenume, cnp, adresa, sex, data_nasterii, varsta;
        private DateTime data;

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
            data = dateTimePicker1.Value;
            Copil a = new Copil(nume, prenume, cnp, adresa, data);
            string dir = @"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\"+nume;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                string path = @"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\"+nume+"\\"+nume+".txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Nume: "+a.Nume);
                    sw.WriteLine("Prenume: "+a.Prenume);
                    sw.WriteLine("CNP: "+a.Cnp);
                    sw.WriteLine("Adresa: "+a.Adresa);
                    sw.WriteLine("Data inmanarii: "+a.Data);
                    sw.WriteLine("Sex: " + a.Sex);
                }
            }
            else
            {

            }
            this.Close();
        }
    }
}
