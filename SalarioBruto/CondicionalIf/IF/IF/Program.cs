using System;
class MainClass
{
    public static void Main(string[] args) {
        int nota;
        Console.Write("Digite a nota do aluno : ");
        nota = int.Parse(Console.ReadLine());
        if (nota >= 60)
            Console.WriteLine("O aluno foi aprovado.");
    }
}