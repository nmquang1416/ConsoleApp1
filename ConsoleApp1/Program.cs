// See https://aka.ms/new-console-template for more information

using ConsoleApp1.exercise01;
using ConsoleApp1.exercise02;

People people = new People();

people.name = "quang";
people.gender = true;
people.age = 20;
string gender;
if (people.gender)
{
     gender = "Male";
}
else
{
     gender = "Female";
}

Console.WriteLine("Simple Properties Demo");
Console.WriteLine("Person details:");
Console.WriteLine("Name:" + people.name);
Console.WriteLine("Gender:" + gender);
Console.WriteLine("Age:" + people.age);

people.age = 20 + 10;

Console.WriteLine("Person details:");
Console.WriteLine("Name:" + people.name);
Console.WriteLine("Gender:" + gender);
Console.WriteLine("Age:" + people.age);


//bai thi 2
// Accept the string and word from the user
Console.Write("Enter a string: ");
string inputString = Console.ReadLine();

Console.Write("Enter a word to search: ");
string wordToSearch = Console.ReadLine();

Console.WriteLine();



