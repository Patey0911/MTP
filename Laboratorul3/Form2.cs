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
    public partial class Form2 : Form
    {
        public static string nume_nou;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume_nou = textBoxEchipaNoua.Text;
            Directory.CreateDirectory("C:\\Users\\mihal\\Desktop\\MTP\\LPF\\"+textBoxEchipaNoua.Text);
            this.Close();
        }
    }
}
