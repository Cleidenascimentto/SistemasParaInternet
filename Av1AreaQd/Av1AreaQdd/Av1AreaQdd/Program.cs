using System;

class MainClass {
    public static void Main(string[] args) {

        double ladoQuadrado = 0;
        double areaQuadrado = 0;

        // ENTRADA DE DADOS
        Console.Write("Digite o lado do quadrado: ");
        ladoQuadrado = double.Parse(Console.ReadLine());

        // DEFININDO O VALOR DA AREA
        areaQuadrado = calcularAreaQuadrado(ladoQuadrado);
        
        double calcularAreaQuadrado(double lado)
        {
            return lado * lado;
        }
        // IMPRIMINDO O RESULTADO
        Console.WriteLine($"Área = {areaQuadrado}");
    }

}

