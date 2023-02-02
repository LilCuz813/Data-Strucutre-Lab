using System.Linq;

Console.WriteLine("Please enter a word you would like to reverse:");
string word = Console.ReadLine();

static string Reverse(string input)
{

    char[] letters = input.ToCharArray();

    Stack<char> lettersStack = new Stack<char>();

    foreach (char c in letters)
    {
        lettersStack.Push(c);
    }

    string output = "";

    foreach (char c in lettersStack)
    {
        output += c;
    }    
    return output;

}


Console.WriteLine($"Your word reversed is:");
Console.WriteLine(Reverse(word)); 
