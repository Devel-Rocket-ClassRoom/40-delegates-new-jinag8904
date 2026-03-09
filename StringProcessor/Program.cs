using System;

string s = "Hello World";
Console.WriteLine($"원본: {s}");

ProcessAndPrint(s, ToUpperCase);
ProcessAndPrint(s, ToLowerCase);
ProcessAndPrint(s, AddBrackets);
ProcessAndPrint(s, Reverse);

static void ProcessAndPrint(string input, StringProcessor processor)
{
    Console.WriteLine($"결과: {processor(input)}");
}

static string ToUpperCase(string s) => s.ToUpper();
static string ToLowerCase(string s) => s.ToLower();
static string AddBrackets(string s) => $"[{s}]";
static string Reverse(string s)
{
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

delegate string StringProcessor(string s);