string again = "a";

// řídící cyklus programu 
// ToLower () převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoli jiný vstup program ukončí
while (again.ToLower() == "a")
{

    // Dotaz směrem k uživateli, zda chce program spustit znovu
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ??;



}
    

    