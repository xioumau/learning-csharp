/*
In this challenge, you'll implement business rules that restrict access to users based 
on their permissions and their level. You'll display a different message to the user 
depending on their permissions and level.

To test your Boolean expression logic, use the following code of sample data.
string permission = "Admin|Manager";
int level = 55;

Business Rules

1 - If the user is an Admin with a level greater than 55, output the message:
Output:
Welcome, Super Admin user.

2 - If the user is an Admin with a level less than or equal to 55, output the message:
Output:
Welcome, Admin user.

3 - If the user is a Manager with a level 20 or greater, output the message:
Output:
Contact an Admin for access.

4 - If the user is a Manager with a level less than 20, output the message:
Output
You do not have sufficient privileges.

5 - If the user is not an Admin or a Manager, output the message:
Output:
You do not have sufficient privileges.

When you run the code, including the sample data from Step 2, you should see the following output:
Welcome, Admin user.

*/

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
