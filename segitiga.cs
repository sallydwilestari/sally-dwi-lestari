using System;
class Program
{
    static void Main()
    {
Console.Write("Masukkan nilai alas segitiga: ");
double alas = Convert.ToDouble(Console.ReadLine());

Console.Write("Masukkan nilai tinggi segitiga: ");
double tinggi = Convert.ToDouble(Console.ReadLine());

double luas = 0.5*alas*tinggi;

Console.WriteLine("Luas segitiga adalah:"+luas);
    }
}
