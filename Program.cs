using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("       Simple Calculator      ");
        Console.WriteLine("/n Enter 1st Number :");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("/n Enter Second Number :");
        int b = Convert.ToInt32(Console.ReadLine());    

        Console.WriteLine("Enter The operation ( + , - , x , / , % ");
        char oper = Convert.ToChar(Console.ReadLine());

    switch (oper)
            {

            case '+':
                Console.WriteLine("Addition : " + a + b);
                break;

            case '-':
                Console.WriteLine("Addition : " + a - b);
                break;

            case '*':
                Console.WriteLine("Multiplication :" + a * b);
                break;

            case '/':
                Console.WriteLine("Division :" + a / b);
                break;

            case '%':
                Console.WriteLine("Remainder : " + a % b);
                break;

            Default:
                Console.WriteLine("Invalid operator");
            }
        }
}
