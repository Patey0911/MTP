using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_florarie
{
    class Floare : Planta
    {
        private DateTime data;
        private string categorie;
        private double pret;

        public Floare (DateTime data, string categorie, double pret, string denumire) : base (denumire)
        {
            this.data = data;
            this.categorie = categorie;
            this.pret = pret;
        }

        [Description("Denumirea plantei"), Category("Informatii")]
        public string Denumire
        {
            get { return denumire; }
        }

        [Description("Data in care planta a fost adaugata, respectiv cand a fost udata"), Category("Informatii")]
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        [Description("Categoria din care planta face parte"), Category("Informatii")]
        public string Categorie
        {
            get { return categorie; }
        }

        [Description("Pretul la care va fi vanduta planta"), Category ("Informatii")]

        public double Pret
        {
            get { return pret; }
        }

        public int calculZile()
        {
            int zile = 0;
            zile = DateTime.Now.DayOfYear - data.DayOfYear;
            return zile;
        }
        public String afisareFloare()
        {
            return denumire + " " + data + " " + " " + pret + " " + categorie;
        }
    }
}
