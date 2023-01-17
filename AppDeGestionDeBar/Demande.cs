
using system;

namespace bar
{
    public class Demande
    {
        int idDemande;
        int idStock;
        int nombre;
        bool flagsup;

        public Table(int idDemande,
        int idStock,
        int nombre,
        bool flagsup)
        {
            this.idDemande = idDemande;
            this.idStock =idStock;
            this.flagsup = flagsup;
            this.nombre = nombre;
        }
    }
}