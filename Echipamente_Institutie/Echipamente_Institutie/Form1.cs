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

namespace Echipamente_Institutie
{
    public partial class Form1 : Form
    {
        private int nr;
        private string model, producator, categorie, nume_persoana, cnp;
        string nume_ret;

        List<Echipament> lista = new List<Echipament>();
        public Form1()
        {
            InitializeComponent();
            string dir = @"C:\Users\mihal\Desktop\MTP\Echipamente_Institutie\Echipamente_Institutie\Salvare_Fisier\Calculator";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            dir = @"C:\Users\mihal\Desktop\MTP\Echipamente_Institutie\Echipamente_Institutie\Salvare_Fisier\Laptop";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            dir = @"C:\Users\mihal\Desktop\MTP\Echipamente_Institutie\Echipamente_Institutie\Salvare_Fisier\Imprimanta";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            dir = @"C:\Users\mihal\Desktop\MTP\Echipamente_Institutie\Echipamente_Institutie\Salvare_Fisier\Scaner";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nr = (int)numericUpDown1.Value;
            model = textBox1.Text;
            producator = textBox2.Text;
            categorie = comboBox1.Text;
            nume_persoana = textBox3.Text;
            cnp = textBox4.Text;
            if (cnp.Length == 13)
            {
                Echipament a = new Echipament(nr, model, producator, categorie, nume_persoana, cnp);
                lista.Add(a);
                Button btn = new Button();
                btn.Text = a.Model;
                btn.Width = 180;
                btn.Height = 30;
                //btn.Tag = Echipament;
                if (a.Categorie.Contains("Calculator"))
                    flowLayoutPanel1.Controls.Add(btn);
                if (a.Categorie.Contains("Laptop"))
                    flowLayoutPanel2.Controls.Add(btn);
                if (a.Categorie.Contains("Imprimanta"))
                    flowLayoutPanel3.Controls.Add(btn);
                if (a.Categorie.Contains("Scaner"))
                    flowLayoutPanel4.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            else
            {
                MessageBox.Show("CNP-ul nu are 13 cifre !!!");
                errorProvider1.SetError(textBox4, "CNP-ul nu are 13 cifre !!!");
            }
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Echipament j = (Echipament)btn.Tag;
            foreach (var echip in lista)
            {
                if(echip.Model==btn.Text)
                {
                    propertyGrid1.SelectedObject = echip;
                    nume_ret=echip.Model;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var echip in lista)
            {
                if (echip.Model == nume_ret)
                {
                    string path = @"C:\Users\mihal\Desktop\MTP\Echipamente_Institutie\Echipamente_Institutie\Salvare_Fisier\"+echip.Categorie+"\\"+echip.Model+".txt";
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Nr. Inventar: " + echip.Nr);
                        sw.WriteLine("Model echipament: " + echip.Model);
                        sw.WriteLine("Producator: " + echip.Producator);
                        sw.WriteLine("Producator: " + echip.Producator);
                        sw.WriteLine("Categorie: " + echip.Categorie);
                        sw.WriteLine("Nume Persoana: " + echip.Nume_persoana);
                        sw.WriteLine("CNP: " + echip.Cnp);
                    }
                }
            }
        }
    }
}
