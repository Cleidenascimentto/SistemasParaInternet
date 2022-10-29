using System;
class MainClass {
    public static void Main (string[] args) {
        int a = 5, b = 9, c = 7;
        
        if (a > 0 && b < a || c > b)
            Console.WriteLine("Urso");
        else if ((a + b) > c || a > c)
            Console.WriteLine("Cachorro");
        else if (c > 5)
            Console.WriteLine("Macaco");
        else
            Console.WriteLine("Gato");
        

    }
}
