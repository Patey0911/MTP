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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii");
            DirectoryInfo[] diArr = di.GetDirectories();
            foreach (DirectoryInfo dri in diArr)
            {
                listBox1.Items.Add(dri.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.ShowDialog();
            listBox1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii");
            DirectoryInfo[] diArr = di.GetDirectories();
            foreach (DirectoryInfo dri in diArr)
            {
                listBox1.Items.Add(dri.Name);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii");
            DirectoryInfo[] diArr = di.GetDirectories();
            foreach (DirectoryInfo dri in diArr)
            {
                if(dri.Name==listBox1.Items[listBox1.SelectedIndex].ToString())
                {
                    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + dri.Name + "\\" + dri.Name + ".txt");
                    string nume = lines[0];
                    string prenume = lines[1];
                    string cnp = lines[2];
                    string adresa = lines[3];
                    string data = lines[4];
                    Copil a = new Copil(nume, prenume, cnp, adresa, data);
                    propertyGrid1.SelectedObject = a;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii");
            DirectoryInfo[] diArr = di.GetDirectories();
            string path = @"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + listBox1.Items[listBox1.SelectedIndex].ToString() + "\\Cadou.txt";
            foreach (DirectoryInfo dri in diArr)
            {
                if (dri.Name == listBox1.Items[listBox1.SelectedIndex].ToString())
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(textBox1.Text+","+textBox2.Text+","+numericUpDown1.Value);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii");
            DirectoryInfo[] diArr = di.GetDirectories();
            string path = @"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + listBox1.Items[listBox1.SelectedIndex].ToString() + "\\Cadou.txt";
            foreach (DirectoryInfo dri in diArr)
            {
                if (dri.Name == listBox1.Items[listBox1.SelectedIndex].ToString())
                {
                    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + dri.Name + "\\Cadou.txt");
                    foreach (string line in lines)
                    {
                        listBox2.Items.Add(line);
                    }
                }
            }
        }
    }
}
