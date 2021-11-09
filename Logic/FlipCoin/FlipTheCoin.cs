/*
In this challenge, you'll flip a coin to display either heads or tails. 

*/

var coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
