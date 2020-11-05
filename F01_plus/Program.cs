using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F01_plus
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 1; i <= 13; i++)
      {
        if (i % 2 == 0)
        {
          Console.BackgroundColor = ConsoleColor.White;
        }
        else
        {
          Console.BackgroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("                                              ");
      }

      Console.SetCursorPosition(0, 0);
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.White;
      for (int i = 1; i <= 7; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine("  *  *  *  *  *   ");
        }
        else
        {
          Console.WriteLine(" *  *  *  *  *  * ");
        }
      }

      Console.SetCursorPosition(0, 13);

      Console.ReadKey();
    }
  }
}
