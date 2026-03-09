using System;

// 1.
{
    SayDelegate say = Hello;

    say();
    say.Invoke();

    static void Hello() => Console.WriteLine("Hello Delegate");
}
Console.WriteLine();

// 2.
{
    SayDelegate say = Hi;
    say();

    say = new SayDelegate(Hi);
    say();

    static void Hi() => Console.WriteLine("안녕하세요.");
}
Console.WriteLine();

// 3.
{
    GetAreaDelegate pointer = GetArea;
    Console.WriteLine(pointer.Invoke(10));
    Console.WriteLine(pointer(10));

    static double GetArea(int radius) => 3.14 * radius * radius;
}
Console.WriteLine();

// 4.
{
    MathOperation pow = Math.Pow;
    Console.WriteLine(pow(2, 10));
}
Console.WriteLine();

// 5.
{
    Transformer t = Calculator.Square;
    Console.WriteLine(t(5));
}
Console.WriteLine();

// 6.
{
    ProgressReporter reporter = WriteToConsole;
    reporter += WriteToFile;

    for (int i = 0; i <= 100; i += 25)
    {
        reporter(i);
        Console.WriteLine();
    }

    static void WriteToConsole(int percent) => Console.WriteLine($"진행률: {percent}%");
    static void WriteToFile(int percent) => Console.WriteLine($"[파일 기록] {percent}%");
}
Console.WriteLine();

// 7.
{
    RunnerCall(Go);
    RunnerCall(Back);

    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");

    static void RunnerCall(Runner runner)
    {
        Console.WriteLine("=== 실행 시작 ===");
        runner();
        Console.WriteLine("=== 실행 종료 ===\n");
    }
}
Console.WriteLine();

// 8.
{
    Action action = () => Console.WriteLine("안녕하세요!");
    Action<string> action2 = (string msg) => Console.WriteLine(msg);
    Action<string, int> action3 = Repeat;

    action();
    action2("Hello, Action!");
    action3("반복", 3);

    static void Repeat(string msg, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(msg);
        }
    }
}
Console.WriteLine();

// 9.
{
    Func<int> fun1 = () => 42;
    Func<int, int> fun2 = (int i) => i * i;
    Func<int, int, int> fun3 = (int a, int b) => a + b;
    Func<int, int, string> fun4 = (int a, int b) => $"{a + b}";

    Console.WriteLine(fun1());
    Console.WriteLine(fun2(5));
    Console.WriteLine(fun3(3, 7));
    Console.WriteLine(fun4(4, 6));
}
Console.WriteLine();

// 10.
{
    Predicate<int> isEven = (int i) => i % 2 == 0;
    Predicate<int> isPositive = (int i) => i > 0;

    Console.WriteLine(isEven(4));
    Console.WriteLine(isEven(7));
    Console.WriteLine(isPositive(5));
    Console.WriteLine(isPositive(-3));
}
Console.WriteLine();

// 11.
{
    SayDelegate say = delegate ()
    {
        Console.WriteLine("반갑습니다.");
    };

    say();
}
Console.WriteLine();

// 7.
delegate void Runner();

// 6.
delegate void ProgressReporter(int i);

// 5.
delegate int Transformer(int i);

class Calculator
{
    public static int Square(int x) => x * x;
}

// 4.
delegate double MathOperation(double x, double y);

// 3.
delegate double GetAreaDelegate(int i);

// 1, 2.
delegate void SayDelegate();