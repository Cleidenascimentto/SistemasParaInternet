    using System;
class MainClass
{
    public static void Main()
    {

        static bool TestaNum(int n)
        {
            int P1, P2, N;

            P1 = n / 100;
            P2 = n % 100;
            N = n % 100;

            if ((P1 + P2) * (P1 + P2) == n)
                return true;
            else
                return false;
        }
        {

             Console.Write("Digite um número de 4 algarismo:  ");
             N = int.Parse(Console.ReadLine());

             
               if (TestaNum(N))
                Console.WriteLine(" Esse Número possui essa característica ...");
               else
                Console.WriteLine("Esse Número Não possui essa caracteristica ...");
        }
    }
}

