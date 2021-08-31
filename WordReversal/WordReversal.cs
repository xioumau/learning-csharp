/*
Write the code necessary to reverse the letters of each word in place and display the result. 
In other words, don't just reverse every letter in the variable pangram. Instead, you'll need 
to reverse just the letters in each word, but print the reversed word in it's original position 
in the message.

input: The quick brown fox jumps over the lazy dog
output: ehT kciuq nworb xof spmuj revo eht yzal god

*/

string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length]; // number of words

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray(); // array of letters
    Array.Reverse(letters); 
    newMessage[i] = new string(letters); // add reversed letter to newMessage
}

string result = string.Join(" ", newMessage); 
Console.WriteLine(result);
