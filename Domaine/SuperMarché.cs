using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Superette
    {
        public int Id { get; set; }
        public string Adresse { get; set; }
        public string Nom { get; set; }

        //public string NumTel { get; set; }

        private int x = 5;

        public int NumTel
        {
            get { return x; }
            set { x = value; }
        }

        public ICollection<Produit> Produits { get; set; }
        public Logo Logo { get; set; }



        public Superette()
        {
            this.Produits = new List<Produit>();
        }
    }
}
