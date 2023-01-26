// See https://aka.ms/new-console-template for more information

// Prototypes - Defines the function (types, name and parameters)
// Definition - Has the code. It contains the code block
// Function call - Makes the function
// DRY - Don't Repeat Yourself
// YAGNI - You Aren't GOing to Need It

//Void Functions - Completes a task and moves along

void PrintName()
{
    Console.WriteLine("Jorney");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"Num 1 {num1} and Num 2{num2} result: {num1 + num2}");
}

PrintName();

Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the secound number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number");
int num3 = Convert.ToInt32(Console.ReadLine());

Addition(num1, num2);

// Value returning functions - completes a task, returns a result

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest < num2)
        largest = num2;

    if (largest < num3)
        largest = num3;

    return largest;
}

int result = LargestNumber(num1, num2, num3);
Console.WriteLine(result);