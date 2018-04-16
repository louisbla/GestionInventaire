using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure
{
    public class Famille
    {
        private int refFamille;
        private String nom;

        public int RefFamille
        {
            get { return refFamille; }
            set { refFamille = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
