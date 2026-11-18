string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("*******Generátor pseudonáhodných čísel********");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Natálie Slabá *************");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

// Počet generovných čísel (větších než 0)
    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0) {
        Console.Write("Nezadali přirozené číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno než dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound) {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez. Zadejte horní mez znovu: ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    
// Deklarce a alokace pole v paměti
int[]myRandNumbs = new int [n];

// inicislizace generátoru náhodných čísel
Random myRandNumb = new Random();
//Random myRandNumb = new Random(50);

int positiveNumbs = 0;
int negativeNumbs = 0;
int zero = 0;

// Generování náhodných čísel a jejich uložení do pole
Console.WriteLine("Vygenerovaná pseudonáhodná čísla:");
for (int i = 0; i < myRandNumbs.Length; i++)
{
    //
   
   myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
    Console.Write($"{myRandNumbs[i]};");
    /*
    if (myRandNumbs[i] < 0)
    negativeNumbs++;
 if (myRandNumbs[i] > 0)
 positiveNumbs++;
    if (myRandNumbs[i] == 0)
    zero++;*/
    

    //eketkivnější zápis
    if (myRandNumbs[i] < 0)
        negativeNumbs++;
    else if (myRandNumbs[i] > 0)
        positiveNumbs++;
    else
        zero++;
    
    

}
Console.WriteLine();
 Console.WriteLine("==============================================");
 Console.WriteLine($"POČET ZÁPORNÝCH ČÍSEL: {negativeNumbs}");
 Console.WriteLine($"POČET Kladných ČÍSEL: {positiveNumbs}");
 Console.WriteLine($"POČET NUL: {zero}");



    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}
