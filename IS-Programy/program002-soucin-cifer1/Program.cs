
string again = "a";

// Řídicí cyklus programu
// ToLower() převede vstup na malá písmena
// Jakýkoliv jiný vstup program ukončí
while (again.ToLower() == "a")
{
    // Vymazání konzole
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("****************************************");
    Console.WriteLine("*************Součin cifer**************");
    Console.WriteLine("************Natálie Slabá**************");
    Console.WriteLine("****************************************");
    Console.WriteLine();

    // Vstup počáteční hodnoty
    Console.Write("Zadejte celé číslo: ");
    int cislo;

    while (!int.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste celé číslo, zadejte číslo znovu: ");
    }

    // Příprava hodnot pro výpočet
    long pomocne = Math.Abs((long)cislo);
    long soucin = 1;

    // Výpočet součinu cifer
    do
    {
        long cifra = pomocne % 10;
        soucin = soucin * cifra;
        pomocne = pomocne / 10;

    } while (pomocne > 0);

    // Rekapitulace hodnot
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"Zadané číslo: {cislo}");
    Console.WriteLine($"Součin cifer: {soucin}");
    Console.WriteLine("================================");

    // Dotaz, zda chce uživatel program spustit znovu
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";

    
}
