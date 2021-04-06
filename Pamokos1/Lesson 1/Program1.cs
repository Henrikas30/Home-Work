using System;

namespace Pamokos1
{
    class Program1
    {
        public static void Main(string[] args)
        {
            //Lesson 1
            /*
            Console.WriteLine("Mano vardas: {0}  Mano pavarde: {1}  ,bei mano amzius {2}", "Henrikas", "Rozenas", 32);
            Console.ReadLine();
            Console.ReadKey();
            */

            //uzduotis1

            /*
            int altitude = -100;
            double age = 12.5;
            char letter = 'M';
            string name = "uzduotis";
            bool isItFalse = false;

            Console.WriteLine("ivestas tekstas");
            Console.ReadKey();

            Console.WriteLine("Koks jusu vardas?");
            Console.ReadLine();
            
            Console.WriteLine("Kokia jusu pavarde?");
            Console.ReadLine();
            */

            //uzduotis2

            
            Console.WriteLine("Vardas: ");
            string name = Console.ReadLine();

            Console.WriteLine("Megstamos spalvos raide: ");
            char raide = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Skaicius int: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius double: ");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Mano vardas = {name} megstamiausia splavos pirma raide = {raide} skaicius be kablelio = {skaicius}   skaicius su kableliu = {skaicius2}");

            

            



            

        }
    }
}
