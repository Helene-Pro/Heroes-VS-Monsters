using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters.Heros
{
    public class Humain : Hero
    {
        public Humain(string name, int end, int force, int pv, int x, int y) : base(name, end, force, pv, x,y)
        {
            For += 1;
            End += 1;
            int[] position = new int[2];
            char symbole = 'H';
        }
    
    }
}
