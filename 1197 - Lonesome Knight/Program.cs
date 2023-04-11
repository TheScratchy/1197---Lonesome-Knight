using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string pos = Console.ReadLine();
            var posiitons = pos.GetNumberPosition();
            Console.WriteLine(GetAmountOfAttackedSquares(posiitons));
        }
    }

    private static int GetAmountOfAttackedSquares(int[] pos)
    {
        int numberOfAtckSq = 0;
        for(int i = 1; i >=-1; i-= 2)
        {
            if ((pos[0] + i >= 1 && pos[0] + i <= 8) == false)
                continue;

            for (int j = 2; j >= -2; j -= 4)
            {
                if ((pos[1] + j >= 1 && pos[1] + j <= 8) == false)
                    continue;
                numberOfAtckSq++;
            }
        }

        for (int i = 2; i >= -2; i -= 4)
        {
            if ((pos[0] + i >= 1 && pos[0] + i <= 8) == false)
                continue;

            for (int j = 1; j >= -1; j -= 2)
            {
                if ((pos[1] + j >= 1 && pos[1] + j <= 8) == false)
                    continue;
                numberOfAtckSq++;
            }
        }

        return numberOfAtckSq;
    }
}

// Placed in the Program.cs file for the upload sake
static internal class StringExtensions
{
    static public int[] GetNumberPosition(this string str)
    {
        int[] pos = new int[2];
        pos[1] = str[1] - 48;
        pos[0] = char.ToUpper(str[0]) - 64;

        return pos;
    }
}