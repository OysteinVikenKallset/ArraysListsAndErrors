/*
Arrays og lister:

- Lag et program som finner det største tallet i en liste med heltall.
- Lag et program som sorterer en liste med strenger i alfabetisk rekkefølge.

Feilhåndtering:

- Lag et program som ber brukeren om å skrive inn et tall, og håndter feil dersom brukeren skriver inn noe annet enn et tall.
- Lag et program som håndterer en divisjon med null og gir en tilpasset feilmelding til brukeren.

*/



// ----------- Oppgave 1: Lag et program som finner det største tallet i en liste med heltall.
int[] myNum = {10, 20, 30, 40, 20, 21};
string[] myStrings = {"Lars", "Jonas", "Elina", "Loukas", "Anders", "Øystein G", "Øystein K", "Fredrik", "Frode", "Andreas", "Vegard", "Maria", "Espen"};


//Metode for å finne det største tallet
int findGreatesNumber(int[] array){
    return array.Max();
}

//Skriver ut resultatet på oversiktlig måte
Console.WriteLine("Mitt Array ser slik ut: ");
foreach (int item in myNum)
{
    Console.Write(item + ", ");
}

Console.WriteLine($"Det største nummeret er: {findGreatesNumber(myNum)}");
Console.WriteLine("");


// ----------- Oppgave 2: Lag et program som sorterer en liste med strenger i alfabetisk rekkefølge.

//Metode for å finne det største tallet

foreach (string item in myStrings)
{
    Console.Write(item + ", ");
}
Console.WriteLine("");
Console.WriteLine("Sort Array: ");

// Sort a string

Array.Sort(myStrings);

foreach (string item in myStrings)
{
    Console.Write(item + ", ");
}

// ----------- Oppgave 3: Lag et program som ber brukeren om å skrive inn et tall, og håndter feil dersom brukeren skriver inn noe annet enn et tall.
// ----------- Oppgave 4: Lag et program som håndterer en divisjon med null og gir en tilpasset feilmelding til brukeren.

bool validInput = false;
double userInput = 0;

Console.WriteLine("");
Console.WriteLine("Skriv inn et tall, gjerne 0");

while(!validInput){


 validInput = double.TryParse(Console.ReadLine(), out userInput);
 if(!validInput){
    Console.WriteLine("Du må skrive inn et heltall");
 }
}
Console.WriteLine($"Du skrev inn: {userInput}");

try
{
    Console.WriteLine($"10/{userInput} = {10/userInput}");
}
catch (System.DivideByZeroException)
{
    
    Console.WriteLine("Du delte på 0, det er ikke mulig. ");
}






