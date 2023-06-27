using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_VS_Monsters
{
    public class grille
    {/*
      * Placer les 10  monstres espacés d’au moins de 2 cases (horizontale et verticale) les uns des autres.
      * Leur position est connue à la création.
      * */

        public static void initPlateau(string[,] plateau)
        {
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    plateau[i, j] = "■";
                }
            }

          
        } // ok

        public static void afficherGrille(string[,] plateau)
        {
            Console.Clear();
            Console.Write("   ");
            for (int j = 0; j < plateau.GetLength(1); j++)
            {
                Console.Write($"[{j + 1}]");
            }
            Console.WriteLine();
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                Console.Write($"[{i + 1}]");
                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    Console.Write($"[{plateau[i, j]}]");
                }
                Console.WriteLine();
            }
        } //ok

        public static int[] deplacement(char deplacement, string[,] plateau, ref int[] pos)
        {
            int x = pos[0] - 1;
            int y = pos[1] - 1;

            if (deplacement == 'z') // aller en haut
            {
                x = x - 1;
            }
            else if (deplacement == 's') //en bas
            {
                x = x + 1;
            }
            else if (deplacement == 'q')
            {
                y = y - 1;
            }
            else if (deplacement == 'd')
            {
                y = y + 1;
            }

            return new int[2] { x + 1, y + 1 };
        }


    }
}
