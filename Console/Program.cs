using Domaine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Console.Services;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Superette s = new Superette
            {
                Id = 1,
                Adresse = "Ghazela",
                Nom = "Chez Souhail",
                NumTel = 007,
                Logo = new Logo
                {
                    Image = "img1",
                    Description = "description"
                }
            };

            Alimentaire a1 = new Alimentaire
            {
                Id = 1,
                Marque = "Délice",
                Nom = "Lait",
                Prix = 35,
                Logo = new Logo
                {
                    Image = "lait1",
                    Description = "lait"
                },
                DateExp = DateTime.Now
            };

            Alimentaire a2 = new Alimentaire
            {
                Id = 2,
                Marque = "Délice",
                Nom = "Délio",
                Prix = 67,
                Logo = new Logo
                {
                    Image = "lait1",
                    Description = "lait"
                },
                DateExp = DateTime.Now
            };

            Alimentaire a3 = new Alimentaire
            {
                Id = 3,
                Marque = "Délice",
                Nom = "Yaourt",
                Prix = 88,
                Logo = new Logo
                {
                    Image = "lait1",
                    Description = "lait"
                },
                DateExp = DateTime.Now
            };

            Cosmétique c1 = new Cosmétique
            {
                Id = 5,
                Marque = "c1",
                Nom = "c1",
                Prix = 300,
                Type = TypeCos.Parfum
            };

            // Affectation à une liste
            s.Produits.Add(a1);
            s.Produits.Add(a2);
            s.Produits.Add(a3);
            s.Produits.Add(c1);

            // if p>50 => afficher
            // Avec foreach
            //foreach(Produit p in s.Produits)
            //{
            //    if(p.Prix > 50)
            //    {
            //        System.Console.WriteLine(p.Afficher());
            //    }
            //}

            // Avec Lambda exp
            //var list = s.Produits.Where(p => p.Prix > 50 
            //                         && p.Marque == "Délice");

            // Afficher la marque du premier produit 
            //System.Console.WriteLine(list.FirstOrDefault().Marque);

            // Avec Linq
            //var l = from p in s.Produits
            //where p.Prix > 50 && p.Marque == "Délice"
            //select p;


            // if produit of type gel and prix > 50
            //var gels = from item in s.Produits.OfType<Cosmétique>()
            //where item.Prix > 50 && item.Type == TypeCos.Gel
            //select item;

            //foreach(Cosmétique c in gels)
            //{
            //    System.Console.WriteLine(c.Afficher());
            //}

            //List<float> ListePrix = new List<float>
            //{
            //    a1.Prix, a2.Prix, a3.Prix, c1.Prix
            //};

            //List<float> ListePrix = new List<float>();

            //foreach (Produit p in s.Produits)
            //{
            //    ListePrix.Add(p.Prix);
            //}

            //// Pour ordonner la liste asc
            //ListePrix.Sort();
            //// Pour la rendre ordonnée en dsc
            //ListePrix.Reverse();

            //foreach(float p in ListePrix)
            //{
            //    System.Console.WriteLine(p);
            //}

            //foreach(Produit p in list)
            //{
            //    System.Console.WriteLine(p.Afficher());
            //}


            //Service services = new Service();
            //System.Console.WriteLine(services.GetParfum(s));

            //var res = services.GetProduitsByPrice(s);
            //foreach (var p in res)
            //{
            //    System.Console.WriteLine(p.Nom);
            //}

            a1.Prix = float.Parse(System.Console.ReadLine());
            
            try
            {
                if (a1.Prix < 0)
                {
                    throw new PrixException(a1.Nom);
                }
            }
            catch(PrixException ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            
            System.Console.ReadKey();
        }
    }
}
