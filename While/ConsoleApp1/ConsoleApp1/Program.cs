using System;

class MainClass {
    public static void Main(string[] args) {


        int a = 1, b = a, c = 2, d = c;
        for (int cont = 1; cont < 5; cont += 2)
        {
            a += b;
            b -= c;
            c += d;
            d -= a;


            Console.WriteLine( a + "," +b+ "," +c+ ","+d); }
    }
}
        
