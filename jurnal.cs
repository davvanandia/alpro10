
using System;
using System.Globalization;

public class RekapPoin
{
    static void Main()
    {
        Console.WriteLine("================================================");
        Console.WriteLine("       SISTEM REKAP POIN KEGIATAN PESERTA");
        Console.WriteLine("================================================");

        Console.Write("Masukkan jumlah peserta: ");
        int jumlahPeserta = Convert.ToInt32(Console.ReadLine());

        int totalPoin = 0;
        int poinTertinggi = 0;
        int poinTerendah = 100;
        int pesertaLulus = 0;
        int pesertaTidakLulus = 0;

        for (int i = 1; i <= jumlahPeserta; i++)
        {
            Console.Write("\nPoin peserta ke-" + i + ": ");
            int poin = Convert.ToInt32(Console.ReadLine());

            totalPoin += poin;

            if (poin > poinTertinggi)
            {
                poinTertinggi = poin;
            }

            if (poin < poinTerendah)
            {
                poinTerendah = poin;
            }

            if (poin >= 70)
            {
                pesertaLulus++;
            }
            else
            {
                pesertaTidakLulus++;
            }
        }

        double rataRata = (double)totalPoin / jumlahPeserta;

        Console.WriteLine("\n================== HASIL REKAP ==================");
        Console.WriteLine("Total Poin          : " + totalPoin);
        Console.WriteLine("Rata-rata Poin      : " + rataRata.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Poin Tertinggi      : " + poinTertinggi);
        Console.WriteLine("Poin Terendah       : " + poinTerendah);
        Console.WriteLine("Peserta Lulus       : " + pesertaLulus);
        Console.WriteLine("Peserta Tidak Lulus : " + pesertaTidakLulus);

        Console.Write("Bintang Prestasi    : ");

        if (pesertaLulus > 0)
        {
            for (int i = 1; i <= pesertaLulus; i++)
            {
                Console.Write("* ");

            }
        }
        else
        {
            Console.Write("-");
        }

        Console.WriteLine();
        Console.WriteLine("================================================");
    }
}
