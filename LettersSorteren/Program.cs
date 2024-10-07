
Console.WriteLine("Geef een woord");
string input = Console.ReadLine();
char[] characters = input.ToArray();
Array.Sort(characters);
Console.WriteLine(characters);
Console.ReadLine();