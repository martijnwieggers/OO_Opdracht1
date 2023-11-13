// See https://aka.ms/new-console-template for more information


using Opdracht1;

List<Persoon> Personen = new List<Persoon>();

Persoon eerste = new Persoon();
eerste.Voornaam = "Jan";
Personen.Add(eerste);

//Taak 1: Maak nog een Persoon object aan met de variabelenaam tweede (tip: regel 8 lijkt er heel erg op)

//Taak 2: Zet de naam van het Persoon object met de variabelenaam op "Henk"

//Taak 3: Voeg dit object toe aan de Lijst met de naam Personen



foreach(var eenpersoon in Personen)
{
    Console.WriteLine(eenpersoon.Voornaam);
}

//Taak 4: Ga naar persoon.cs en voor daar de taken uit om Achternaam toe te voegen

//Taak 8: Stel de achternaam van ieder Persoon object dat je aanmaakt in op "Jansen"

//Taak 9: Pas binnen de foreach aan, zodat Voornaam en Achternaam achter elkaar worden afgedrukt.

