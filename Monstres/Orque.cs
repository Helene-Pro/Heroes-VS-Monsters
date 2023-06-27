using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Monstres
{
    public class Orque : Monstre
    {
     
        private Random random = new Random();

        public Orque(string name, int end, int force, int pv, int x, int y) : base(name, end, force, pv,x,y)
        {
            force += 1;
            Or = random.Next(0, 15);
            int[] position = new int[2];
            char symbole = 'O';

        }

        //public List<Ressource> DropRessources() // Typé Classe Ressources 
        //{
        //    List<Ressource> ressources = new List<Ressource>();



        //    ressources.Add(new Ressource { Type = "Or", Quantite = or });

        //    return ressources;
        //}
    }
}
