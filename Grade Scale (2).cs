using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Program;
public static class Program
{
    static void Main()
    {
        List<string> Score = new();
        int SumTarget = 0;
        string Target = Console.ReadLine();
        string Useless = Console.ReadLine();
        Score = Console.ReadLine().Split(" ").ToList();
        foreach (string s in Score)
        {
            if (GetGrade(int.Parse(s)) == Target)
            {
                SumTarget++;
            }
        }
        Console.WriteLine(SumTarget);
    }
    static string GetGrade(int Score)
    {
        if (Score >= 85)
        {
            return "A";
        }
        else if (Score >= 70)
        {
            return "B";
        }
        else if (Score >= 60)
        {
            return "C";
        }
        else if (Score >= 50)
        {
            return "D";
        }
        else if (Score >= 40)
        {
            return "E";
        }
        else
        {
            return "F";
        }
    }
}
