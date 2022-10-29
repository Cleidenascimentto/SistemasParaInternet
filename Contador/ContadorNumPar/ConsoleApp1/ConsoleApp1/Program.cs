        using System;

        class MainClass {
         public static void Main(string[] args) {
        int pares = 0; // Contador de números pares
        int num;
        Console.Write("Digite um numero positivo: ");
        num = int.Parse(Console.ReadLine());
        while (num >= 0)
        {
            if (num % 2 == 0)
                pares = pares + 1;
            Console.Write("Digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.Write($"Foram digitados {pares} numerospares.");
    }
}