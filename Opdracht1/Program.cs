// See https://aka.ms/new-console-template for more information


using Opdracht1;

List<Persoon> Personen = new List<Persoon>();

Persoon eerste = new Persoon();
eerste.Naam = "Jan";
Personen.Add(eerste);

//Taak 1: Maak nog een Persoon object aan met de variabelenaam tweede
//Taak 2: Zet de naam van het Persoon object met de variabelenaam op "Henk"
//Taak 3: Voeg dit object toe aan de Lijst met de naam Personen



foreach(var eenpersoon in Personen)
{
    Console.WriteLine(eenpersoon.Naam);
}

