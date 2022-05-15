using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_Incaper
{
    internal class Masuratoare
    {
        int id_incapere, id_masuratoare, temperatura, umiditate, itu;
        DateTime data;
        [Description("Camera"), Category("Camera")]
        public int id_Incapere
        { get { return id_incapere; } set { id_incapere = value;} }

        [Description("Masuratoare"), Category("Masuratoare")]
        public int ID_masuratoare
        { get { return id_masuratoare; } set { id_masuratoare = value;} }   
        [Description("Data"), Category("Masuratoare")]
        public DateTime Data
            { get { return data; } set { data = value; } }

        [Description("Temperatura"), Category("Masuratoare")]
        public int Temperatura
        { get { return temperatura; } set { temperatura = value; } }

        [Description("Umiditate"), Category("Masuratoare")]
        public int Umiditate
        { get { return umiditate; } set { umiditate = value; } }

        [Description("ITU"),  Category ("Masuratoare")]
        public int ITU
        { get { return itu; } set { itu = value; } }

        public Masuratoare(int id_incapere,int id_masuratoare,int temperatura, int umiditate, int itu, DateTime data)
        {
            this.id_incapere = id_incapere;
            this.id_masuratoare = id_masuratoare;
            this.temperatura = temperatura;
            this.umiditate = umiditate;
            this.itu = itu;
            this.data = data;
        }

    }
}
