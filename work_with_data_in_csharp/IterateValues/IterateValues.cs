/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

Add all the code necessary to implement the following business rules:

Business Rules:

Rule 1: If the value is alphanumeric, concatenate it to form a message

Rule 2: If the value is numeric, add it to the total

Rule 3: Make sure the result matches the following output:

output:
Message: ABCDEF
Total: 68.3

*/

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
