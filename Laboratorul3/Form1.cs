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

namespace MihalyBogdan_Matei
{
    public partial class Form1 : Form
    {
        string echipa_noua;
        public static string nume_echipa_selectata;
        public Form1()
        {
            InitializeComponent();
            Form4_Load();
            Init_Combobox();
        }

        public void Init_Combobox()
        {
            DirectoryInfo d = new DirectoryInfo("C:\\Users\\mihal\\Desktop\\MTP\\LPF");
            DirectoryInfo[] dirs = d.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                comboBox1.Items.Add(dir.Name);
                comboBox1.SelectedItem = dir.Name;
            }
        }

        public void Form4_Load()
        {
            Form4 f = new Form4();
            if (f.ShowDialog() == DialogResult.Cancel)
                f.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            comboBox1.Items.Add(Form2.nume_nou);
            comboBox1.SelectedItem = Form2.nume_nou;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nume_echipa_selectata = comboBox1.Text;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Button btn = new Button();
            btn.Text = Form3.fotbalist_nou.Nume;
            btn.Width = 200;
            btn.Tag = Form3.fotbalist_nou; // se atribuie un obiect de tip Jucator
            flowLayoutPanel1.Controls.Add(btn);
            btn.Click += Btn_Click;
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Jucator j = (Jucator)btn.Tag;

            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\mihal\\Desktop\\MTP\\LPF\\"+comboBox1.SelectedItem+"\\"+btn.Text+".lpf");

            textBox1.Text = lines[0];
            comboBox2.Text = lines[1];
            textBox3.Text = lines[2];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string rootpath = "C:\\Users\\mihal\\Desktop\\MTP\\LPF\\" + comboBox1.Text;

            DirectoryInfo d = new DirectoryInfo("C:\\Users\\mihal\\Desktop\\MTP\\LPF\\" + comboBox1.Text); 

            FileInfo[] dirs = d.GetFiles("*.lpf");

            foreach (FileInfo dir in dirs)
            {
                Button btn = new Button();
                btn.Text = dir.Name.Remove(dir.Name.Length-4);
                btn.Width = 200;
                btn.Tag = Form3.fotbalist_nou;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

 
    }
}
