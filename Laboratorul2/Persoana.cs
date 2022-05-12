using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul2
{
    class Persoana
    {
        string nume,telefon,adresa,categorie;
        DateTime data;
        Persoana(string Nume, string Telefon, string Adresa, string Categorie, DateTime Data)
        {
            nume = Nume;
            telefon = Telefon;
            adresa = Adresa;
            categorie = Categorie;
            data = Data;
        }
    }
}
