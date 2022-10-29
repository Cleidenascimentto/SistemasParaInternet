using System;
class MainClass
{
    public static void Main(string[] args) {
        // Declaração de variáveis
        Double Salario, Inss;
        // Entrada de dados
        Console.Write("Informe o valor do seu salário: ");
        Salario = Double.Parse(Console.ReadLine());
        // Cálculo
        Inss = Salario * 0.11;
        // Saída de dados
        Console.WriteLine($"O valor do INSS = R$ {Inss:0.00}");
    }
}