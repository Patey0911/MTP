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
            Form2 f=new Form2();
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
            Form3 f=new Form3();
            f.ShowDialog();
            masuratoriTableAdapter.Insert(f.id_masurare, f.id_incapere, f.data_masurare, f.temperatura, f.umiditate, f.ITU);
            tableAdapterManager.UpdateAll(masurareDataSet);
            masuratoriTableAdapter.Fill(masurareDataSet.Masuratori);

            TreeNode childNode = new TreeNode();
            childNode.Name = f.id_masurare.ToString();
            childNode.Text = f.id_masurare.ToString();
            treeView1.Nodes[f.id_incapere.ToString()].Nodes.Add(childNode);


        }
    }
}
