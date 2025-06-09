using System;
using System.Diagnostics;
using System.Linq;

namespace PrimesWithLinq
{
  internal class Program
  {
    public static void Main()
    {
      var sw = new Stopwatch();
      sw.Start();

      int minimumNumber = 2;
      int maximumNumber = 1000000; // retourne 78 498 en ~1 ms

      var primes = from n in Enumerable.Range(minimumNumber, maximumNumber - minimumNumber).AsParallel()
                   where Enumerable.Range(1, (int)Math.Sqrt(n)).All(v => v == 1 || n % v != 0)
                   select n;

      sw.Stop();

      Console.WriteLine();
      Console.WriteLine($"De {minimumNumber} à {maximumNumber}, {primes.Count()} nombres premiers trouvés en {sw.ElapsedMilliseconds} ms.");
      Console.WriteLine(string.Empty);
      foreach (var prime in primes.OrderBy(i => i).Take(500)) // affiche les 100 premiers nombres premiers trouvés
      {
        Console.Write($"{prime} ");
      }

      Console.WriteLine(string.Empty);
      Console.WriteLine("Appuyez sur une touche pour quitter.");
      Console.ReadKey();
    }
  }
}
