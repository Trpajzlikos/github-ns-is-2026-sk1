string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("**********************************+++++***");
    Console.WriteLine("************ vykreslování obrazců ********");
    Console.WriteLine("******************************************");
    Console.WriteLine("*********** Natáie Slabá *****************");
    Console.WriteLine("******************************************");
    Console.WriteLine();
    Console.WriteLine();

    
     // Načtení výšky 
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte číslo znovu: ");
        Console.ResetColor();
    }
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($" Výška: {height};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    // *

    // Jádro vykreslení algoritmu
    // Vnější cyklus, kteý nám bude hlídat počet řádků (shora dolů)
    for(int i=1; i <= height; i++)
    {
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
        
       //vnitřní cyklus, který se nám postará o to, aby se v každém řádku vykreslil správný počet znaků
        for(int j = 1; j <= i; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(250)); // Zpoždění - program v tuto chvíli čeká
        }
       Console.WriteLine();
       // původní barva
        Console.ResetColor();
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}