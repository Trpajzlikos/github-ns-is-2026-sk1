string again = "a";

// řídící cyklus programu 
// ToLower () převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{

    // vymazání console
    Console.Clear();

    //hlavička programu
    Console.WriteLine("**********************************************");
    Console.WriteLine("******************Výpis z řady****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("*****************Natálie Slabá****************");
    Console.WriteLine("**********************************************");
    
    // Vstup počáteční hodnoty
    Console.Write("Zadejte počáteční hodnotu (celé číslo): ");
    int first;
    while (!int.TryParse (Console.ReadLine(), out first))
    {
        Console.Write ("Nezadali jste celé číslo, zadejte první číslo řady znovu: ");
    }
   

// Načtení koncové hodnoty řady
    Console.Write("Zadejte poslední hodnotu (celé číslo): ");
    int last;
    while (!int.TryParse (Console.ReadLine(), out last))
    {
        Console.Write ("Nezadali jste celé číslo, zadejte poslední číslo řady znovu: ");
    }
    

    // Načtení diference s kontrolou kladného čísla
        Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse (Console.ReadLine(), out step) || step <= 0) 
    {
        Console.Write ("Nezadali jste kladné celé číslo, zadejte diferenci znovu: ");
    }
    
    
    
    
    // Dotaz směrem k uživateli, zda chce program spustit znovu
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";



}
    

    