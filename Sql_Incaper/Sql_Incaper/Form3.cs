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
    public partial class Form3 : Form
    {
        public int id_incapere, id_masurare, temperatura, umiditate,ITU;
        public DateTime data_masurare;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_incapere = (int)numericUpDown1.Value;
            id_masurare = (int)numericUpDown2.Value;
            temperatura = (int)numericUpDown3.Value;
            umiditate = (int)numericUpDown4.Value;
            data_masurare = dateTimePicker1.Value;
            ITU = (int)((temperatura * 1.8 + 32) - (0.55 - 0.0055 * umiditate) * ((temperatura * 1.8 + 32) - 58));
            this.Close();
        }
    }
}
