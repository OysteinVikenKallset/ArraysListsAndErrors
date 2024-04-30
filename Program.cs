int[] myNum = {10, 20, 30, 40, 20, 21};
bool validInput = false;
int userInput = 0;

int findGreatesNumber(int[] array){
    return array.Max();
}

Console.WriteLine(findGreatesNumber(myNum));
Console.WriteLine("");

Console.WriteLine("Skriv inn et tall");

while(!validInput){

 validInput = int.TryParse(Console.ReadLine(), out userInput);
 if(!validInput){
    Console.WriteLine("Du må skrive inn et heltall");
 }
}
Console.WriteLine(userInput);

try
{
    Console.WriteLine(10/userInput);
}
catch (System.DivideByZeroException)
{
    
    Console.WriteLine("Du delte på 0, det er ikke mulig. ");
}






