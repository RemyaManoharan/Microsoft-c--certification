using System;


namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // ControlStructures.LearnIfElse();
            // InventoryArray.LearnArray();
            //    Excercise3.FraudFinder();
            // StudentGradingApp.StundentGradeFinder();
            //TypeConverter.SchoolData();
            //
            // FizzBuzz.FizzBuzzApp();
            //Animals.AnimalApp();
            //PetApp.PetAppManager();
            // Console.WriteLine("Hello World!");
            // MedidicneTime.MedicineApp();
           // Coins.FindCoins();

            string[] pettingZoo =
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            ContosoPettingZoo zoo = new ContosoPettingZoo();
            string[,] group = zoo.AssignGroup();
            string[] randomPets = zoo.RandomizeAnimals(pettingZoo);

            Console.WriteLine("School A");
          
        }
        }
    }




