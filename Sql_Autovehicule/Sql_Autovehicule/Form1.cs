using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Autovehicule
{
    public partial class Form1 : Form
    {
        int id1, id2, idauto, distanta, combustibil;
        DateTime data;
        string model, nr_inamtriculare,cnp;

        private void expeditiiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (expeditiiDataGridView.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (expeditiiDataGridView.CurrentCell != null && expeditiiDataGridView.CurrentCell.Value != null)
                    textBox3.Text = expeditiiDataGridView.CurrentCell.ColumnIndex.E
            }*/
            int combustibil, distanta;

            DbManager db = new DbManager();

            bool status = db.GetUsersData(ref combustibil, ref distanta);
            if (status)
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void autovehiculeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autovehiculeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autovehiculDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autovehiculDataSet.Expeditii' table. You can move, or remove it, as needed.
            this.expeditiiTableAdapter.Fill(this.autovehiculDataSet.Expeditii);
            // TODO: This line of code loads data into the 'autovehiculDataSet.Autovehicule' table. You can move, or remove it, as needed.
            this.autovehiculeTableAdapter.Fill(this.autovehiculDataSet.Autovehicule);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id2 =(int) numericUpDown2.Value;
            idauto =(int)numericUpDown3.Value;
            data = dateTimePicker1.Value;
            distanta =(int)numericUpDown4.Value;
            combustibil =(int)numericUpDown5.Value;
            cnp = textBox6.Text;
            if(cnp.Length!=13)
            {
                errorProvider1.SetError(textBox6, "CNP-ul nu are 13 cifre");
            }
            else
            {
                expeditiiTableAdapter.Insert(id2, idauto,data,distanta,combustibil,cnp);
                tableAdapterManager.UpdateAll(autovehiculDataSet);
                expeditiiTableAdapter.Fill(autovehiculDataSet.Expeditii);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id1 = (int)numericUpDown1.Value;
            model = textBox1.Text;
            nr_inamtriculare = textBox2.Text;
            autovehiculeTableAdapter.Insert(id1, model, nr_inamtriculare);
            tableAdapterManager.UpdateAll(autovehiculDataSet);
            autovehiculeTableAdapter.Fill(autovehiculDataSet.Autovehicule);
        }
    }
}
