/*
In this challenge, you'll work with a string that contains a fragment of HTML. 
You'll extract data from the HTML fragment, replace some of its content, and remove 
other parts of its content to achieve the desired output.

input: <div><h2>Widgets &trade;</h2><span>5000</span></div>
output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

// extract quantity
int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length);

// set output to input | replacing marks
output = input.Replace("trade", "reg"); 

// remove first <div>
int firstDivStart = input.IndexOf("<div>");
int firstDivEnd = input.IndexOf(">");
int firstDivLength = firstDivEnd - firstDivStart;
firstDivLength += 1;
output = output.Remove(firstDivStart, firstDivLength);

// remove last </div>
int lastDivStart = output.IndexOf("</div");
int lastDivEnd = output.IndexOf(">", lastDivStart);
int lastDivLength = lastDivEnd - lastDivStart;
lastDivLength += 1;
output = output.Remove(lastDivStart, lastDivLength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
