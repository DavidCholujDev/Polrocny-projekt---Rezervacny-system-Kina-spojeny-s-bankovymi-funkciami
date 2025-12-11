// made by @vajconos , @matej.k_15 + gpt,  @david_chol1 on instagram
//sponsored by Kros a. s


using PolRocnyProjekt;


var usrinput = Console.ReadLine();

if(usrinput == "1")
{
    Console.Clear();
    StageA Astage = new StageA();
    Astage.StageAMovieList();
    StageA.DrawGridOfSeats();
    
}

else if (usrinput == "2")
{
    Console.Clear();
    StageB Bstage = new StageB();
    Bstage.ReadMovieB();  
}


else if (usrinput == "3")
{
    Console.Clear();
    StageC Cstage = new StageC();
    Cstage.MovieList();
}

else if(usrinput == "4")
{
    Console.Clear();
    StageD Dstage = new StageD();
    Dstage.ReadMoviesD();
}
else if (usrinput == "5")
{
    Console.Clear();
    Movies ReadMovie = new Movies();
    ReadMovie.ReadMovies();

}





