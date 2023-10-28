using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Program;
public static class Program
{
    static void Main()
    {
        int Total = int.Parse(Console.ReadLine());
        List<string> Score = new();
        List<string> Cheat = new();
        int y = 0;
        for (int x = Total; x > 0; x--)
        {
            Score.Add(Console.ReadLine());
        }
        foreach (string S in Score)
        {
            if (S.Split(" ").ToList().Select(int.Parse).ToList().Sum() != 0)
            {
                y = 0;
                foreach (string x in Score)
                {
                    if (x == S)
                    {
                        y++;
                    }
                }
                if (y > 1)
                {
                    Cheat.Add(S);
                }
            }
        }
        foreach (string S in Score)
        {
            if (Cheat.Any(x => x == S))
            {
                Console.WriteLine("suspected to have discussed or cheating or allow cheating");
            }
            else
            {
                Console.WriteLine(S.Split(" ").ToList().Select(int.Parse).ToList().Sum());
            }
        }
    }

}
