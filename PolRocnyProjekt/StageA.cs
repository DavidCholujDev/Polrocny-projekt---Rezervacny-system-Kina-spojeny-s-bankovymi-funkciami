using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolRocnyProjekt
{
    internal class Stage
    {


        int TotalNumberOfSeats = 250;


        internal string StageA()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageAmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            Console.WriteLine("Ktory film si prajes, dobrodruh?");
            string SpecificedMovie = Console.ReadLine();
            return SpecificedMovie;
        }
        internal string StageB()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageBmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            string specifiedMovie = Console.ReadLine();
            return specifiedMovie;
        }
        internal string StageC()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string MovieFiles = folder + @"\StageCmovies.txt";
            string Movies = File.ReadAllText(MovieFiles);
            Console.WriteLine(Movies);
            string specifiedMovie = Console.ReadLine();
            return specifiedMovie;
            

        }
    }
}