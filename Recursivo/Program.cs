using System;


namespace Recursivo
{
    public class Recursive
    {
        public void Recursivao()
        {

            int x = 1;

            do
            {
                int.TryParse(Console.ReadLine(), out x);

                if (x == 2)
                {
                    Console.WriteLine("Para de escrever 2, isso machuca");
                }

            }
            while (x != 0);

            Console.WriteLine("Parabéns!");


        }
    }
}