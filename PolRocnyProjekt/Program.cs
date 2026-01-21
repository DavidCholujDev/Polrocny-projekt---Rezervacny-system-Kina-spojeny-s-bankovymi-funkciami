// made by @vajconos , gpt  @david_chol1 on instagram
//sponsored by Kros a. s



using PolRocnyProjekt;


Console.SetCursorPosition(30, 50);
Console.WriteLine("Vitaj v online systeme Kina, kde si zakupujes listky. Zadaj cislo saly od 1 po 4, ak chces vidiet vsekty filmy zadaj cislo 5");
var usrinput = Console.ReadLine();

if(usrinput == "1")
{
    Console.Clear();
    Stage Astage = new Stage();
    string retVal = Astage.StageA();
    Movies m = new Movies();
    m.Run(retVal, "StageAmovies.txt");
   User usr = new User();
    usr.Run();
    Console.WriteLine("dakujeme za navstevu, zbohom"); 
}

else if (usrinput == "2")
{
    Console.Clear();
    Stage bstage = new Stage();
    bstage.StageB();
   
   
}


else if (usrinput == "3")
{
    Console.Clear();
    
}

else if(usrinput == "4")
{
    Console.Clear();
   
}
else if (usrinput == "5")
{
    Console.Clear();
    AllMovies ReadMovie = new AllMovies();
    ReadMovie.ReadMovies();

}





