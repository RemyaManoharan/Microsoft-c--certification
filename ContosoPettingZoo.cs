using System;


namespace TestProject
{
    public class ContosoPettingZoo
    {

        // RandomizeAnimals();
        public string[] RandomizeAnimals(string[] pettingZoo)
        {
            Random random = new Random();

            for (int i = 0; i < pettingZoo.Length; i++)
            {
                int r = random.Next(i, pettingZoo.Length);

                string temp = pettingZoo[r];
                pettingZoo[r] = pettingZoo[i];
                pettingZoo[i] = temp;
            }

            return pettingZoo;
        }
        // AssignGroup();
        public  string[,] AssignGroup()
        {
            return null;
        }

    }
}