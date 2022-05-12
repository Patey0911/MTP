using System.ComponentModel;

namespace WindowsFormsApp2
{
    internal class Student
    {
        private string nume;
        private string facultate;
        private int an;
        private double medie;
        private string adresa;
        private string telefon;

        public Student(string nume, string facultate, int an, double medie, string adresa, string telefon)
        {
            this.Nume = nume;
            this.Facultate = facultate;
            this.An = an;
            this.Medie = medie;
            this.Adresa = adresa;
            this.Telefon = telefon;
        }

        [Description("Numele studentului"), Category("Date personale")]
        public string Nume { get => nume; set => nume = value; }

        [Description("Facultatea"), Category("Info studii")]
        public string Facultate { get => facultate; set => facultate = value; }

        [Description("Anul de studiu"), Category("Info studii")]
        public int An { get => an; set => an = value; }

        [Description("Media multianuala"), Category("Info studii"), Browsable(false)]
        public double Medie { get => medie; set => medie = value; }

        [Description("Adresa studentului"), Category("Date personale")]
        public string Adresa { get => adresa; set => adresa = value; }

        [Description("Telefonul studentului"), Category("Date personale")]
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
