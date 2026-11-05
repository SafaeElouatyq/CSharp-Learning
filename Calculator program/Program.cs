
double num1, num2, result;
String operation;


Console.WriteLine("------------------------");
Console.WriteLine("---Calculator Program---");
Console.WriteLine("------------------------");

Console.Write("Enter first number:");
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number:");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("enter operation (+, -, *, /):");
operation = Console.ReadLine();

switch (operation) {
    case "+":
        result = num1 + num2;
        Console.WriteLine("Result : "+num1 +" "+operation +" "+ num2 +" = " + result);

        Console.WriteLine("------------------------");
    break;
    case "-":
        result = num1 - num2;
        Console.WriteLine("Result : " + num1 + " " + operation + " " + num2 + " = " + result);

        Console.WriteLine("------------------------");
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine("Result : " + num1 + " " + operation + " " + num2 + " = " + result);

        Console.WriteLine("------------------------");
        break;
    case "/":
        result = num1 / num2;
        Console.WriteLine("Result : " + num1 + " " + operation + " " + num2 + " = " + result);

        Console.WriteLine("------------------------");
        break;

    default:
        Console.WriteLine("Invalid operation");
        break;
}
