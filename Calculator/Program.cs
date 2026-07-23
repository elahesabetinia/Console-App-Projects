int num1;
int num2;

string answer;
int result;

Console.WriteLine("Hello, Welcome to the calculator program!");
Console.WriteLine("Enter your first number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number:");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What type of operation would you like to do?");
Console.WriteLine("Please enter + for addition,- for subtraction,* for multiplication,or any other key for division");
answer = Console.ReadLine();

if (answer == "+")
{
    result = num1 +num2;
}
else if (answer == "-")
{ 
    result = num1 - num2;
}
else if (answer == "*")
{ 
    result = num1 * num2;
}
else 
{ 
    result = num1 / num2;
}

Console.WriteLine($"{num1} {answer} {num2} = {result}");
Console.WriteLine("Thank you for using this calculator!");
Console.ReadKey();