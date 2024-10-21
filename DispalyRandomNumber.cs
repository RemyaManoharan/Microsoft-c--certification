using System;
namespace TestProject
{
    public class DispalyRandomNumber
    {
        public static void DispalyRandomNumberApp()
        {
            Random rand = new Random();
            int number = rand.Next();
            Console.WriteLine(number);
        }
    }
}