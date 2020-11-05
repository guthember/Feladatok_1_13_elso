using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F03
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("*************");
      //Console.WriteLine("* Gúth Erik *");
      //Console.WriteLine("*************");

      Console.Write("Mit keretezzek be: ");
      string mit = Console.ReadLine();

      string nev = "| "+mit+" |";
      int hossz = nev.Length;
      string diszitosor = "";

      
      for (int i = 0; i < hossz; i++)
      {
        if (i == 0 || i == hossz -1)
        {
          diszitosor = diszitosor + "+";
        }
        else
        {
          diszitosor = diszitosor + "-";
        }
      }

      Console.WriteLine(diszitosor);
      Console.WriteLine(nev);
      Console.WriteLine(diszitosor);

      Console.ReadLine();
    }
  }
}
