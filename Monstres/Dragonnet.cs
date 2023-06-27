using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Monstres
{
    public class Dragonnet : Monstre
    {
       

        private Random random = new Random();
        public Dragonnet(string name, int end, int force, int pv, int x, int y) : base(name, end, force, pv,x,y)
        {

            end += 1;
             Or = random.Next(0, 15);
             Cuir = random.Next(0, 15);
            int[] position = new int[2];
            char symbole = 'D';

        }
     

        //public List<Ressource> DropRessources() // Typé Classe Ressources
        //{
        //    List<Ressource> ressources = new List<Ressource>();

          
        //    ressources.Add(new Ressource { Type = "Or", Quantite = or });
        //    ressources.Add(new Ressource { Type = "Cuir", Quantite = cuir });

        //    return ressources;

        //}
    }
}
