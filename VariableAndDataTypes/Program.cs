using System;
// variable delaration and types

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

// prompt user for input
Console.WriteLine("Enter your Full Name");
fullName = Console.ReadLine();

Console.WriteLine("Enter your Age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Salary");
salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Gender (M OR F)");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working (True OR False)");
working = Convert.ToBoolean(Console.ReadLine());

// show result
Console.WriteLine("Your Full name is: "+ fullName);
Console.WriteLine("Your Age is: "+ age);
Console.WriteLine("Your salary is: "+ salary);
Console.WriteLine("Your gender is: "+ gender);
Console.WriteLine("You are working: "+ working);
