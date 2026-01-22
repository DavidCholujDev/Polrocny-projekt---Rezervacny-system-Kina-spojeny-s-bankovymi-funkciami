namespace PolRocnyProjekt;


class Movies
{
    public void Run(string SpecifiedMovie, string fileName)
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filePath = Path.Combine(folder, fileName);





        string[] movies = File.ReadAllLines(filePath);


        string matchedLine = "0";

        foreach (string line in movies)
        {


            if (line.Contains(SpecifiedMovie, StringComparison.OrdinalIgnoreCase))
            {
                matchedLine = line;
                break;

            }



        }



        string[] movieData = matchedLine.Split(';');



        Console.WriteLine("Vybrali ste film: " + SpecifiedMovie);








        Console.WriteLine("Stlačte kláves pre posun dalej");
        Console.ReadKey();

    }


    internal static decimal ChooseSnack(decimal prajs)
    {
        Console.WriteLine("Chcete občerstvenie? A = áno, N = nie");
        string snackChoice = Console.ReadLine().ToUpper();
        decimal popcorn = 2.5m;
        decimal nacho = 1.99m;
        decimal candy = 4m;
        decimal soda = 4.99m;
        decimal totalPrice = prajs;
        decimal finalprice = totalPrice;
        if (snackChoice == "A")
        {
            Console.WriteLine("1) Popcorn 2m  2) Nachos 2.5m  3) Sladkosti 1m  4) Nápoj 2.5m");
            Console.Write("Vyber číslo: ");
            string snackNum = Console.ReadLine();

            if (snackNum == "1")
            {
                finalprice = totalPrice + popcorn;
                Console.WriteLine("Pridaný Popcorn ");
            }
            else if (snackNum == "2")
            {
                 finalprice = totalPrice + nacho;
                Console.WriteLine("Pridané Nachos ");
            }
            else if (snackNum == "3")
            {
                finalprice = totalPrice + candy;
                Console.WriteLine("Pridané Sladkosti ");
            }
            else if (snackNum == "4")
            {
                finalprice = totalPrice + soda;
                Console.WriteLine("Pridaný Nápoj");
            }
            else
            {
                Console.WriteLine("Žiadne občerstvenie pridané.");
            }
            
        }
        return finalprice;
    }


    public void calc(decimal finalprice)
    {
        // i recommend reading calc.cs
        Console.WriteLine(finalprice);
    }
}

