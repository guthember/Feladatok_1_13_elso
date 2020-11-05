using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F09
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1, 0, 1 -> 5
      // 1, 1, 0 -> 6
      // 0, 1, 0 -> 2
      int negyesek, kettesek, egyesek;
      Console.Write("Első számjegy: ");
      negyesek = Convert.ToInt32(Console.ReadLine());
      Console.Write("Második számjegy: ");
      kettesek = Convert.ToInt32(Console.ReadLine());
      Console.Write("Harmadik számjegy: ");
      egyesek = Convert.ToInt32(Console.ReadLine());

      int tizseben = negyesek * 4 + kettesek * 2 + egyesek;

      Console.WriteLine(tizseben);

      Console.ReadLine();
    }
  }
}
