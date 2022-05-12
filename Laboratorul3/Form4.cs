using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihalyBogdan_Matei
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Form4_Load();
        }

        public void Form4_Load()
        {
            //timer1.Enabled = true;
            timer1.Start();
            //timer1.Tick += new EventHandler(timer1_Tick);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            if(progressBar1.Value==progressBar1.Maximum)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            //timer1.Start();
            //timer1.Tick += new EventHandler(timer1_Tick);
            this.Close();
        }

    }
}
