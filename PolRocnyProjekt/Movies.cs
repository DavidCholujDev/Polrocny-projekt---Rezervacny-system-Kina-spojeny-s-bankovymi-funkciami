namespace PolRocnyProjekt;



class Movies
{
    public void Run(string selectedMovieFromStageA, string fileName)
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
        string filePath = Path.Combine(folder, fileName);



        string[] movies = File.ReadAllLines(filePath);


        string matchedLine = null;

        foreach (string line in movies)
        {
            
            
                if (line.Contains(selectedMovieFromStageA, StringComparison.OrdinalIgnoreCase))
                {
                    matchedLine = line;
                    break;
                }
            

        }

        if (matchedLine == null)
        {
            Console.WriteLine("Film nebol nájdený v subore");
            return;
        }

        string[] movieData = matchedLine.Split(';');
        string selectedMovie = movieData[0];
        decimal moviePrice = 27;

        Console.WriteLine("Vybrali ste film: " + selectedMovie);
        Console.WriteLine("Cena filmu: " + moviePrice + " €");

        decimal totalPrice = moviePrice;
        Console.WriteLine("Chcete občerstvenie? A = áno, N = nie");
        string snackChoice = Console.ReadLine().ToUpper();

        decimal popcornPrice = 2m;
        decimal nachosPrice = 2.5m;
        decimal sladPrice = 1m;
        decimal drinkPrice = 2.5m;

        if (snackChoice == "A")
        {
            Console.WriteLine("1) Popcorn 2m  2) Nachos 2.5m  3) Sladkosti 1m  4) Nápoj 2.5m");
            Console.Write("Vyber číslo: ");
            string snackNum = Console.ReadLine();

            if (snackNum == "1")
            {
                totalPrice += popcornPrice;
                Console.WriteLine("Pridaný Popcorn 2m");
            }
            else if (snackNum == "2")
            {
                totalPrice += nachosPrice;
                Console.WriteLine("Pridané Nachos 2.5m");
            }
            else if (snackNum == "3")
            {
                totalPrice += sladPrice;
                Console.WriteLine("Pridané Sladkosti 1m");
            }
            else if (snackNum == "4")
            {
                totalPrice += drinkPrice;
                Console.WriteLine("Pridaný Nápoj 2.5m");
            }
            else
            {
                Console.WriteLine("Žiadne občerstvenie pridané.");
            }
        }

        Console.WriteLine("Celková cena: " + totalPrice + " €");
        Console.WriteLine("Stlačte kláves pre posun dalej");
        Console.ReadKey();
    }
}

