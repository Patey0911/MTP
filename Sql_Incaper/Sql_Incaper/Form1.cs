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
    public partial class Form1 : Form
    {
        int id_incapere, id_masuratoare, temperatura, umiditate, itu;
        DateTime data;
        public Form1()
        {
            InitializeComponent();
        }

        private void incapereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incapereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masurareDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masurareDataSet.Masuratori' table. You can move, or remove it, as needed.
            this.masuratoriTableAdapter.Fill(this.masurareDataSet.Masuratori);
            // TODO: This line of code loads data into the 'masurareDataSet.Incapere' table. You can move, or remove it, as needed.
            this.incapereTableAdapter.Fill(this.masurareDataSet.Incapere);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            incapereTableAdapter.Insert(f.id, f.nume_incapere);
            // Salvarea datelor
            tableAdapterManager.UpdateAll(masurareDataSet);
            // Reincarcarea datelor
            incapereTableAdapter.Fill(masurareDataSet.Incapere);

            TreeNode parentNode = new TreeNode();
            parentNode.Name = f.id.ToString();
            parentNode.Text = f.nume_incapere;
            treeView1.Nodes.Add(parentNode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            masuratoriTableAdapter.Insert(f.id_masurare, f.id_incapere, f.data_masurare, f.temperatura, f.umiditate, f.ITU);
            tableAdapterManager.UpdateAll(masurareDataSet);
            masuratoriTableAdapter.Fill(masurareDataSet.Masuratori);

            TreeNode childNode = new TreeNode();
            childNode.Name = f.id_masurare.ToString();
            childNode.Text = f.id_masurare.ToString();
            treeView1.Nodes[f.id_incapere.ToString()].Nodes.Add(childNode);


        }

        private void incapereDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBox1.Items.Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = incapereDataGridView.Rows[e.RowIndex];
                //listBox1.Items.Add(row.Cells[0].Value.ToString());
                //listBox1.Items.Add(row.Cells[1].Value.ToString());
                foreach (DataRowView drv in masuratoriBindingSource.List)
                {
                    if (row.Cells[0].Value.ToString() == drv["Id_incapere"].ToString())
                    {
                        listBox1.Items.Add("Id masurare: " + drv["Id_masurare"]);
                        listBox1.Items.Add("Id incapere: " + drv["Id_incapere"]);
                        listBox1.Items.Add("Data: " + drv["Data"]);
                        listBox1.Items.Add("Temperatura: " + drv["Temperatura"]);
                        listBox1.Items.Add("Umiditate" + drv["Umiditate"]);
                        listBox1.Items.Add("ITU: " + drv["ITU"]);
                        listBox1.Items.Add("\n");
                    }
                }
            }

        }

        private void masuratoriDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = masuratoriDataGridView.Rows[e.RowIndex];
                id_masuratoare = (int)row.Cells[0].Value;
                id_incapere = (int)row.Cells[1].Value;
                data = (DateTime)row.Cells[2].Value;
                temperatura = (int)row.Cells[3].Value;
                umiditate = (int)row.Cells[4].Value;
                itu = (int)row.Cells[5].Value;
                Masuratoare a = new Masuratoare(id_incapere, id_masuratoare, temperatura, umiditate, itu, data);
                propertyGrid1.SelectedObject = a;
            }
        }
    }
}
