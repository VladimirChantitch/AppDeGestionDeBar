using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBarInterface
{
    public class Employe
    {
        int id;
        string nom;
        double salaire;
        string prenom;
        int role;

        public Employe(int id, string nom, double salaire, string prenom, int role)
        {
            this.id = id;
            this.nom = nom;
            this.salaire = salaire;
            this.prenom = prenom;
            this.type = role;
        }
    }
}
