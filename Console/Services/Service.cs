using Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Services
{
    public class Service
    {
        // Gets products where the price > 50
        public List<Cosmétique> GetProduitsByPrice(Superette superette)
        {
            //var rec = from p in superette.Produits
            //where p.Prix > 50
            //select p;

            //return rec.OfType<Cosmétique>().ToList();

            return superette.Produits.OfType<Cosmétique>().Where(p => p.Prix > 50).ToList();
        }

        // Get nbr Produits par logo
        public int GetProductsNbrByLogo(Logo logo)
        {
            return logo.produits.Count;
        }

        // Get logo by superette
        public int GetLogoNbrBySup(Superette superette)
        {
            return superette.Produits.Count;
        }

        // Returns the image of the logo of a of cosmétique of type perfum
        public string GetParfum(Superette superette)
        {
            return superette.Produits.OfType<Cosmétique>().Where(p => p.Type == TypeCos.Parfum).FirstOrDefault()?.Logo.Image;
        }

        //total des prix ali cos d'une supp

        public float GetAlimentairePrice(Superette superette)
        {
            float sum = 0.0f;

            foreach(Alimentaire a in superette.Produits.OfType<Alimentaire>())
            {
                sum += a.Prix;
            }
            
            return sum;
        }

        public float GetCosPrice(Superette superette)
        {
            float sum = 0.0f;

            foreach(Cosmétique a in superette.Produits.OfType<Cosmétique>())
            {
                sum += a.Prix;
            }

            return sum;
        }

        public float GetTotal(Superette superette)
        {
            return GetAlimentairePrice(superette) + GetCosPrice(superette);
        }
        public Superette IsExpired(Superette superette)
        {
            //foreach (var p in superette.Produits.OfType<Alimentaire>())
            //{
            //    if (p.DateExp < DateTime.Now)
            //    {
            //        return superette;
            //    }
            //}
            //return null;
            
            return superette.Produits.OfType<Alimentaire>().Where(p => p.DateExp < DateTime.Now) != null ? superette : null;
        }
    }
}
