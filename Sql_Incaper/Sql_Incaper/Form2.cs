using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Incaper
{
    public partial class Form2 : Form
    {
        public int id;
        public string nume_incapere;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = (int)numericUpDown1.Value;
            nume_incapere = textBox1.Text;
            this.Close();
        }
    }
}
