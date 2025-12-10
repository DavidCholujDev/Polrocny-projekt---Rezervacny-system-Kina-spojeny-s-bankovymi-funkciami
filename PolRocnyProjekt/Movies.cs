using System;
using System.Collections.Generic;
using System.Text;

namespace PolRocnyProjekt
{
    internal class Movies
    {
        public void ReadMovies()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\Movie.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
        }



    }
}
