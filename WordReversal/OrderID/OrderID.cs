/*

you'll need to parse Order IDs out of a string containing a sequence of incoming orders 
(the orderStream). Then, you'll print each Order ID that starts with the letter "B".

input: B123,C234,A345,C15,B177,G3003,C235,B179
output:
B123
B177
B179

*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);

foreach (var item in orderArray)
{
    if (item.StartsWith("B"))
        Console.WriteLine(item);    
}
