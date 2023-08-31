

using System.Runtime.CompilerServices;

Console.BackgroundColor = ConsoleColor.DarkRed;

Console.WriteLine("Vad heter do??");
string name = Console.ReadLine();

Console.WriteLine("varfor du ticker om cheeseburgar?");
string cheeseburgar = Console.ReadLine();

Console.WriteLine("Kan du göra en gång till och sen aldrig igen?");
string fråga = Console.ReadLine();

Console.WriteLine($"OM {name} TICKER DET ÄR {cheeseburgar} DÅ HAN SKA DÖD OCH SEN HAN GÖRA IGEN {fråga}");


Console.ReadLine();