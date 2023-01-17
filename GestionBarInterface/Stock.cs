using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBarInterface
{
    public class Stock
    {
        int id;
        string libelle;
        double volume;
        double prix;

        public Stock(int id, string libelle, double volume, double prix)
        {
            this.id = id;
            this.libelle = libelle;
            this.volume = volume;
            this.prix = prix;
        }
    }
}
