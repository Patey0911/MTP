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
        private string nume, prenume, cnp, adresa, sex, data_nasterii, varsta,data;
        [Description ("Nume"), Category ("Date Personale")]
        public string Nume { get { return nume; } }
        [Description("Prenume"), Category("Date Personale")]

        public string Prenume { get { return prenume; } }
        [Description("CNP"), Category("Date Personale")]

        public string Cnp { get { return cnp; } }
        [Description("Adresa"), Category("Date Personale")]

        public string Adresa { get { return adresa; } }
        [Description("Data nasterii"), Category("Date Personale")]

        public string Data_nasterii { get { return data_nasterii; } set { data_nasterii = value; } }
        [Description("Varsta"),Category("Date Personale")]
        public string Varsta { get { return varsta; } set { varsta = value; } }
        [Description("Sex"), Category("Date Personale")]
        public string Sex { get { return sex; } set { sex = value; } }
        [Description("Data Inmanarii"), Category("Date Cadou")]

        public string Data { get { return data; } set { data = value; } }

        public Copil(string nume, string prenume, string cnp, string adresa, string data)
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
            if(Convert.ToInt32(cnp[1])==48)
            {
                data_nasterii = string.Concat( cnp[5],cnp[6],",",cnp[3],cnp[4],",20",cnp[1],cnp[2]);
            }
            else
            {
                data_nasterii = string.Concat(cnp[5], cnp[6], ",", cnp[3], cnp[4], ",19", cnp[1], cnp[2]);
            }
        }
    }
}
