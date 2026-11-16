using System;

class latihan
{
    static void Main(string[] args)
    {
        int i = 3;
        String namaDepan = "Davina";
        long NIM = 110012600206;

        Console.WriteLine("================================");
        Console.WriteLine("LOGIN");
        Console.WriteLine("================================");

        
        
        for (j = i; j > i; j--)
        {
            Console.Write("Masukkan Username Anda: ");
            string username = Console.ReadLine();

            Console.Write("Masukkan Password Anda: ");
            long password = Convert.ToInt64(Console.ReadLine());

            if (username == namaDepan && password == NIM)
            {
                Console.WriteLine("Selamat! Berhasil Login");
                return;
            }
            else
            {
                int percobaan = i - 1;
                Console.WriteLine("Username atau Password Salah");
                Console.WriteLine("Percobaan Tersisa: " + percobaan);
            }
        }

        Console.WriteLine("Maaf, Anda telah kehabisan percobaan. Silakan coba lagi nanti.");


    }
}