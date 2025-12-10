using System;
using System.Collections.Generic;
using System.Text;

namespace PolRocnyProjekt
{
    internal class StageC : StageA
    {
        int SeatingSpace = 150;
    internal void MovieList()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageCmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
        }
    
    }
}
