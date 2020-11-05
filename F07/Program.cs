using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F07
{
  class Program
  {
    static void Main(string[] args)
    {
      double a, b;
      Console.Write("Kérek egy számot: ");
      a = Convert.ToDouble(Console.ReadLine());
      Console.Write("Kérek egy másik számot: ");
      b = Convert.ToDouble(Console.ReadLine());

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

      Console.ReadLine();
    }
  }
}
