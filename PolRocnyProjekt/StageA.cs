using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolRocnyProjekt
{
    internal class StageA
    {


        int TotalNumberOfSeats = 250;

        internal void StageAMovieList()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageAmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
        }
        internal static void DrawGridOfSeats()
        {

            int rows = 10;
            int cols = 25;

            
            Console.Write("    "); 
            for (int col = 0; col < cols; col++)
            {
                string label = $"{col + 1}";
                Console.Write(label.PadLeft(4));
            }
            Console.WriteLine();

            
            for (int row = 0; row < rows; row++)
            {
                char rowLetter = (char)('A' + row);

            
                Console.Write($" {rowLetter}  ");

                
                for (int col = 0; col < cols; col++)
                    Console.Write("+---");
                Console.WriteLine("+");

                Console.Write("    ");
                for (int col = 0; col < cols; col++)
                    Console.Write("|   ");
                Console.WriteLine("|");
            }

            
            Console.Write("    ");
            for (int col = 0; col < cols; col++)
                Console.Write("+---");
            Console.WriteLine("+");


        }
    }
}
