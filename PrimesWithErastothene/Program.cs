using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimesWithErastothene
{
  internal class Program
  {
    static void Main()
    {
      // Limitez la valeur pour éviter l'OutOfMemoryException
      int endNumber = 200_000_000; // 100 millions, ajustez selon vos besoins et capacités
      List<int> nombresPremiers = CribleEratosthene(endNumber);
      Console.WriteLine($"Nombres premiers ≤ {endNumber} :");
      Console.WriteLine(string.Join(", ", nombresPremiers));
      Console.WriteLine("press any key to exit...");
      Console.ReadKey();
    }

    static List<int> CribleEratosthene(int number)
    {
      // Utilisation de BitArray pour économiser la mémoire
      var estPremier = new BitArray(number + 1, true);

      for (int i = 2; i * i <= number; i++)
      {
        if (estPremier[i])
        {
          for (int j = i * i; j <= number; j += i)
          {
            estPremier[j] = false;
          }
        }
      }

      var resultats = new List<int>();
      for (int i = 2; i <= number; i++)
      {
        if (estPremier[i])
        {
          resultats.Add(i);
        }
      }

      return resultats;
    }
  }
}
