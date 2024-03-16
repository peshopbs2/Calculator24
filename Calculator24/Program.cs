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