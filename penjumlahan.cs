using System;
class Program
{
    static void Main()
    {
Console.Write("Masukkan angka pertama: ");
int angka1= Convert.ToInt32(Console.ReadLine());

Console.Write("Masukkan angka kedua: ");
int angka2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Masukkan angka ketiga: ");
int angka3 = Convert.ToInt32(Console.ReadLine());

int hasil = angka1 + angka2 + angka3;

Console.WriteLine("Hasil penjumlahan:"+hasil);
    }
}
