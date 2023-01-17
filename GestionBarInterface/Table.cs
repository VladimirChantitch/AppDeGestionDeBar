using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBarInterface
{
    namespace bar
    {
        public class Table
        {
            int id;
            string libelle;

            public Table(int id, string libelle)
            {
                this.id = id;
                this.libelle = libelle;
            }
        }
    }
}
