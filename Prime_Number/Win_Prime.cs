using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Prime_Number
{
  public partial class Win_Prime : Form
  {

    public Win_Prime()
    {
      InitializeComponent();
    }

    private void Btn_GenPrime_Click(object sender, EventArgs e)
    {
      // METHODE NUMERO UN AVEC UTILISATION D'UN TABLEAU D'ENTIER

      // Pour plus de renseignement sur le Crible d'Ératosthène je conseille de lire l'article sur Wikipedia
      // https://fr.wikipedia.org/wiki/Crible_d%27%C3%89ratosth%C3%A8ne

      // Ici on s'assure juste que l'utilisateur à rentré un nombre correct
      try
      {
        int number = Int32.Parse(Txt_ValueMax.Text);

        if (number < 5)
        {
          MessageBox.Show("La valeur minimum prise en compte est : 5 ");
          return;
        }

        if (number > 99999999)
        {
          MessageBox.Show("La valeur maximum prise en compte est : 99999999 ");
          return;
        }
      }
      catch (FormatException)
      {
        MessageBox.Show("Entrez une valeur numerique correcte");
        return;
      }

      // Pour information les structure des tableaux en C# sont 32 bits. C'est pourquoi nous somme limité ici  au niveau de la dimension du tableau
      // et donc du plus grand nombre premier que nous pouvons trouver avec cette methode.
      int Array_Length = Int32.Parse(Txt_ValueMax.Text);
      int[,] myIntArray = new int[Array_Length, 2];              // C'est le tableau qui vas nous servir a faire le crible. La premiere dimension contiendra les nombres, la deuxieme servira de flag.

      int mynum;
      StringBuilder result = new System.Text.StringBuilder();  // C'est une chaine de caractere qui vas servir à la sauvegarde du resultat et non au calcul.

      int nbprime = 0;             // Sert a compter combien de nombre premier on a trouvé

      // On declanche le chronometre pour connaitre le temps de calcul.
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();

      // J'initalise le tableau avec une serie de nombres se succedant en partant de 0 puis 1,2 3,4,5,6,7,8,9,10,11 etc... etc... jusqu'a la fin du tableau
      for (int init = 0; init < Array_Length; init++)
      {

        myIntArray[init, 0] = init;

        // Au depart on flag tout les nombres comme etant premier meme si ce n'est pas le cas.
        // C'est justement le Crible d'Ératosthène qui vas nous permettre de les rayer avec ce flag. 1=C'est un nombre premier, 0 = ce n'est pas un nombre premier. 
        myIntArray[init, 1] = 1;

      }

      // --------------- Debut du calcul des nombres premiers.
      // L'algorithme procède par élimination : il s'agit de supprimer d'une table des entiers de 2 à N tous les multiples d'un entier (autres que lui-même).

      // Je traite manuellement pour des raisons d'optimisation les chiffre 0 et 1 ( qui ne sont pas des nombres premier)
      // Pour le signifier je met un 0 dans la deuxieme dimension du tableau.
      myIntArray[0, 1] = 0;
      myIntArray[1, 1] = 0;

      // On traite a part dans un premier temps le nombre 2 ainsi que ses multiples ( les nombres pairs)
      // Le nombre 2 est le seul nombre premier pair.
      // Aucun nombre pair a part 2 n'est premier
      int PosX = 2;
      mynum = myIntArray[PosX, 0];
      for (int PosMultiple = PosX + mynum; PosMultiple < Array_Length; PosMultiple = PosMultiple + mynum)
      {
        myIntArray[PosMultiple, 1] = 0;
      }

      // Puis on se positionne sur le nombre trois en sautant tout les nombre pairs qui ne seront jamais premiers. Le multiple d'un nombre pair etant aussi toujours un nombre pair donc NON premier. 
      // C'est un optimisation non indispensable mais ca permet d'aller plus vite.

      for (PosX = 3; PosX < Array_Length; PosX = PosX + 2)
      {
        mynum = myIntArray[PosX, 0];

        // Ici aussi une optimisation le multiple d'un nombre impair est une fois sur deux un nombre pair.
        // Or un nombre pair etant un multiple du nombre deux il avait été deja flagué, pas la peine de le faire une deuxieme fois.  ( C'est pourquoi je fait "+ mynum + mynum" )
        // Donc je ne cherche a flaguer ici que les multiples impair de nombre impair.
        for (int PosMultiple = PosX + mynum + mynum; PosMultiple < Array_Length; PosMultiple = PosMultiple + mynum + mynum)
        {
          myIntArray[PosMultiple, 1] = 0;
        }
      }

      // --------------- Fin du calcul des nombres premiers.
      // En rayant tous les multiples des nombres trouvés il ne reste que les nombres n'ayant aucun diviseur entier c'est à dire les nombres premiers.
      // Les nombres premiers sont ceux qui sont restés flagué à 1.

      // On arrete le chronometre pour connaitre le temps de calcul.
      stopWatch.Stop();
      TimeSpan ts = stopWatch.Elapsed;
      string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
      // On renseigne à l'ecran le temps de calcul
      Txt_Time.Text = elapsedTime;

      for (PosX = 2; PosX < Array_Length; PosX++)
      {
        if (myIntArray[PosX, 1] == 1)
        {
          // On converti les nombres en une chaine de caractere dont les differentes valeurs sont séparés par des points virgule.
          // Cette opération ne sert que pour la futur sauvegarde au format texte csv.
          result.Append(myIntArray[PosX, 0].ToString());
          result.Append(";");

          // On calcul combien de nombre premier on a trouvé.
          nbprime++;
        }
      }

      // On affiche la quantité de nombre premiers trouvés
      Txt_nbprime.Text = nbprime.ToString();

      // On affiche une boite de dialogue de sauvegarde à l'ecran pour specifier le fichier à sauvegarder.
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "Text|*.txt";
      saveFileDialog1.Title = "Sauvegarde de la liste des nombres premiers au format csv.";
      saveFileDialog1.ShowDialog();

      // Si le nom de fichier n'est pas vide on crée le fichier pour la sauvegarde du resultat.
      if (saveFileDialog1.FileName.Length != 0)
      {
        FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
        StreamWriter sr = new StreamWriter(fs);
        sr.WriteLine(result.ToString());
        sr.Close();
        fs.Close();
      }
    }

    private void Btn_GenPrime2_Click(object sender, EventArgs e)
    {
      // METHODE NUMERO DEUX CRIBLE ERATOSTHENE AVEC UTILISATION DE BITARRAY

      // Pour plus de renseignement sur le Crible d'Ératosthène je conseille de lire l'article sur Wikipedia
      // https://fr.wikipedia.org/wiki/Crible_d%27%C3%89ratosth%C3%A8ne

      // Ici on s'assure juste que l'utilisateur à rentré un nombre correct
      try
      {
        int number = Int32.Parse(Txt_ValueMax2.Text);

        if (number < 5)
        {
          MessageBox.Show("La valeur minimum prise en compte est : 5 ");
          return;
        }

        if (number > 715827882)
        {
          MessageBox.Show("La valeur maximum prise en compte est : 715827882 ");
          return;
        }
      }
      catch (FormatException)
      {
        MessageBox.Show("Entrez une valeur numerique correcte");
        return;
      }

      int Array_Length = Int32.Parse(Txt_ValueMax2.Text);

      // C'est le tableau qui vas nous servir a faire le crible.
      // Contrairement à la premiere methode il ne contiendra rien a part des 0 ou des 1. C'est l'indice qui indique le nombre qu'il represente ( exemple indice 57 pour le nombre 57)
      BitArray myBitsArray;
      myBitsArray = new BitArray(Array_Length);

      StringBuilder result = new StringBuilder();  // C'est une chaine de caractere qui vas servir à la sauvegarde du resultat et non au calcul.

      uint nbprime = 0;     // Sert a compter combien de nombre premier on a trouvé         

      // On declanche le chronometre pour connaitre le temps de calcul.
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();

      // J'initalise le tableau avec une serie true : je considere dans un premier temps que tout les nombres sont premier meme si ce n'est pas le cas.
      for (int init = 0; init < myBitsArray.Length; init++)
      {
        myBitsArray.Set(init, true);
      }

      // Je traite manuellement pour des raisons d'optimisation les chiffre 0 et 1 ( qui ne sont pas des nombres premier)
      // Pour le signifier je met un 0 dans la deuxieme dimension du tableau.
      myBitsArray[0] = false;
      myBitsArray[1] = false;

      // On traite a part dans un premier temps les multiples du nombre 2 ( les nombres pairs)
      // Le nombre 2 est le seul nombre premier pair.
      // Aucun nombre pair a part 2 n'est premier
      for (int PosMultiple = 4; PosMultiple < myBitsArray.Length; PosMultiple = PosMultiple + 2)
      {
        myBitsArray[PosMultiple] = false;
      }

      // Puis on se positionne sur le nombre trois en sautant tout les nombre pairs qui ne seront jamais premiers. Le multiple d'un nombre pair etant aussi toujours un nombre pair donc NON premier. 
      // C'est un optimisation non indispensable mais ca permet d'aller plus vite.
      for (int PosX = 3; PosX < myBitsArray.Length; PosX = PosX + 2)
      {
        // Ici aussi une optimisation le multiple d'un nombre impair est une fois sur deux un nombre pair.
        // Or un nombre pair etant un multiple du nombre deux il avait été deja flagué, pas la peine de le faire une deuxieme fois.  
        // Donc je ne cherche a flaguer ici que les multiples impair de nombre impair.
        for (int PosMultiple = PosX + PosX + PosX; PosMultiple < myBitsArray.Length; PosMultiple = PosMultiple + PosX + PosX)
        {
          myBitsArray[PosMultiple] = false;
        }
      }

      // --------------- Fin du calcul des nombres premiers.
      // En rayant tous les multiples des nombres trouvés il ne reste que les nombres n'ayant aucun diviseur entier c'est à dire les nombres premiers.
      // Les nombres premiers sont ceux qui sont restés flagué à true.

      // On arrete le chronometre pour connaitre le temps de calcul.
      stopWatch.Stop();
      TimeSpan ts = stopWatch.Elapsed;
      string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
      Txt_Time.Text = elapsedTime;

      for (int PosX = 2; PosX < Array_Length; PosX++)
      {
        // On deduit de son rang le nombre  ( il est premier car indice = true) et on le transpose en une chaine de caractere dont les differentes valeurs sont séparés par des points virgule.
        // Cette opération ne sert que pour la futur sauvegarde au format texte csv.
        if (myBitsArray[PosX] == true)
        {
          result.Append(PosX.ToString());
          result.Append(";");

          // On calcul combien de nombre premier on a trouvé.
          nbprime++;
        }
      }

      // On affiche la quantité de nombre premiers trouvés
      Txt_nbprime.Text = nbprime.ToString();

      // On affiche une boite de dialogue de sauvegarde à l'ecran pour specifier le fichier à sauvegarder.
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "Text|*.txt";
      saveFileDialog1.Title = "Sauvegarde de la liste des nombres premiers au format csv.";
      saveFileDialog1.ShowDialog();

      // Si le nom de fichier n'est pas vide on crée le fichier pour la sauvegarde du resultat.
      if (saveFileDialog1.FileName.Length != 0)
      {
        FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
        StreamWriter sr = new StreamWriter(fs);
        sr.WriteLine(result.ToString());
        sr.Close();
        fs.Close();
      }
    }

    private void Btn_TestPrime_Click(object sender, EventArgs e)
    {
      try
      {
        int number = Int32.Parse(Txt_TestPrime.Text);

        if (number < 0)
        {
          MessageBox.Show("La valeur minimum acceptée pour le test est zero , vous devez inserer un nombre entier >= 0");
          return;
        }
      }
      catch (FormatException)
      {
        MessageBox.Show("Entrez une valeur numerique entiere correcte >=0 ");
        return;
      }

      if (MillerRabinTest(Convert.ToInt64(Txt_TestPrime.Text)) == true)
      {
        MessageBox.Show(Txt_TestPrime.Text + " : est un nombre premier");
      }
      else
      {
        MessageBox.Show(Txt_TestPrime.Text + " : n'est pas un nombre premier");
      }
    }

    bool MillerRabinTest(long testnum)
    {
      // avant de commencer on verifie juste manuellement ces trois nombres.
      if (testnum == 0) return false;
      if (testnum == 1) return false;
      if (testnum == 2) return true;

      // Pour le reste on applique la methode de Miller Rabin.
      Random rnd = new Random();
      long var1, var2 = 0;
      long var3 = testnum - 1;
      long testnumLog = Convert.ToInt32(Math.Log(testnum, 2));

      while (var3 % 2 == 0)
      {
        var3 /= 2;
        var2++;
      }
      
      for (int rec = 0; rec < testnumLog; rec++)
      {
        var1 = rnd.Next(2, (int)testnum - 1);
        long num = (long)BigInteger.ModPow(var1, var3, testnum);
        if (num == 1 || num == testnum - 1)
          continue;
        for (int rec2 = 0; rec2 < var2 - 1; rec2++)
        {
          num = (long)BigInteger.ModPow(num, 2, testnum);
          if (num == 1) return false;
          if (num == testnum - 1) break;
        }
      
        if (num != testnum - 1) return false;
      }
      
      return true;
    }

    private void Btn_GenAtkin_Click(object sender, EventArgs e)
    {
      // CRIBLE D'ATKIN
      // Ici on s'assure juste que l'utilisateur à rentré un nombre correct
      try
      {
        int number = Int32.Parse(Txt_ValueMax3.Text);
        if (number < 5)
        {
          MessageBox.Show("La valeur minimum prise en compte est : 5 ");
          return;
        }

        if (number > 715827882)
        {
          MessageBox.Show("La valeur maximum prise en compte est : 715 827 882 ");
          return;
        }
      }
      catch (FormatException)
      {
        MessageBox.Show("Entrez une valeur numerique correcte");
        return;
      }

      StringBuilder result = new StringBuilder();  // C'est une chaine de caractere qui vas servir à la sauvegarde du resultat et non au calcul.
      int nbprime = 0;             // Sert a compter combien de nombre premier on a trouvé

      int limit = Int32.Parse(Txt_ValueMax3.Text);

      bool[] myBoolArray = new bool[limit + 1];
      int n;

      int Racine_limit = (int)Math.Sqrt(limit);

      // On declanche le chronometre pour connaitre le temps de calcul.
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();

      // --------------- Debut du calcul des nombres premiers.
      for (int i = 0; i <= limit; i++)
      {
        myBoolArray[i] = false;
      }

      myBoolArray[2] = true;
      myBoolArray[3] = true;

      int var1 = 0;
      for (int rec = 1; rec <= Racine_limit; rec++)
      {
        var1 += 2 * rec - 1;
        int var2 = 0;
        for (int rec2 = 1; rec2 <= Racine_limit; rec2++)
        {
          var2 += 2 * rec2 - 1;

          n = 4 * var1 + var2;
          if ((n <= limit) && (n % 12 == 1 || n % 12 == 5))
          {
            myBoolArray[n] = !myBoolArray[n];
          }

          // n = 3 * x2 + y2; 
          n -= var1;
          if ((n <= limit) && (n % 12 == 7))
          {
            myBoolArray[n] = !myBoolArray[n];
          }

          // n = 3 * x2 - y2;
          n -= 2 * var2;
          if ((rec > rec2) && (n <= limit) && (n % 12 == 11))
          {
            myBoolArray[n] = !myBoolArray[n];
          }
        }
      }

      for (int i = 5; i <= Racine_limit; i++)
      {
        if (myBoolArray[i])
        {
          n = i * i;
          for (int j = n; j <= limit; j += n)
          {
            myBoolArray[j] = false;
          }
        }
      }

      // --------------- Fin du calcul des nombres premiers.

      // On arrete le chronometre pour connaitre le temps de calcul.
      stopWatch.Stop();
      TimeSpan ts = stopWatch.Elapsed;
      string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

      Txt_Time.Text = elapsedTime;


      for (int PosX = 2; PosX < limit; PosX++)
      {
        if (myBoolArray[PosX])
        {
          // On converti les nombres en une chaine de caractere dont les differentes valeurs sont séparés par des points virgule.
          // Cette opération ne sert que pour la futur sauvegarde au format texte csv.
          result.Append(PosX.ToString());
          result.Append(";");

          // On calcul combien de nombre premier on a trouvé.
          nbprime++;
        }
      }

      // On affiche la quantité de nombre premiers trouvés
      Txt_nbprime.Text = nbprime.ToString();

      // On affiche une boite de dialogue de sauvegarde à l'ecran pour specifier le fichier à sauvegarder.
      SaveFileDialog saveFileDialog1 = new SaveFileDialog
      {
        Filter = "Text|*.txt",
        Title = "Sauvegarde de la liste des nombres premiers au format csv."
      };

      saveFileDialog1.ShowDialog();

      // Si le nom de fichier n'est pas vide on crée le fichier pour la sauvegarde du resultat.
      if (saveFileDialog1.FileName.Length != 0)
      {
        FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
        StreamWriter sr = new StreamWriter(fs);
        sr.WriteLine(result.ToString());
        sr.Close();
        fs.Close();
      }
    }
  }
}



