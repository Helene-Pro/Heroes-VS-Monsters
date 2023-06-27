using System;

namespace Heroes_VS_Monsters
{
    public class Des
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public void De(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public int LANCE_4D_6()
        {
            Random random = new Random();
            int sum = 0;
            List<int> liste_des = new List<int>();
            for (int i = 0; i <= 4; i++)
            {
                int roll = random.Next(Minimum, Maximum + 1);
                liste_des.Add(roll);
                List<int> troisPlusGrands = liste_des.OrderByDescending(x => x).Take(3).ToList();
                sum = troisPlusGrands.Sum();
            }
            return sum;
        }
        public int LANCE_1D_4()
        {
            Random random = new Random();
            int roll = random.Next(Minimum, Maximum + 1);
            return roll;
        }
    }
}
