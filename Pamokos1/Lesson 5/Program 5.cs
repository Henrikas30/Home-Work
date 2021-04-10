using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamokos1.Lesson_5
{
    class Program_5
    {
        /*
        static void Main()
        {

            Console.WriteLine("Hi!");
            SayHello();
            SaySomething();
            

        }

        //Funkcijos is didziuju raidziu
        static void SayHello()
        {

            Console.WriteLine("Hello!");
            SaySomething();
        }

        static void SaySomething()
        {
            Console.WriteLine("Welcome!");
            SayBye();

        }
        static void SayBye()
        {
            Console.WriteLine("Bye!");
        }
        */

       
        
        //Parametrai
        /*
        static void Main()
        {
            Console.WriteLine("Skaiciu atimtis:");
            Parametrai("nutylejimas", 5, 2);
        }

        // Galima suteikti parametra pagal nutylejima "static void Parametrai(int first, int second = 10)"
        static void Parametrai(string = "nutylejimas", int first, int second)

        {
            Console.WriteLine();
            Console.WriteLine(first - second);


        }
        
        
        
        
        /*
        static void Main()
        {
           Console.WriteLine("Parasyti 2 skaicius: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
           int sk2 = Convert.ToInt32(Console.ReadLine());
            Suma();
            Skirtumas();
            Daugyba();
            Dalmuo();
         
        }
       
       
        static void Suma(int sk1 =1, int sk2 = 2)
        {

            Console.WriteLine(sk1 + sk2);

        }
        static void Skirtumas(int sk1 =1, int sk2 = 2)
        {

            Console.WriteLine(sk1 - sk2);

        }
        static void Daugyba(int sk1 =1, int sk2 = 2)
        {

            Console.WriteLine(sk1 * sk2);

        }
        static void Dalmuo(int sk1 =1, int sk2 = 2)
        {

            Console.WriteLine(sk1 / sk2);

        }
        */

        //grazina texta
        /*
        static string GetText()
        {

            string name = "hi";
            double data = 2.5;

            if (data > 0)
            {
                name = "Some text" + data;
            }

            return name;

        }
        */
        
        static void Main()
        {
            Console.WriteLine("Ivesti svori:");
            double svoris = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ivesti ugi:");
            double ugis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(FizineBusena(KunoMasesKMI(svoris, ugis)));
            


        }
        static double KunoMasesKMI(double svoris, double ugis)
        {
            
            return svoris / (ugis * ugis);
            
            
        }

        static string FizineBusena(double rezultatas)
        {
            string paskaiciuotas = "";

            if (rezultatas < 15)
            {
                paskaiciuotas = "badaujantis zmogus";
            }
            else if (rezultatas < 18.5)
            {
                paskaiciuotas = "liesas zmogus";
            }
            else if (rezultatas < 25)
            {
                paskaiciuotas = "normalus zmogus";
            }
            else if (rezultatas < 30)
            {
                paskaiciuotas = "turintis virssvorio zmogus";
            }
            else if (rezultatas < 40)
            {
                paskaiciuotas = "nutukes zmogus";
            }
            else 
            {
                paskaiciuotas = "badaujantis zmogus";
            }
            return paskaiciuotas;

        }
        
        



    }
}
