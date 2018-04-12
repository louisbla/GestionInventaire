using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure
{
    class Article
    {
        String refArticle;
        String description;
        String sousFamille;
        String famille;
        String marque;
        float prixHT;
        int quantite;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string RefArticle
        {
            get { return refArticle; }
            set { refArticle = value; }
        }
        public string SousFamille
        {
            get { return sousFamille; }
            set { sousFamille = value; }
        }
        public string Famille
        {
            get { return famille; }
            set { famille = value; }
        }
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        public float PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
    }
}
