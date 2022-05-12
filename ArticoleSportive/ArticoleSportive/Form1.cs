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

namespace ArticoleSportive
{
    public partial class Form1 : Form
    {
        List<Obiect> Lista_obiecte = new List<Obiect>();
        private string categorie, nume, producator;
        private int nr_inventar, pret, nr_bucati;
        private int nr_1=0, nr_2=0, nr_3=0, nr_4=0;

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\mihal\Desktop\MTP\ArticoleSportive\ArticoleSportive\"+comboBox1.Text+".txt";

            // The line below will create a text file, my_file.txt, in 
            // the Text_Files folder in D:\ drive.
            // The CreateText method that returns a StreamWriter object
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach(Obiect obiect in Lista_obiecte)
                {
                    if(obiect.Categorie.Contains(comboBox1.Text))
                    {
                        sw.WriteLine("Categorie: "+obiect.Categorie);
                        sw.WriteLine("Nume: "+obiect.Nume);
                        sw.WriteLine("Producator: "+obiect.Producator);
                        sw.WriteLine("Nr. inventar: "+obiect.Nr_inventar);
                        sw.WriteLine("Nr. bucati: "+obiect.Nr_bucati);
                        sw.WriteLine("Pret: "+obiect.Pret);
                        sw.WriteLine();
                    }
                }
            }
            path = @"C:\Users\mihal\Desktop\MTP\ArticoleSportive\ArticoleSportive\stoc.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Obiect obiect in Lista_obiecte)
                {
                    if (obiect.Categorie.Contains("fitness"))
                        nr_1 += obiect.Nr_inventar;
                    else if (obiect.Categorie.Contains("inot"))
                        nr_2 += obiect.Nr_inventar;
                    else if(obiect.Categorie.Contains("ciclism"))
                        nr_3+=obiect.Nr_inventar;
                    else
                        nr_4+=obiect.Nr_inventar;
                }
                sw.WriteLine(nr_1);
                sw.WriteLine(nr_2);
                sw.WriteLine(nr_3);
                sw.WriteLine(nr_4);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Obiect a in Lista_obiecte)
            {
                if(treeView1.SelectedNode.Text==a.Nume)
                {
                    propertyGrid1.SelectedObject = a;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            TreeNode parentNode1 = new TreeNode();
            parentNode1.Name = "parent_1";
            parentNode1.Text = "Imbracaminte Fitness";
            treeView1.Nodes.Add(parentNode1);

            TreeNode parentNode2 = new TreeNode();
            parentNode2.Name = "parent_2";
            parentNode2.Text = "Accesorii pentru inot";
            treeView1.Nodes.Add(parentNode2);

            TreeNode parentNode3 = new TreeNode();
            parentNode3.Name = "parent_3";
            parentNode3.Text = "Accesorii ciclism";
            treeView1.Nodes.Add(parentNode3);

            TreeNode parentNode4 = new TreeNode();
            parentNode4.Name = "parent_4";
            parentNode4.Text = "Incaltaminte";
            treeView1.Nodes.Add(parentNode4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categorie = comboBox1.Text;
            nume = textBox1.Text;
            producator = textBox2.Text;
            nr_inventar = (int)numericUpDown1.Value;
            pret = (int)numericUpDown2.Value;
            nr_bucati = (int)numericUpDown3.Value;

            Obiect a= new Obiect(categorie, nume, producator, nr_inventar,pret,nr_bucati);
            Lista_obiecte.Add(a);

            if(categorie.Contains("Imbracaminte"))
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = nume;
                treeNode.Text = nume;
                treeView1.Nodes["parent_1"].Nodes.Add(treeNode);
            }
            if (categorie.Contains("inot"))
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = nume;
                treeNode.Text = nume;
                treeView1.Nodes["parent_2"].Nodes.Add(treeNode);
            }
            if (categorie.Contains("ciclism"))
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = nume;
                treeNode.Text = nume;
                treeView1.Nodes["parent_3"].Nodes.Add(treeNode);
            }
            if (categorie.Contains("Incaltaminte"))
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = nume;
                treeNode.Text = nume;
                treeView1.Nodes["parent_4"].Nodes.Add(treeNode);
            }
        }
    }
}
