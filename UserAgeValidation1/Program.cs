// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter your age");
int userAge = Int32.Parse(Console.ReadLine());
if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("you are too young to use Instagram!");
}
