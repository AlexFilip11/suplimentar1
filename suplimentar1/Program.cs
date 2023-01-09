using System;

namespace suplimentar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citesc doua numere de la tastatura. Scrieti un program care va calcula cel mai mare divizor comun al numerelor

            Console.WriteLine("Introduceti cele doua numere: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Cel mai mare divizor comun este " + CMMDC(n, m));
        }
        static int CMMDC(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
    }
}
