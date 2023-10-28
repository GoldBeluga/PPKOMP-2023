using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Program;
public static class Program
{
    static void Main()
    {
        List<string> Offer = Console.ReadLine().Split(", ").ToList();
        List<int> Accecpt = new();
        int Current = int.Parse(Offer[0]);
        string Value = "";
        Accecpt.Add(Current);
        foreach (string S in Offer)
        {
            if (int.Parse(S) - Current > 200)
            {
                Current = int.Parse(S);
                Accecpt.Add(Current);
            }
        }
        Console.WriteLine(string.Join(", ", Accecpt));
    }

}
