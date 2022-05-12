using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticoleSportive
{
    internal class Obiect
    {
        private string categorie, nume, producator;
        private int nr_inventar, pret, nr_bucati;
        public Obiect(string categorie, string nume, string producator, int nr_inventar, int pret, int nr_bucati)
        {
            this.categorie = categorie;
            this.nume = nume;
            this.producator = producator;
            this.nr_inventar = nr_inventar;
            this.pret = pret;
            this.nr_bucati = nr_bucati;
        }
        [Description ("Categorie"),Category("Informatii")]
        public string Categorie
            { get { return categorie; } }
        [Description("Nume"), Category("Informatii")]
        public string Nume { get { return nume; } }
        [Description("Producator"), Category("Informatii")]
        public string Producator { get { return producator; } }
        [Description("Nr_inventar"), Category("Informatii")]
        public int Nr_inventar { get { return nr_inventar; } }
        [Description("Nr_bucati"), Category("Informatii")]
        public int Nr_bucati { get { return nr_bucati; } }
        [Description("Pret"), Category("Informatii")]
        public int Pret { get { return pret; } }
    }
}
