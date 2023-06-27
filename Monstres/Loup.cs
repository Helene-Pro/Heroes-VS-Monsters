using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Monstres
{
    public class Loup : Monstre
    {

        public Random random = new Random();

        public Loup(string name, int end, int force, int pv, int x, int y) : base(name, end, force, pv, x,y)
        {

            Cuir = random.Next(0, 15);
            int[] position = new int[2];
            char symbole = 'L';

        }
 
        //public List<Ressource> Ressources() // Typé Classe Ressources 
        //{
        //    List<Ressource> ressources = new List<Ressource>();


        //    ressources.Add(new Ressource { Type = "Cuir", Quantite = cuir });

        //    return ressources;

        //}
    }
}
