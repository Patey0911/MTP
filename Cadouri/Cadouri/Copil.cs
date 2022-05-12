using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadouri
{
    internal class Copil
    {
        private string nume, prenume, cnp, adresa, sex, data_nasterii, varsta;
        private DateTime data;
        [Description ("Nume"), Category ("Date Personale")]
        public string Nume { get { return nume; } }
        [Description("Prenume"), Category("Date Personale")]

        public string Prenume { get { return prenume; } }
        [Description("CNP"), Category("Date Personale")]

        public string Cnp { get { return cnp; } }
        [Description("Adresa"), Category("Date Personale")]

        public string Adresa { get { return adresa; } }
        [Description("Sex"), Category("Date Personale")]


        public string Sex { get { return sex; } set { sex = value; } }
        [Description("Data Inmanarii"), Category("Date Cadou")]

        public DateTime Data { get { return data; } set { data = value; } }

        public Copil(string nume, string prenume, string cnp, string adresa, DateTime data)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.adresa = adresa;
            this.data = data;
            if(cnp[0]%2==0)
            {
                sex = "F";
            }
            else
            {
                sex = "M";
            }
        }
    }
}
