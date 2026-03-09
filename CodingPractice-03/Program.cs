using System;

// 1.
Action action = Go;
action += Left;
action += Right;

action();

Console.WriteLine();

// 2.
action -= Right;
action += () => Console.WriteLine("우회전");

action();

// 1.
void Go() => Console.WriteLine("직진");
void Left() => Console.WriteLine("좌회전");
void Right() => Console.WriteLine("우회전");