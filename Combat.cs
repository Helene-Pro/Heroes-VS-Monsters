using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Heroes_VS_Monsters
{
    public class Combat
    {
        public int End { get; set; }
        public int For { get; set; }
        public int _hp { get; set; }
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
        public void Combats(Personnage Attaquant, Personnage Cible)
        {
            Personnage temp = Attaquant;
            Attaquant = Cible;
            Cible = temp;
            //calcul des degats lors d'un fight
            int degats;
            Des degat = new Des();
            degat.De(1, 4);
            degats = degat.LANCE_1D_4(); // dégat pur

            if (!Attaquant.IsDead && !Cible.IsDead)// tant que le perso n'est pas mort, ok pour taper, sinon peut pas taper
            {
                if (For < 5)
                {
                    degats -= 1;
                }
                else if (For < 10 && For > 5)
                {
                    degats += 0;
                }
                else if (For < 15 && For > 10)
                {
                    degats += 1;
                }
                else
                {
                    degats += 2;
                }
                Cible._hp -= degats;

                if (Cible._hp <= 0)
                {
                    Cible._hp = 0;
                    Console.WriteLine($"{Attaquant.Name} attaque {Cible.Name}"
                + $" lui infligeant {degats} points de degat et le laissant à {Cible._hp} points de vie.");
                    Console.WriteLine(" ");
                    Console.WriteLine($"{Cible.Name} est mort.");
                    Or += Cible.Or;
                    Cuir += Cible.Cuir;
                    Console.WriteLine($"Tuer {Cible.Name} a rapporté à {Attaquant.Name} {Cuir} cuirs et {Or} or. ");
                    Console.WriteLine(" ");

                    // Soin
                    Attaquant._hp = Attaquant.max_Hp;
                    int recup = Attaquant.max_Hp - _hp;
                    Console.WriteLine($"{Attaquant.Name} a récupéré {recup} HP");
                }
                else
                {
                    Console.WriteLine($"{Attaquant.Name} attaque {Cible.Name}"
                + $" lui infligeant {degats} points de degat et le laissant à {Cible._hp} points de vie.");


                }

            }



            }
        }

    }

