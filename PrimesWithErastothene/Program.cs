using System;
using System.Collections.Generic;

namespace PrimesWithErastothene
{
  internal class Program
  {
    static void Main()
    {
      //Console.Write("Entrez un entier N > 1 : ");
      int endNumber = int.MaxValue;
      List<int> nombresPremiers = CribleEratosthene(endNumber);
      Console.WriteLine($"Nombres premiers ≤ {endNumber} :");
      Console.WriteLine(string.Join(", ", nombresPremiers));
      Console.WriteLine("press any key to exit...");
      Console.ReadKey();
    }

    static List<int> CribleEratosthene(int number)
    {
      // Initialisation du tableau de booléens
      bool[] estPremier = new bool[number + 1];
      for (int i = 2; i <= number; i++)
        estPremier[i] = true;

      // Application du crible
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

      // Construction de la liste des nombres premiers
      List<int> resultats = new List<int>();
      for (int i = 2; i <= number; i++)
      {
        if (estPremier[i])
          resultats.Add(i);
      }

      return resultats;
    }
  }
}
