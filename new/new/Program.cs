using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vad heter du?");
        string bajs = Console.ReadLine();

        Console.WriteLine("HETER DU ROPENIS???");
        string name = Console.ReadLine();

        if (name.Equals("ja", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("FUCKING HORUNGEEEEE ROPENIS");
        }
        else
        {
            Console.WriteLine("VA FAN GÖR DU HÄR???");
            Console.WriteLine("JAG VILL HA ROPENIIISSSSS!!!!!!!!!!");
        }
        Console.ReadLine();
    }
}

