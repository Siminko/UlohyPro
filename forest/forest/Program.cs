using forest;
using System;
using System.Collections.Generic;

namespace forest
{
    internal class Program
    {
        private static int b;

        private static void Main(string[] args)
        {
            Main(args, b);
        }

        static void Main(string[] args, int b)
        {
            Forest forest = new Forest();
            forest.PlantTrees(10);
            for (int i = 0; i < Tree.daysOfYear; i++) //yearly
            {
                foreach (Tree tree in forest.trees)
                {
                    tree.Growing();
                }
            }
            foreach (Tree tree in forest.trees)
            {
                Console.WriteLine(tree.GetInfo());
            }
            Console.WriteLine("Hello world!");

            

            double polomer;
            double vyska;
            
            

            /*  double konare1;
              double konare2;
              double konare3;
              double konare4;*/
           
            Console.WriteLine("Druh stromu: ihlicnaty (ihl), listnaty (list), baobab (baob)");
            string typStromu = Console.ReadLine();

            Console.Write("Polomer : ");
            double.TryParse(Console.ReadLine(), out polomer);

            Console.Write("Vyska : ");
            double.TryParse(Console.ReadLine(), out vyska);

            double v = 1.0 / 3.0 * Math.PI * (polomer * polomer) * vyska;

            

            /*  Console.Write("Pocet Konarov 1: ");
               double.TryParse(Console.ReadLine(), out konare1);

               Console.Write("Pocet Konarov 2: ");
               double.TryParse(Console.ReadLine(), out konare2);

               Console.Write("Pocet Konarov 3: ");
               double.TryParse(Console.ReadLine(), out konare3);

               Console.Write("Pocet Konarov 4: ");
               double.TryParse(Console.ReadLine(), out konare4);*/



            /* double k1 = 1.0 / 3.0 * Math.PI * (konare1 * konare1) * vyska;
             double k2 = 1.0 / 3.0 * Math.PI * (konare2 * konare2) * vyska;
             double k3 = 1.0 / 3.0 * Math.PI * (konare3 * konare3) * vyska;
             double k4 = 1.0 / 3.0 * Math.PI * (konare4 * konare4) * vyska;*/

            double vyskaK = 0;
            double Radius = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Vyska konara: ");
                double.TryParse(Console.ReadLine(), out vyskaK);

                Console.Write("Polomer konara: ");
                double.TryParse(Console.ReadLine(), out Radius);

                 double k = 1.0 / 3.0 * Math.PI * (Radius * Radius) * vyskaK;

                v = v + k;
            }

            if (typStromu == "ihl" || typStromu == "ihlicnaty")
            {
                Ihlicnaty ihli = new Ihlicnaty(Radius, vyskaK);
                Console.WriteLine($"\nObjem = {ihli.Obsah()}\n");

            }
            else if (typStromu == "list" || typStromu == "listnaty")
            {
                Listnaty listn = new Listnaty(Radius, vyskaK);
                Console.WriteLine($"\nObjem = {listn.Obsah()}\n");

            }
            else if (typStromu == "baob" || typStromu == "baobab")
            {
                Baubab baob = new Baubab(Radius, vyskaK);
                Console.WriteLine($"\nObjem = {baob.Obsah()}\n");


            }
            else
            {
                Console.WriteLine("Zly vstup");
            }

            Console.ReadLine();

            

            
            Console.WriteLine(v);

        




        }
    }

  


}
