using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> lista = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Adauga_Click(object sender, EventArgs e)
        {
            byte[] n = new byte[5];
            try
            {
                n[0] = Convert.ToByte(Nota1.Text);
                n[1] = Convert.ToByte(Nota2.Text);
                n[2] = Convert.ToByte(Nota3.Text);
                n[3] = Convert.ToByte(Nota4.Text);
                n[4] = Convert.ToByte(Nota5.Text);

                Student s = new Student(Convert.ToByte(An.Text), n, Nume.Text, Convert.ToByte(Varsta.Value));
                lista.Add(s);
                AfisareLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AfisareLista()
        {
            listBox1.Items.Clear();
            foreach(Student s in lista)
            {
                listBox1.Items.Add(s.AfisareStudent());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComparaNume comp = new ComparaNume();
            lista.Sort(comp);
            AfisareLista();
        }

        private void OrdMedie_Click(object sender, EventArgs e)
        {
            ComparaMedie comp = new ComparaMedie();
            lista.Sort(comp);
            AfisareLista();
        }

        private void CautareNume_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nume;
            nume = SelectareNume.Text;
            foreach (Student s in lista)
            {
                if (s.NumeStudent == nume)
                    listBox1.Items.Add(s.AfisareStudent());
            }
        }

        private void AfisareStAn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            byte ancaut;
            ancaut = Convert.ToByte(SelectareStdAn.Text);
            foreach (Student s in lista)
            {
                if (s.AnStudiu == ancaut)
                    listBox1.Items.Add(s.AfisareStudent());
            }
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(1);
            AfisareLista();
        }
    }
}
