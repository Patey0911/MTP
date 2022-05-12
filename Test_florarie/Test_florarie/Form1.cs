using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_florarie
{
    public partial class Form1 : Form
    {
        private List<Floare> lista = new List<Floare>();
        private double total_vanzari = 0;
        System.IO.StreamReader file = new System.IO.StreamReader("fisier_plante.txt");
        private string linie;
        public Form1()
        {
            InitializeComponent();
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Floare f = new Floare(dateTimePicker1.Value, comboBox1.Text, Convert.ToDouble(textBox2.Text), textBox1.Text);
            lista.Add(f);
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            foreach (Floare f in lista)
            {
                if (listBox1.SelectedItem.ToString() == f.Denumire)
                {
                    propertyGrid1.SelectedObject = f;
                    if (f.calculZile() >= 3)
                    {
                        if (f.Categorie == "Flori taiate")
                        {
                            MessageBox.Show("Floarea este ofilita!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
     
                        }

                        if (f.Categorie == "Plante in ghiveci")
                        {
                            if (MessageBox.Show("Floarea trebuie udata!!!\n Doriti sa o udati?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                f.Data = DateTime.Now;
                            }
                        }
                    }
                }
            }
        }

            private void button3_Click(object sender, EventArgs e)
            {
                listBox1.Items.Add("\n");
                foreach (Floare f in lista)
                {
                    if (string.Compare(f.Denumire, textBox3.Text) == 0)
                    {
                        listBox1.Items.Add(f.Denumire);
                    }
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                listBox1.SelectionMode = SelectionMode.One;
                if (this.listBox1.SelectedIndex >= 0)
                {
                    foreach (Floare f in lista)
                    {
                        if (listBox1.SelectedItem.ToString() == f.Denumire)
                        {
                            total_vanzari += f.Pret;
                            this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                            lista.Remove(f);
                            break;
                        }
                    }
                }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                textBox4.Clear();
                textBox4.AppendText(total_vanzari.ToString());
            }

        private void button2_Click(object sender, EventArgs e)
        {
            while ((linie = file.ReadLine()) != null)
            {
                String[] parts = linie.Split(';');

                Floare f = new Floare(Convert.ToDateTime(parts[1]), parts[2], Convert.ToDouble(parts[3]), parts[0]);
                lista.Add(f);
                listBox1.Items.Add(f.Denumire);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            if (log.ShowDialog() == DialogResult.Cancel)
                this.Close();
        }
    }
    }

