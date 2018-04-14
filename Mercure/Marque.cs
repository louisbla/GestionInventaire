using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure
{
    public class Marque
    {
        private int refMarque;
        private String nom;

        public int RefMarque
        {
            get { return refMarque; }
            set { refMarque = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
