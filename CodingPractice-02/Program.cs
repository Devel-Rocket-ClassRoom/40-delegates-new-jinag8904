using System;

// 1.
{
    Calculator calculator = new Calculator();
    Transformer t = calculator.Multiply;

    Console.WriteLine(t(5));
}
Console.WriteLine();

// 2.
{
    CarDriver driver = Go;
    driver += Left;
    driver += Right;

    driver();

    driver -= Left;

    driver();

    static void Go() => Console.WriteLine("직진");
    static void Left() => Console.WriteLine("좌회전");
    static void Right() => Console.WriteLine("우회전\n");
}

// 3.
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    Transform(numbers, Square);

    numbers = new int[] { 1, 2, 3, 4, 5 };
    Transform(numbers, Cube);


    static int Square(int x) => x * x;
    static int Cube(int x) => x * x * x;

    static void Transform(int[] values, Transformer2 t){

        for (int i = 0; i < values.Length; i++)
        {
            values[i] = t(values[i]);
        }
    }
}
Console.WriteLine();

// 3.
delegate int Transformer2(int i);

// 2.
delegate void CarDriver();

// 1.
delegate int Transformer(int i);

class Calculator
{
    public int multiplier = 3;

    public int Multiply(int x) => x * multiplier;
}