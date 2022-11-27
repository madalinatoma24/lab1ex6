using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex6
             Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
             descrescatoare.
             • Exemplu: citim 3,9,0 Afisam : 9 3 0
             */

            int x; 
            int y;
            int z;

            Console.WriteLine("Introduceti valoarea lui x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui z: ");
            z = int.Parse(Console.ReadLine());


            if (x > y && x > z)
            {
                if(y < z)
                {
                    Console.WriteLine("{0} {1} {2}", x, z, y);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", x, y, z);
                }
               
            }else if(y > x && y > z)
            {
                if (x < z)
                {
                    Console.WriteLine("{0} {1} {2}", y, z, x);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", y, x, z);
                }

            }
            else if (z > x && z > y)
            {
                if (x < y)
                {
                    Console.WriteLine("{0} {1} {2}", z, y, x);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", z, x, y);
                }

            }

        }
    }
}
