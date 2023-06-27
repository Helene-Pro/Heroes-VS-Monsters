using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Heros
{
    public class Nain : Hero
    {
        public Nain(string name, int end, int force, int pv, int x, int y) : base(name, end, force, pv,x,y)
        {
            End += 2;
            int[] position = new int[2];
            char symbole = 'H';
        }
 
    }
}
