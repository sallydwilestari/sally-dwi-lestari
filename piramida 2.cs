using System;

class Program
{
    static void Main()
    {
        int tinggi;

        Console.Write("Masukkan tinggi piramida: ");
        tinggi = int.Parse(Console.ReadLine());

        for (int i = 1; i <= tinggi; i++)
        {
            // Membuat spasi di sebelah kiri
            for (int j = 1; j <= tinggi - i; j++)
            {
                Console.Write(" ");
            }

            // Menampilkan bintang pertama
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            // Menambahkan spasi di tengah
            Console.Write("  "); // Dua spasi untuk memisahkan dua set bintang

            // Menampilkan bintang kedua
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Pindah ke baris berikutnya
        }
    }
}
