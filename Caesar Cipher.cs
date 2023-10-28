using System;

public static class Program
{
    static void Main()
    {
        int Key = int.Parse(Console.ReadLine());
        string Input = Console.ReadLine();
        string[] LetterArrary = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string Data = "";
        foreach (char C in Input)
        {
            if (char.IsLetter(C))
            {
                int index = char.ToUpper(C) - 64 - 1 + Key;
                if (index < 0)
                {
                    while (index < 0)
                    {
                        index += 26;
                    }
                }
                if (index > 25)
                {
                    index -= 26 * (index / 26);
                }
                if (char.IsUpper(C))
                {
                    Data += LetterArrary[index];
                }
                else if (char.IsLower(C))
                {
                    Data += LetterArrary[index].ToLower();
                }
            }
            else
            {
                Data += C;
            }
        }
        Console.WriteLine(Data);
    }

}
