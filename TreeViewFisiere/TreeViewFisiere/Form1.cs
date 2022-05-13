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

namespace TreeViewFisiere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            if (!File.Exists(filename))
            {
                errorProvider1.SetError(button1, "Nu exista calea!");
            }
            else
            {
                string readfile = File.ReadAllText(filename);
                richTextBox1.Text = readfile;
            }
        }
    }
}
