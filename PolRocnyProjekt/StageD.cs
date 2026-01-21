using System;
using System.Collections.Generic;
using System.Text;

namespace PolRocnyProjekt
{
    internal class StageD : StageA
    {
        int SeatingSpace = 200;

        internal string ReadMoviesD()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageDmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            var usrinput = Console.ReadLine();
            return usrinput;
        }
    }
}
