using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Spital
{
    public partial class Form1 : Form
    {
        int id, id_dep;
        string departament, adresa, nume, prenume, cnp, post;
        DateTime data_ang;
        public Form1()
        {
            Form2 f2=new Form2();
            f2.ShowDialog();
            InitializeComponent();
        }

        private void departament_BazaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departament_BazaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Sql_SpitalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Sql_SpitalDataSet.Personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this._Sql_SpitalDataSet.Personal);
            // TODO: This line of code loads data into the '_Sql_SpitalDataSet.Departament_Baza' table. You can move, or remove it, as needed.
            this.departament_BazaTableAdapter.Fill(this._Sql_SpitalDataSet.Departament_Baza);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = (int)numericUpDown1.Value;
            id_dep = (int)numericUpDown2.Value;
            nume = textBox4.Text;
            prenume = textBox3.Text;
            cnp = textBox5.Text;
            post = textBox6.Text;
            data_ang = dateTimePicker1.Value;
            personalTableAdapter.Insert(id,id_dep,nume,prenume,cnp,post,data_ang);
            tableAdapterManager.UpdateAll(_Sql_SpitalDataSet);
            personalTableAdapter.Fill(_Sql_SpitalDataSet.Personal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = (int)numericUpDown1.Value;
            departament = textBox1.Text;
            adresa = textBox1.Text;
            departament_BazaTableAdapter.Insert(id, departament, adresa);
            tableAdapterManager.UpdateAll(_Sql_SpitalDataSet);
            departament_BazaTableAdapter.Fill(_Sql_SpitalDataSet.Departament_Baza);
        }
    }
}
