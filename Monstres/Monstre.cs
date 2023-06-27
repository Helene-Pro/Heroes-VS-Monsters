using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Monstres
{
    public class Monstre : Personnage
    {
       
        public Monstre(string name, int end, int force, int pv, int x, int y) : base(name, end, force, pv, x,y)
        {
        }
        //public class Ressource
        //{
        //    public string Type { get; set; }
        //    public int Quantite { get; set; }

        //    public Ressource(string type, int quantite)
        //    {
        //        Type = type;
        //        Quantite = quantite;
        //    }
        //}




    }
}
