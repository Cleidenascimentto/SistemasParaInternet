using System;
class MainClass {
    public static void Main(string[] args) {

        int R = 0;
        int X = 5;
        int Y = 2;

        do
        {
            X += 1;
            Y += 2;
            R++;
        } while (X > Y);
        Console.WriteLine($" O Valor da Variavel R = {R} ");
        }
    }

