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
        double prixHT;
        int quantite;

        public string Description { get => description; set => description = value; }
        public string RefArticle { get => refArticle; set => refArticle = value; }
        public string SousFamille { get => sousFamille; set => sousFamille = value; }
        public string Famille { get => famille; set => famille = value; }
        public string Marque { get => marque; set => marque = value; }
        public double PrixHT { get => prixHT; set => prixHT = value; }
        public int Quantite { get => quantite; set => quantite = value; }

    }
}
