
//challenge reverse the string

string pangram = "The quick brown fox jumps over the lazy dog";

//separate the string into substrings
string[] substrings = pangram.Split(' ');

//create storage of length of the new substring
string[] newMessage = new string[substrings.Length];

//grab substrings and reverse them then place them in newMessage
for (int i = 0; i < newMessage.Length; i++)
{
    char[] letters = substrings[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//combine reversed substrings into one string
string result = string.Join(" ", newMessage);
System.Console.WriteLine(result);