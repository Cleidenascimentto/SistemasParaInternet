    using System;
    class MainClass
{
    public static void Main(string[] args) {
        // Contador de números pares e ímpares
        int pares = 0, impares = 0;
        int num;
        Console.Write("Digite um numero positivo: ");
        num = int.Parse(Console.ReadLine());
        while (num >= 0)
        {
            if (num % 2 == 0)
                pares = pares + 1;
            else
                impares = impares + 1;
            Console.Write("Digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.Write($"Foram digitados {pares} numerospares e {impares} impares.");
    }
}