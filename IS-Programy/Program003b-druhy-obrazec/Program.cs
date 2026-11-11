string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("********************************************");
    Console.WriteLine("************ vykreslování obrazce N ********");
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Natáie Slabá *******************");
    Console.WriteLine("********************************************");
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
    Console.WriteLine($"Výška: {height};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    // *










    // Jádro vykreslení algoritmu
    // Vnější cyklus - počet řádků
for (int i = 0; i < height; i++)
{
    // Určí vzdálenost od horního nebo dolního okraje
    int vzdalenost = Math.Min(i, height - 1 - i);

    // Vnitřní cyklus - počet sloupců
    for (int j = 0; j < height; j++)
    {
        if (j >= height / 2 - 1 - vzdalenost &&
            j <= height / 2 + vzdalenost)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }

        System.Threading.Thread.Sleep(250);
    }

    Console.WriteLine();
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