using System;
class MainClass
{
    public static void Main(string[] args) {
        // Declaração de variáveis
        Double Hipotenusa, Cateto1, Cateto2;
        // Entrada de dados
        Console.Write("Informe o valor do cateto 1: ");
        Cateto1 = Double.Parse(Console.ReadLine());
        Console.Write("Informe o valor do cateto 2: ");
        Cateto2 = Double.Parse(Console.ReadLine());
        // Cálculo da Hipotenusa
        Hipotenusa = Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
        // Saída / impressão do resultado
        Console.Write($"Hipotenusa = {Hipotenusa}");
    }
}