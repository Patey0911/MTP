using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        bool ctrlPressed = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ctrlPressed)
            {
                textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string data = e.Data.GetData(DataFormats.Text).ToString();
            listBox1.Items.Add(data);
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            ctrlPressed = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrlPressed = false;
        }

        private void stergeTotToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void anuleazaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
