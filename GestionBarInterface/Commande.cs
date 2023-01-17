using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBarInterface
{
    public class Commande
    {
        int idCommande;
        int idDemande;
        int idEmploye;
        double prix;

        public Commande(int idCommande,
        int idDemande,
        int idEmploye,
        double prix)
        {
            this.idCommande = idCommande;
            this.idDemande = idDemande;
            this.idEmploye = idEmploye;
            this.prix = prix;
        }
    }
}
