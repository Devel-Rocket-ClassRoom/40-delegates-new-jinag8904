using System;

MathOp math = Add;
Console.WriteLine(math(20, 4));

math = Subtract;
Console.WriteLine(math(20, 4));

math = Multiply;
Console.WriteLine(math(20, 4));

math = Divide;
Console.WriteLine(math(20, 4));

static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiply(int a, int b) => a * b;
static int Divide(int a, int b) => a / b;

delegate int MathOp(int x, int y);