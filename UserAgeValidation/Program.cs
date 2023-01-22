// See https://aka.ms/new-console-template for more information



Console.WriteLine("Select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}