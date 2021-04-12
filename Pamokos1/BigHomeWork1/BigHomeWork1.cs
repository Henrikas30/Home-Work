using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamokos1.BigHomeWork1
{
    class BigHomeWork1
    {
         static void Main()
        {
            Console.WriteLine("Ivesk skaiciu: ");
            string eilute = Console.ReadLine();
            bool skaiciusArbaNe = ArSkaicius(eilute);

            if (skaiciusArbaNe)
            {
                Console.WriteLine("skaicius");

            }
            else
            {
                Console.WriteLine("neskaicius");
            }


        }

        static bool ArSkaicius(string galSkaicius)
        {
            bool rezultatas = true;

            

            for (int i = 0; i < galSkaicius.Length; i++)
            {
                char simbolis = galSkaicius[i];

                Console.WriteLine("i=" + i);

                if (simbolis == '0')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '1')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '2')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '3')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '4')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '5')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '6')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '7')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '8')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '9')
                {
                    Console.WriteLine(simbolis);
                }
                else if (simbolis == '-' && i == 0)
                {
                    Console.WriteLine(simbolis);
                }

                else
                {
                    rezultatas = false;
                }

            }

            return rezultatas;
        }
    }
}
