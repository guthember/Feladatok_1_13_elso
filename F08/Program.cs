using System;

namespace F08
{
  class Program
  {
    static void Main(string[] args)
    {
      int tizesek, egyesek;

      Console.WriteLine("Kétjegyű számjegyet kérek be, először a tizeseket!");

      Console.Write("Tizesek: ");
      tizesek = Convert.ToInt32(Console.ReadLine());

      Console.Write("Egyesek: ");
      egyesek = Convert.ToInt32(Console.ReadLine());

      int szam = tizesek * 10 + egyesek;

      Console.WriteLine(szam*2);

      Console.ReadLine();

    }
  }
}
