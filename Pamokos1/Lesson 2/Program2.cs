using System;

namespace Pamokos1
{
    class Program2
    {
        static void Main()
        {
            //Lesson 2

            /*uzduotis1
             
            Console.WriteLine("Irasykite apskritimo spinduli: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine("Apskritimo ilgis yra: " + 2*radius * pi + "m!");
            Console.WriteLine("Apskritimo plotas yra: " + pi * (radius*radius) + "m2!");
            
           
            Console.WriteLine("Atstumas metrais: ");
            int atstumas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Laikas sekundemis: ");
            int sekundes = Convert.ToInt32(Console.ReadLine());
            double kmPerValanda = 3.6;
            Console.WriteLine("Greitis: " + atstumas/sekundes * kmPerValanda);

            */
            /*uzduotis2

            int num = 10;
            Console.WriteLine("skaicius: " + num);
            num += 10;
            Console.WriteLine("Skaicius numeris 2: " + num);
            num /= 2;
            Console.WriteLine("Skaicius numeris 3: " + num);
            num++;
            Console.WriteLine("Skaicius numeris 4: " + num);
            ++num;
            Console.WriteLine("Skaicius numeris 5: " + num);
            */

            /*uzduotis3

            Console.WriteLine("Irasyti pirmaji skaiciu: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Irasyti antraji skaiciu: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num > num2)
            {
                Console.WriteLine(" 1 ");
            }
            if(num < num2)
            {
                Console.WriteLine(" 2 ");
            }
            if(num >= num2)
            {
                Console.WriteLine(" 3 ");
            }
            if(num <= num2)
            {
                Console.WriteLine(" 4 ");
            }
            if(num == num2)
            {
                Console.WriteLine(" 5 ");
            }
            if(num != num2)
            {
                Console.WriteLine(" 6 ");
            }
            
            */
            /*uzduotis4

            Console.WriteLine("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            int amzius2 = 18;

            if (amzius2 == amzius)
            {
                Console.WriteLine("Jis yra 18 metu!");
            }
            else
            {
                Console.WriteLine("jis nera 18 metu");
            }

            if(amzius % 2 == 0)
            {
                Console.WriteLine("Dalinasi");
            }
            else
            {
                Console.WriteLine("Nesidalina");
            }

            */

            //uzduotis5
            
            
            Console.WriteLine("Irasyti studento ivertinimo bala: ");
            int balas = Convert.ToInt32(Console.ReadLine());

            if (balas == 10)
            {
                Console.WriteLine("puiku");
            }
            else if (balas == 9 || balas == 8)
            {
                Console.WriteLine("labai gerai");
            }
            else if (balas == 7 || balas == 6)
            {
                Console.WriteLine("gerai");
            }
            else if (balas == 5)
            {
                Console.WriteLine("vidutiniskai");
            }
            else if (balas == 4)
            {
                Console.WriteLine("bent teigiamas");
            }
            else if (balas == 3 || balas == 2 || balas == 1)
            {
                Console.WriteLine("labai blogai");
            }
            else
            {
                Console.WriteLine("Jusu skaicius neteisingas!");
            }
            
        }
    }
}
