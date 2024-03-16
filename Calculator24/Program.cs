double Add(double a, double b)
{
    return a + b;
}

double Multiply(double a, double b)
{
    return a * b;
}

double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new InvalidOperationException("Cannot divide by zero!");
    }

    return a / b;
}

double Subtract(double a, double b)
{
    return a - b;
}

double Power(double a, double b)
{
    return Math.Pow(a, b);
}

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

Console.Write("Operation (+, -, *, /, ^): ");
char op = Console.ReadKey().KeyChar;

double result = 0;
switch (op)
{
    case '+':
        result = Add(a, b);
        break;
    case '-':
        result = Subtract(a, b);
        break;
    case '*':
        result = Multiply(a, b);
        break;
    case '/':
        result = Divide(a, b);
        break;
    case '^':
        result = Power(a, b);
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}
Console.WriteLine();
Console.WriteLine(result);