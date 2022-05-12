using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string selPath;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selPath = Path.Combine(Application.StartupPath, "..", "..");
            label1.Text = Path.GetFullPath(selPath);
            foreach (string filePath in Directory.GetFiles(selPath))
            {
                Button btn = new Button();
                btn.Width = flowLayoutPanel1.Width - 24;
                btn.Text = Path.GetFileName(filePath);
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string filePath = Path.Combine(selPath, btn.Text);

            using (StreamReader sr = new StreamReader(filePath))
            {
                textBox1.Text = sr.ReadToEnd();
            }
        }
    }
}
