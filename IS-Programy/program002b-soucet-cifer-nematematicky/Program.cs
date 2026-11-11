
string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{
    // Vymazání console
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("**********************************************");
    Console.WriteLine("******************součet cifer nematematicky**");
    Console.WriteLine("**********************************************");
    Console.WriteLine("*****************Natálie Slabá****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    // Načtení celého čísla
    Console.Write("Zadejte celé číslo: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo, zadejte číslo znovu: ");
    }

    // Rekapitulace hodnot
    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("===============================");
    Console.WriteLine();

    // Převedení čísla na text bez znaménka minus
    string cislo = Math.Abs((long)number).ToString();

    // Počáteční hodnota součtu
    int soucet = 0;

    // Výpočet součtu cifer
    foreach (char znak in cislo)
    {
        int cifra = znak - '0';
        soucet = soucet + cifra;
    }

    // Výpis výsledku
    Console.WriteLine("Výsledek součtu cifer:");
    Console.WriteLine($"Součet cifer čísla {number} je {soucet}.");

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
    
}
