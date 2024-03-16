﻿int Add(int a, int b)
{
    return a + b;
}

int Multiply(int a, int b)
{
    return a * b;
}

int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new InvalidOperationException("Cannot divide by zero!");
    }

    return a / b;
}