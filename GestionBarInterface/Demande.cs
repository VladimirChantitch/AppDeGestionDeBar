using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBarInterface
{
    public class Demande
    {
        int idDemande;
        int idStock;
        int nombre;
        bool flagsup;

        public Demande(int idDemande,
        int idStock,
        int nombre,
        bool flagsup)
        {
            this.idDemande = idDemande;
            this.idStock = idStock;
            this.flagsup = flagsup;
            this.nombre = nombre;
        }
    }
}
