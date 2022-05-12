using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihalyBogdan_Matei
{
    public partial class Form3 : Form
    {
        List<Jucator> lista_jucatori = new List<Jucator>();
        public static Jucator fotbalist_nou;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pozitie_teren = (Poz)Enum.Parse(typeof(Poz), comboBoxPost.SelectedIndex.ToString());
            fotbalist_nou = new Jucator(textBox1.Text, pozitie_teren, textBox2.Text);
            lista_jucatori.Add(fotbalist_nou);
            string fileName = "C:\\Users\\mihal\\Desktop\\MTP\\LPF\\" + Form1.nume_echipa_selectata+"\\" + textBox1.Text+".lpf";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(fotbalist_nou.Nume);
                sw.WriteLine(fotbalist_nou.Post);
                sw.WriteLine(fotbalist_nou.cnp);
                sw.WriteLine();
            }
  
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            this.Close();
        }
    }
}
