/*
Working for a marketing department of a financial services company. To promote the company's 
newest investment products, we'll send thousands of personalized letters to our company's 
existing clients. Our job is to write C# code that will merge personalized information about 
the customer. The letter will contain information like their existing portfolio and will compare 
their current returns to projected returns if they were to invest in using our new products.

Our writers have decided on the following example marketing copy. Here's the desired output 
(using fictitious customer account data).

output: 
"Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product 
that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your 
potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00"
*/

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2} Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = currentProduct.PadRight(15);
comparisonMessage += $"{currentReturn:P2}".PadLeft(16);
comparisonMessage += $"{currentProfit:C}".PadLeft(17) + "\n";

comparisonMessage += newProduct.PadRight(15);
comparisonMessage += $"{newReturn:P2}".PadLeft(16);
comparisonMessage += $"{newProfit:C}".PadLeft(17);

Console.WriteLine(comparisonMessage);
