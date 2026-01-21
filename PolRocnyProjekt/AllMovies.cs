using System;
using System.Collections.Generic;
using System.Text;

namespace PolRocnyProjekt
{
    internal class AllMovies
    {
        public string ReadMovies()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\Movie.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            var usrinput = Console.ReadLine();
            return usrinput;
        }
    }
}
