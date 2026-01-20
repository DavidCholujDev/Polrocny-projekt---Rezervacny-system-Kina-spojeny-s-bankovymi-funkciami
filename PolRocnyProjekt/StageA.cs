using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolRocnyProjekt
{
    internal class StageA
    {


        int TotalNumberOfSeats = 250;


        internal string StageAMovieList()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageAmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            Console.WriteLine("Ktory film si prajes, dobrodruh?");
            string SpecificedMovie = Console.ReadLine();
            return SpecificedMovie;
        }
        
        internal void Seats(string  SpecifiedMovie)
        {

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string SeatPath = folder + @"\SeatsA.txt";
            string TakenSeats = File.ReadAllText(SeatPath);
            Console.WriteLine($"Zabrane miesta su {TakenSeats}");
            Console.WriteLine($"Prajete si film {SpecifiedMovie}. Zadajte cislo miesta o ktore mate zajem. ");
            var usrinput = Console.ReadLine();
            
            
            // tu curaj vsunie svoje sedacky pre jednu triedu 
            
            string text = usrinput + ",";
            File.AppendAllText(SeatPath, text);


        }
    }
}