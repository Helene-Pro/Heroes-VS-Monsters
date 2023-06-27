using Heroes_VS_Monsters.Heros;
using Heroes_VS_Monsters.Monstres;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Heroes_VS_Monsters
{
    public class Personnage
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int End { get; set; }
        public int For { get; set; }
        public int _hp { get; set; }
        public int max_Hp { get; }
        public string Name { get; set; }
        public int Cuir { get; set; }
        public int Or { get; set; }

        public bool IsDead
        {
            get
            {
                return _hp <= 0;
            }
        }
        public Personnage(string name, int end, int force, int pv, int x, int y)
        {
            End = end;
            For = force;
            _hp = pv;
            max_Hp = pv;
            Name = name;
            Cuir = 0;
            Or = 0;
            X = x;
            Y = y;

            // calcul endurance
            Des Ed = new Des();
            Ed.De(1, 6);
            End = Ed.LANCE_4D_6();

            //calcul force
            Des forc = new Des();
            forc.De(1, 4);
            For = forc.LANCE_4D_6();


            // PV
            // endurance + modificateur(endurance)
            // si endurance <5 on ajout -1
            //si endurance <10 on ajoute 0
            // si endurance <15 on ajoute +1
            // sinon on ajoute +2
            if (End < 5)
            {
                _hp -= 1;
                _hp += End;
                max_Hp = _hp;
            }
            else if (End < 10 && End > 5)
            {
                _hp += 0;
                _hp += End;
                max_Hp = _hp;
            }
            else if (End < 15 && End > 10)
            {
                _hp += 1;
                _hp += End;
                max_Hp = _hp;
            }
            else
            {
                _hp += 2;
                _hp += End;
                max_Hp = _hp;
            }

            Console.WriteLine($"{Name} a {End} d'endurance, {For} de force et {_hp} de PV");
            Console.WriteLine("-----------------------------------------------------------");
        }


        }
    }


   





     
