// made by @vajconos , @matej.k_15  @david_chol1 on instagram
//sponsored by Kros a. s


using PolRocnyProjekt;

Console.WriteLine("Vitaj v online systeme rezervacie kina");
Console.WriteLine("Ukazeme ti zoznam filmov kere sa budu premiet v celom kine");
var usrinput = Console.ReadLine();



if (usrinput == "4")
{
    Console.Clear();
    Movies ReadMovie = new Movies();
    ReadMovie.ReadMovies();

}



