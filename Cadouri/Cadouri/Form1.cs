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
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mihal\Desktop\MTP\Cadouri\Cadouri\Copii\" + dri.Name + "\\" + dri.Name + ".txt");
                

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
                    
                }
            }
        }
    }
}
