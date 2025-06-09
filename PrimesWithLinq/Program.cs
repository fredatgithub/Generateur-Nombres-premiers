using System;
using System.Diagnostics;
using System.IO;
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
      //int maximumNumber = 1_000_000; // retourne 78 498 en ~1 ms
      int maximumNumber = int.MaxValue; // int.MaxValue = 2 147 483 647

      var primes = from n in Enumerable.Range(minimumNumber, maximumNumber - minimumNumber).AsParallel()
                   where Enumerable.Range(1, (int)Math.Sqrt(n)).All(v => v == 1 || n % v != 0)
                   select n;

      sw.Stop();

      Console.WriteLine();
      Console.WriteLine($"De {minimumNumber} à {maximumNumber}, {primes.Count()} nombres premiers trouvés en {sw.ElapsedMilliseconds} ms.");
      Console.WriteLine(string.Empty);
      // affiche les 500 premiers nombres premiers trouvés
      SavePrimesToFile(primes, $"Primes-{primes.Count()}.txt");
      foreach (var prime in primes.OrderBy(i => i).Take(500))
      {
        Console.Write($"{prime} ");
      }

      Console.WriteLine(string.Empty);
      Console.WriteLine("Appuyez sur une touche pour quitter.");
      Console.ReadKey();
    }

    private static void SavePrimesToFile(ParallelQuery<int> primes, string filename)
    {
      // Sauvegarde les nombres premiers dans un fichier texte avec un nombre par ligne
      using (var writer = new StreamWriter(filename))
      {
        foreach (var prime in primes.OrderBy(i => i))
        {
          writer.WriteLine(prime);
        }
      }
    }
  }
}
