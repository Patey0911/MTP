
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Varsta = new System.Windows.Forms.NumericUpDown();
            this.An = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nota1 = new System.Windows.Forms.ComboBox();
            this.Nota2 = new System.Windows.Forms.ComboBox();
            this.Nota3 = new System.Windows.Forms.ComboBox();
            this.Nota4 = new System.Windows.Forms.ComboBox();
            this.Nota5 = new System.Windows.Forms.ComboBox();
            this.Adauga = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectareNume = new System.Windows.Forms.TextBox();
            this.CautareNume = new System.Windows.Forms.Button();
            this.SelectareStdAn = new System.Windows.Forms.ComboBox();
            this.AfisareStAn = new System.Windows.Forms.Button();
            this.OrdMedie = new System.Windows.Forms.Button();
            this.OrdNume = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Varsta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(228, 106);
            this.Nume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(132, 22);
            this.Nume.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(157, 148);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 17);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Varsta";
            // 
            // Varsta
            // 
            this.Varsta.Location = new System.Drawing.Point(228, 145);
            this.Varsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Varsta.Name = "Varsta";
            this.Varsta.Size = new System.Drawing.Size(57, 22);
            this.Varsta.TabIndex = 3;
            // 
            // An
            // 
            this.An.FormattingEnabled = true;
            this.An.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.An.Location = new System.Drawing.Point(228, 188);
            this.An.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.An.Name = "An";
            this.An.Size = new System.Drawing.Size(56, 24);
            this.An.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note";
            // 
            // Nota1
            // 
            this.Nota1.FormattingEnabled = true;
            this.Nota1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Nota1.Location = new System.Drawing.Point(228, 230);
            this.Nota1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(56, 24);
            this.Nota1.TabIndex = 7;
            // 
            // Nota2
            // 
            this.Nota2.FormattingEnabled = true;
            this.Nota2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Nota2.Location = new System.Drawing.Point(293, 230);
            this.Nota2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(56, 24);
            this.Nota2.TabIndex = 8;
            // 
            // Nota3
            // 
            this.Nota3.FormattingEnabled = true;
            this.Nota3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Nota3.Location = new System.Drawing.Point(359, 230);
            this.Nota3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(56, 24);
            this.Nota3.TabIndex = 9;
            // 
            // Nota4
            // 
            this.Nota4.FormattingEnabled = true;
            this.Nota4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Nota4.Location = new System.Drawing.Point(424, 230);
            this.Nota4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(56, 24);
            this.Nota4.TabIndex = 10;
            // 
            // Nota5
            // 
            this.Nota5.FormattingEnabled = true;
            this.Nota5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Nota5.Location = new System.Drawing.Point(489, 230);
            this.Nota5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nota5.Name = "Nota5";
            this.Nota5.Size = new System.Drawing.Size(56, 24);
            this.Nota5.TabIndex = 11;
            // 
            // Adauga
            // 
            this.Adauga.Location = new System.Drawing.Point(228, 281);
            this.Adauga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(319, 28);
            this.Adauga.TabIndex = 12;
            this.Adauga.Text = "Adauga";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(664, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 292);
            this.listBox1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectareNume);
            this.groupBox1.Controls.Add(this.CautareNume);
            this.groupBox1.Controls.Add(this.SelectareStdAn);
            this.groupBox1.Controls.Add(this.AfisareStAn);
            this.groupBox1.Controls.Add(this.OrdMedie);
            this.groupBox1.Controls.Add(this.OrdNume);
            this.groupBox1.Location = new System.Drawing.Point(228, 338);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(400, 164);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afisare";
            // 
            // SelectareNume
            // 
            this.SelectareNume.Location = new System.Drawing.Point(236, 128);
            this.SelectareNume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectareNume.Name = "SelectareNume";
            this.SelectareNume.Size = new System.Drawing.Size(132, 22);
            this.SelectareNume.TabIndex = 7;
            // 
            // CautareNume
            // 
            this.CautareNume.Location = new System.Drawing.Point(8, 128);
            this.CautareNume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CautareNume.Name = "CautareNume";
            this.CautareNume.Size = new System.Drawing.Size(220, 28);
            this.CautareNume.TabIndex = 6;
            this.CautareNume.Text = "Cautare dupa nume";
            this.CautareNume.UseVisualStyleBackColor = true;
            // 
            // SelectareStdAn
            // 
            this.SelectareStdAn.FormattingEnabled = true;
            this.SelectareStdAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.SelectareStdAn.Location = new System.Drawing.Point(236, 95);
            this.SelectareStdAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectareStdAn.Name = "SelectareStdAn";
            this.SelectareStdAn.Size = new System.Drawing.Size(56, 24);
            this.SelectareStdAn.TabIndex = 5;
            // 
            // AfisareStAn
            // 
            this.AfisareStAn.Location = new System.Drawing.Point(8, 95);
            this.AfisareStAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AfisareStAn.Name = "AfisareStAn";
            this.AfisareStAn.Size = new System.Drawing.Size(220, 28);
            this.AfisareStAn.TabIndex = 2;
            this.AfisareStAn.Text = "Afisarea studentilor din anul";
            this.AfisareStAn.UseVisualStyleBackColor = true;
            this.AfisareStAn.Click += new System.EventHandler(this.AfisareStAn_Click);
            // 
            // OrdMedie
            // 
            this.OrdMedie.Location = new System.Drawing.Point(8, 59);
            this.OrdMedie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdMedie.Name = "OrdMedie";
            this.OrdMedie.Size = new System.Drawing.Size(220, 28);
            this.OrdMedie.TabIndex = 1;
            this.OrdMedie.Text = "Ordonare dupa medie";
            this.OrdMedie.UseVisualStyleBackColor = true;
            this.OrdMedie.Click += new System.EventHandler(this.OrdMedie_Click);
            // 
            // OrdNume
            // 
            this.OrdNume.Location = new System.Drawing.Point(8, 23);
            this.OrdNume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdNume.Name = "OrdNume";
            this.OrdNume.Size = new System.Drawing.Size(220, 28);
            this.OrdNume.TabIndex = 0;
            this.OrdNume.Text = "Ordonare dupa nume";
            this.OrdNume.UseVisualStyleBackColor = true;
            this.OrdNume.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(771, 474);
            this.Sterge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(220, 28);
            this.Sterge.TabIndex = 15;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.Nota5);
            this.Controls.Add(this.Nota4);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.An);
            this.Controls.Add(this.Varsta);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Varsta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.NumericUpDown Varsta;
        private System.Windows.Forms.ComboBox An;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Nota1;
        private System.Windows.Forms.ComboBox Nota2;
        private System.Windows.Forms.ComboBox Nota3;
        private System.Windows.Forms.ComboBox Nota4;
        private System.Windows.Forms.ComboBox Nota5;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OrdNume;
        private System.Windows.Forms.TextBox SelectareNume;
        private System.Windows.Forms.Button CautareNume;
        private System.Windows.Forms.ComboBox SelectareStdAn;
        private System.Windows.Forms.Button AfisareStAn;
        private System.Windows.Forms.Button OrdMedie;
        private System.Windows.Forms.Button Sterge;
    }
}

