using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public struct Logo
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public ICollection<Produit> produits { get; set; }
        public Superette Superette { get; set; }    
    }
}
