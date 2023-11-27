// See https://aka.ms/new-console-template for more information


using Opdracht1;

List<Persoon> Personen = new List<Persoon>();

Persoon eerste = new Persoon();
eerste.Voornaam = "Jan";
eerste.Achternaam = "Jansen";
Personen.Add(eerste);

//Taak 1: Maak nog een Persoon object aan met de variabelenaam tweede (tip: regel 8 lijkt er heel erg op)

//Taak 2: Zet de Voornaam van het Persoon object met de variabelenaam op "Henk"
//        Zet de achternaam op "Janssen"

//Taak 3: Voeg dit object toe aan de Lijst met de naam Personen

//Taak 4: Voeg de volgende personen toe (herhaal Taak 1 t/m 3), gebruik wel nieuwe variabelenaam:
//Willem Tell
//Ronald Trump
//Truus Hendriksen



//Taak 5: Maak nog een persoon-object  aan 
// Vraag de voornaam een de gebruiker en plaats deze in de voornaam eigenschap
// Vraag de achternaam aan de gebruiker en plaats deze in de achternaam eigenschap

//Taak 6: Voeg ook deze persoon toe aan de lijst met de naam Personen)


//Taak 7: Vul onderstaande for-loop aan om zo 5 personen toe te voegen
for(int i =1; i <= 5; i++)
{
   //maak een nieuw persoon object aan
   //vraag en vul de eigenschappen (voornaam en achternaam)
   //voeg object toe aan de lijst Personen
}

foreach(var eenpersoon in Personen)
{
    Console.WriteLine(eenpersoon.Voornaam + " " + eenpersoon.Achternaam);
}


