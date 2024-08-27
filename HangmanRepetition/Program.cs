string word = "KokosKaka";

/*

Bestämma ord
Visa hur många bokstäver med _
Ta en ny gissning

Om gissning finns i ordet:
 Skriver på respektive plats

Annars
 Lägger till bokstaven till felaktiv gissning
 Rita ett till steg av gubben

Fortsätt tills gubben dör eller ordet gissas rätt

*/

List<char> wrongGuesses = [];
List<char> hiddenWord = new() {'_', '_', '_', '_', '_', '_', '_', '_', '_'};

int lives = 10;

while(wrongGuesses.Count < lives)
{
    Console.WriteLine(string.Join(" ", hiddenWord));

    // foreach (char letter in hiddenWord)
    // {
    //     Console.Write(letter);
    // }

    char guess = Console.ReadLine()[0];

    if (word.Contains(guess) == true)
    {
        Console.WriteLine("Helt rätt!");
    }

    else
    {
        Console.WriteLine("Inte riktigt..");
        wrongGuesses.Add(guess);
    }
}
Console.WriteLine("Aj de gg");
Console.ReadLine();