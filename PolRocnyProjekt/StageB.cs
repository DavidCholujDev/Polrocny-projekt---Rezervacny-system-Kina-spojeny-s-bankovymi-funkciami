using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolRocnyProjekt
{
    internal class StageB : StageA
    {
        int SeatingSpace = 150;
      internal string ReadMovieB()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageBmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            var usrinput = Console.ReadLine();
            return usrinput;
        }
    }

}
