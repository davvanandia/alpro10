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

        for (int j = i; j > 0; j--)
        {
            Console.Write("Masukkan Username Anda: ");
            string username = Console.ReadLine();

            Console.Write("Masukkan Password Anda: ");
            long password;
            bool passwordAngka = long.TryParse(Console.ReadLine(), out password);

            bool usernameBenar = (username == namaDepan);
            bool passwordBenar = (passwordAngka && password == NIM);

            if (usernameBenar && passwordBenar)
            {
                Console.WriteLine("Selamat, anda berhasil login!");
                return;
            }
            else if (!usernameBenar && !passwordBenar)
            {
                Console.WriteLine("Username dan Password salah, login gagal");
            }
            else if (!usernameBenar && passwordBenar)
            {
                Console.WriteLine("Username salah, login gagal");
            }
            else
            {
                Console.WriteLine("Password salah, login gagal");
            }

            int percobaan = j - 1;
            Console.WriteLine("Percobaan Tersisa: " + percobaan);
            Console.WriteLine();
        }

        Console.WriteLine("Maaf, Anda telah kehabisan percobaan. Silakan coba lagi nanti.");
    }
}