using System;

namespace Pamokos1
{
    class Program4
    {
        static void Main()
        {
            //for (int i = 0; i < 10 ; i++) i+=5
            //{}

            //i, j, k ,m ,n indeksu eiliskumas


            //1 uzduotis
            /* for (int i = 0; i < 20; i += 3)
             {
                 Console.WriteLine("Ciklas prasideda" + i);
             }


             //2 uzduotis
             Console.WriteLine("Reziai");
             int sk1 = Convert.ToInt32(Console.ReadLine());
             int sk2 = Convert.ToInt32(Console.ReadLine());
             if (sk1 >= sk2)
             {
                 Console.WriteLine("Bad limits!");
             }
             else
             {
                 for (int i = sk1; i < sk2; i++)
                 {
                     Console.WriteLine($"{i} {i * i}");
                 }
             }


             //uzduotis 3
             int sum = 0;

             for (int i = 1000; i > 0; i--)
             {
                 if ( i % 3 == 0 || i % 5 == 0)
                  {
                 sum += i;       
                   }
             }

             Console.WriteLine("suma = {0}", sum);
            */
            /*
            int skaicius = 0;

            while(skaicius < 10)
            {
                Console.WriteLine("skaicius");
                skaicius++;
            }
            */

            /*
            Console.WriteLine("Yra trys pasirinkimai:\n" + "1: Kava \n 2:Arbata \n 3:Vanduo");
            int menu = Convert.ToInt32(Console.ReadLine());
           
            while (menu < 1 || menu > 3)
            {
                Console.WriteLine("Blogas pasirinkimas!");
                menu = Convert.ToInt32(Console.ReadLine());
            }

            switch (menu)
            {
                
                
                case 1:
                    Console.WriteLine("Kava");
                    break;

                case 2:
                    Console.WriteLine("Arbata");
                    break;

                case 3:
                    Console.WriteLine("Vanduo");
                    break;
                        
                
            
                      }
                        */

            /*
                 const string yesAnswer = "yes";
                 const string noAnswer = "no";

                 const int totalSeatCount = 8;
                 const int windowSeatCount = 4;
            
                 int allSeatsTaken = 0;
                 int windowSeatsTaken = 0;

            */

            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }

                if (i > 123)
                {
                    break;
                }

                sum += i;
            }

            Console.WriteLine($"Vsio: {sum}");

        }
    }
}
