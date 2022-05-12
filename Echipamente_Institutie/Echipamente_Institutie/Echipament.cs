using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echipamente_Institutie
{
    internal class Echipament
    {
        private int nr;
        private string model, producator, categorie, nume_persoana, cnp;
        [Description("Nr Inventar"), Category("Detalii echipament")]
        public int Nr { get { return nr; } }
        [Description("Model echipament"),Category("Detalii echipament")]
        public string Model { get { return model; } }
        [Description("Producator echipament"), Category("Detalii echipament")]
        public string Producator { get { return producator; } }
        [Description("Categorie"), Category("Detalii echipament")]
        public string Categorie { get { return categorie; } }
        [Description("Nume Persoana"), Category("Detalii persoana")]
        public string Nume_persoana { get { return nume_persoana; } }
        [Description("CNP"), Category("Detalii persoana")]
        public string Cnp { get { return cnp; } }

        public Echipament(int nr, string model, string producator, string categorie, string nume_persoana, string cnp)
        {
            this.nr = nr;
            this.model = model;
            this.producator = producator;
            this.categorie = categorie;
            this.nume_persoana = nume_persoana;
            this.cnp = cnp;
        }
    }
}
