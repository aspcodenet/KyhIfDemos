using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace KyhIfDemos
{
    internal class Application
    {
        public void Run()
        {
            /*
             Be användaren att mata in ett tal. Kontrollera om talet är större än 10. Meddela användaren om talet är större än 10- Talet är större än 10. Om det är mindre än 10 meddela användaren – Talet är mindre än 10
             */
            int tal = Convert.ToInt32(Console.ReadLine());
            if (tal > 10)
            {
                Console.WriteLine("Talet är större än 10");
            }
            else if (tal < 10)
            {
                Console.WriteLine("Talet är mindre än 10");
            }
            else 
            {
                Console.WriteLine("");
            }

            Console.Write("Ange tröjnummer:");
            int jerseyNumber = Convert.ToInt32(Console.ReadLine());
            switch (jerseyNumber)
            {
                case 21:
                    Console.WriteLine("Foppa");
                    break;
                case 13:
                    Console.WriteLine("Sudden");
                    break;
                case 2:
                    Console.WriteLine("Anders Eldebrink");
                    break;
                default:
                    Console.WriteLine("Jag knner inte till den spelaren")
                    break;
            }

            //if (jerseyNumber == 21)
            //{
            //    Console.WriteLine("Foppa");
            //}
            //else if (jerseyNumber == 13)
            //{
            //    Console.WriteLine("Mats Sundin");
            //}
            //else if (jerseyNumber == 2)
            //{
            //    Console.WriteLine("Anders Eldebrink");
            //}


            //   int age = 12;

            //if(age != 50)
            //{
            //    Console.WriteLine("Du är inte cool");
            //}


            ////age = age + 1;

            //// 20 eller 50 år 
            //if (age == 20 || age == 50)
            //{
            //    Console.WriteLine("Du är cool");
            //}

            Console.Write("Var är du S/K:");
            string location = Console.ReadLine();
            Console.Write("Hur gammal är du?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vilken promillehalt:");
            double promille = Convert.ToDouble(Console.ReadLine());


            //if (promille < 1.0 && ((age >= 18 && location == "K" ) ||
            //    (age >= 20 && location == "S" )))
            //{
            //    Console.WriteLine("Du får köpa öl");
            //}
            //else
            //{
            //    Console.WriteLine("Du får inte köpa");
            //}








            if (age >= 18 && location == "K" && promille < 1.0  )
            {
                Console.WriteLine("Du får köpa öl");
            }
            else if (age >= 20 && location == "S" && promille < 1.0)
            {
                Console.WriteLine("Japp du får köpa");
            }
            else
            {
                Console.WriteLine("Du får inte köpa");
            }

            //if (age > 17)

            //string namn;
            //Console.WriteLine("Vad heter du?");
            //namn = Console.ReadLine();
            ////Console.WriteLine(namn == "Stefan");
            //if (namn == "Stefan") 
            //{
            //    Console.WriteLine("Vilket fint namn");
            //    Console.WriteLine("Stefan är fint som sagt");
            //}
            //else if (namn == "Oliver") 
            //{
            //    Console.WriteLine("kul namn");
            //}
            //else
            //{
            //    Console.WriteLine("Ditt namn duger väl också!");
            //}

        }
    }
}
