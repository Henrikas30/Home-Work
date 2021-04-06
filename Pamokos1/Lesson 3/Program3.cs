using System;

namespace Pamokos1
{
    class Program3
    {
        static void Main()
        {
            //Lesson 3

            Console.WriteLine("Irasyti tris skaicius!");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            int antras = Convert.ToInt32(Console.ReadLine());
            int trecias = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras || pirmas > trecias)
            {
                Console.WriteLine("Pirmas yra didziausias skaicius!");
            } 
            else if (antras > trecias)
            {
                Console.WriteLine("Antras yra didziausias!");
            } 
            else 
            {
                Console.WriteLine("Trecias yra didziausias!");
            }

            Console.WriteLine("Irasyti tris skaicius!");
            int pirmas1 = Convert.ToInt32(Console.ReadLine());
            int antras2 = Convert.ToInt32(Console.ReadLine());
            int trecias3 = Convert.ToInt32(Console.ReadLine());

            if (pirmas1 > antras2 && pirmas1 < 100)
            {
                Console.WriteLine("1");
            }
            else if (antras2 > 0 && antras2 > pirmas1)
            {
                Console.WriteLine("2");
            }
            else if ((pirmas1 > antras2 && pirmas1 > trecias3) || pirmas1 > 0)
            {
                Console.WriteLine("3");
            }
            else if ((trecias3 >= 5 && trecias3 <= 10) || trecias3 > pirmas1 || trecias3 > pirmas1)
            {
                Console.WriteLine("4");
            }

        }
    }
}
