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
    Console.WriteLine("*******Generátor - max a min, hodiny********");
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

// Generování náhodných čísel a jejich uložení do pole
Console.WriteLine("Vygenerovaná pseudonáhodná čísla:");
for (int i = 0; i < myRandNumbs.Length; i++)
{
    //
    myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
    Console.Write($"{myRandNumbs[i]};");
}

//hledání maxima a minima, a jejich prvních pozic
int max = myRandNumbs [0];
int min = myRandNumbs [0];
int posMax = 0; //pozice prvního maxima
int posMin = 0; //pozice prvního minima

for (int i = 1; i < n; i++)
    {
        //zjišťujeme maximum zda Itý prvek není větší než aktualní maximum
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
    }
    //zjišťujeme minimum zda Itý prvek není menší než aktualní minimum
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }


Console.WriteLine();
 Console.WriteLine("==============================================");
 Console.WriteLine($"Maximum: {max}");
 Console.WriteLine($"Pozice prvního maxima: {posMax}");
 Console.WriteLine($"Minimum: {min}");
 Console.WriteLine($"Pozice prvního minima: {posMin}");


//vykreslení přesýpacích hodin
if (max >= 3)
    {
        //vnější cyklus řídící vykreslování jednotlivých řádků
      for ( int i = 0; i < max; i++)
        {
            int spaces = 0; // proměnná pro počet uvodních mezer
            int starr = 0; // proměnná pro počet hvězdiček v řádku
            if(i < max / 2)
            {
                //horní polovina
                // počet mezer je přímo úměrný proměnné i
                spaces = i;
                //počet hvězdiček ubývá o 2 na každém řádku
                stars = max - (2 * i);
            }
            else
            {
                // dolní polovina
                spaces = max - i - 1;
                stars = 2 * (i - max / 2) + 1;
                
            }
        }
    }
else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nevykreslí.");
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
