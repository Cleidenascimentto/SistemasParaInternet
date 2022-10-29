using System;
class MainClass {
    public static void Main(string[] args) {

        int a = 5, b = 10;
        int x = (a <= 10 ? a++ + b : ++b - a);
        Console.WriteLine(x);
           
        }
    }

