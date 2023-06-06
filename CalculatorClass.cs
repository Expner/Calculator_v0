internal class Calculator
{
    public int Result { get; set; }
    public int NumberOne { get; set; }
    public int NumberTwo { get; set; }

    public void Plus(int NumberOne, int NumberTwo)
    {
        Result = NumberOne + NumberTwo;
        Console.WriteLine($"Result is {Result}");
    }
    public void Minus(int NumberOne, int NumberTwo)
    {
        Result = NumberOne - NumberTwo;
        Console.WriteLine($"Result is {Result}");
    }
    public void Multyply(int NumberOne, int NumberTwo)
    {
        Result = NumberOne * NumberTwo;
        Console.WriteLine($"Result is {Result}");
    }
    public void Divide(int NumberOne, int NumberTwo)
    {
        Result = NumberOne / NumberTwo;
        Console.WriteLine($"Result is {Result}");
    }

    public Calculator(int NumberOne, int NumberTwo)
    {
        this.NumberOne = NumberOne;
        this.NumberTwo = NumberTwo;
    }
}