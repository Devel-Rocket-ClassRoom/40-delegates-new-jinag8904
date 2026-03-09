using System;

Action<string> action;

string msg = "Hello World";

action = PrintOriginal;
action(msg);
Console.WriteLine();

action += PrintUpper;
action(msg);
Console.WriteLine();

action += PrintLower;
action += PrintLength;
action(msg);
Console.WriteLine();

action -= PrintUpper;
action(msg);
Console.WriteLine();

static void PrintOriginal(string s) => Console.WriteLine($"원본: {s}");
static void PrintUpper(string s) => Console.WriteLine($"대문자: {s.ToUpper()}");
static void PrintLower(string s) => Console.WriteLine($"소문자: {s.ToLower()}");
static void PrintLength(string s) => Console.WriteLine($"길이: {s.Length}");