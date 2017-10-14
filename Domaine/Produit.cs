using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public float Prix { get; set; }
        public string Marque { get; set; }
        public Superette Superette { get; set; }

        public Logo Logo { get; set; }


    }
}
