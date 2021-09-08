/*
Suppose we work for a souvenir shop in a college town that sells t-shirts, sweatshirts, and 
other gifts with the school's logo and colors. A monthly sales report uses the full description 
as well as the Stock Keeping Unit (SKU) of the products sold. We've been asked to rewrite certain 
portions of the code to make it more readable. One of the tasks is to simplify the conversion of 
a SKU into a description using the switch statement.

The following code converts a SKU into a long-form description (for example, the sku 01-MN-L is 
a "large maroon sweat shirt").

input: "01-MN-L"
output: Product: Large Maroon Sweat shirt

*/

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
