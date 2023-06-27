using Heroes_VS_Monsters.Heros;
using Heroes_VS_Monsters.Monstres;
using System;
using System.Collections.Generic;

namespace Heroes_VS_Monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random HeroRandom = new Random();

            // Heroes
            Humain Bonhomme = new Humain("Bonhomme", 0, 0, 0, 0, 0);
            Nain Simplet = new Nain("Simplet", 0, 0, 0, 0, 0);

            List<Hero> heroes = new List<Hero>();
            heroes.Add(Bonhomme);
            heroes.Add(Simplet);

            int indexhero = HeroRandom.Next(0, heroes.Count);
            Hero HeroCombat = heroes[indexhero];

            // Monsters
            Random MonstreRandom = new Random();
            List<Monstre> monsters = new List<Monstre>();
            monsters.Add(new Dragonnet("Chouchou", 0, 0, 0, 0, 0));
            monsters.Add(new Orque("Mama", 0, 0, 0, 0, 0));
            monsters.Add(new Loup("Clebard", 0, 0, 0, 0, 0));
            monsters.Add(new Dragonnet("JCP", 0, 0, 0, 0, 0));
            monsters.Add(new Orque("Nonplus", 0, 0, 0, 0, 0));
            monsters.Add(new Loup("Ahouuuuu", 0, 0, 0, 0, 0));
            monsters.Add(new Loup("JDG", 0, 0, 0, 0, 0));
            monsters.Add(new Dragonnet("Croqmo", 0, 0, 0, 0, 0));
            monsters.Add(new Orque("Pabo", 0, 0, 0, 0, 0));
            monsters.Add(new Loup("CrocBlanc", 0, 0, 0, 0, 0));

            Combat combat = new Combat();
            Monstre MonstreCombat = monsters[MonstreRandom.Next(0, monsters.Count)];

            int i = 0;
            Console.WriteLine($"Monstre n°{i + 1}");
            while (i < 10)
            {

                combat.Combats(MonstreCombat, HeroCombat);
                combat.Combats(HeroCombat, MonstreCombat);

                if (MonstreCombat.IsDead)
                {
                    monsters.Remove(MonstreCombat);
                    MonstreCombat = monsters[MonstreRandom.Next(0, monsters.Count)];
                    i += 1;
                    Console.WriteLine("_______________________________________________________");
                    Console.WriteLine("Monstre vaincu !!");
                    Console.WriteLine("_______________________________________________________");
                    Console.WriteLine($"Monstre n°{i + 1}");
                }

                else if (HeroCombat.IsDead)
                {
                    Console.WriteLine("_______________________________________________________");
                    Console.WriteLine("Game Over les héros ont échoués");
                    Console.WriteLine("_______________________________________________________");
                    i = 11;
                }
            }






            //plateau
            //int x = 15;
            //int y = 15;
            //int[] position = new int[2];

            //string[,] plateau = new string[x, y];
            //grille.initPlateau(plateau); // plateau de départ
            //grille.afficherGrille(plateau);

            //while (true)
            //{
            //    Console.WriteLine($"Appuyer sur une touche pour déplacer le personnage:");
            //    char touche = Console.ReadKey().KeyChar;

            //    int[] nouvellePosition = grille.deplacement(touche, plateau, ref position);

                //    if (nouvellePosition[0] >= 0 && nouvellePosition[0] < plateau.GetLength(0) && nouvellePosition[1] >= 0 && nouvellePosition[1] < plateau.GetLength(1))
                //    {
                //        if (MonstreCombat = Orque)
                //        {
                //            plateau[position[0], position[1]] = "■";
                //            position = nouvellePosition;
                //            plateau[position[0], position[1]] = "S";
                //            grille.afficherGrille(plateau);
                //        }

                //    }
                //    else
                //    {
                //        Console.WriteLine("Déplacement impossible !");
                //    }
                //}

            //}
        }
    }
}
