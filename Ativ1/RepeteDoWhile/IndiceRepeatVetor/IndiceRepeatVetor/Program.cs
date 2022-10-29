using System;

class MainClass {
     public static void Main (string[] args) {
        int i;

        int[] Valores = new int[5];

        //Entrada de Dados

        Console.WriteLine("Entrada de Elementos no Vetor: \n");

        for (i = 0; i < 5; i++)
        {
            Console.Write($"Digite o Elemento {i + 1} do Vetor: ");
            Valores[i] = int.Parse(Console.ReadLine());
        }
    }
}
    
