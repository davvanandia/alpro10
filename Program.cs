using System;

class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("CONTOH PERULANGAN FOR");
        for (int i = 1; i < 3; i++)
        {
            Console.WriteLine("Angka: " + i);
        }

        Console.WriteLine();
        //2
        Console.WriteLine("CONTOH WHILE LOOP");
        int w = 1;
        while (w <= 3)
        {
            Console.WriteLine("Angka: " + w);
            w++;
        }

        Console.WriteLine();
        //3
        Console.WriteLine("CONTOH DO WHILE LOOP");
        int dw = 2;
        do
        {
            Console.WriteLine("Angka: " + dw);
            dw++;
        }
        while (dw <= 5);
        Console.WriteLine();

        //4
        Console.WriteLine("CONTOH NESTED LOOP"); 
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}