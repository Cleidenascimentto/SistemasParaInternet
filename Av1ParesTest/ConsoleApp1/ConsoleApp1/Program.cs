using System;

class MainClass {

    public static void Main(string[] args) {

        int num;

        Console.Write("Por favor, digite um numero inteiro: ");
        num = int.Parse(Console.ReadLine());

        if (num % 2 != 0)
        {
            Console.WriteLine("O numero {0} eh impar", num);
        }
        else
        {
            Console.WriteLine("O numero {0} nao eh impar", num);
        }
    }
}