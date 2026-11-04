Console.WriteLine("Hello, World!");
﻿string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("************ Ciferný součet *************");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Natálie Slabá *************");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení první hodnoty 
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem

    // Příprava pomocných proměnných pro výpočet
    int numberBackup = number;
    int sum = 0;    // Neutrální hodnota pro sčítání je 0
    int digit;      // Proměnná pro uložení právě zjištěné číslice

    //ošetření záporných čísel (znaménko má vliv na číslice)
    if (number < 0)
    {
        number = -number; // Záporné číslo převedeme na kladné
    }

    // zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice(zprava doleva)");

        //Matematický rozklad čísla pomocí cyklu
        //využíváme operaci modulo - což je  určení zbytku po celočíselném dělení
        while (number > 0)
        {
           digit = number % 10; //Modulo 10 - získáme poslední číslici
           sum = sum + digit;   // přičtení číslice k celkovému součtu

           Console.WriteLine($"Získaná číslice: {digit}");

           number = number  / 10; // celočíselné dělení 10 odstraní poslední číslici

        }
    }
    

//výpis výsledků
Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine($"Součet číslic čísla {numberBackup} je {sum}");


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}

