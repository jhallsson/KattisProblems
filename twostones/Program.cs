using System;

namespace twostones
{
    class Program
    {
        static void Main(string[] args)
        {
            var stones = int.Parse(Console.ReadLine());
            var stonesLeft = stones;

            for (int i = 1; i <= stones-1; i++)
            {
                if(stonesLeft>1)
                stonesLeft -= 2;
            }
            var winner = "";
            if (stonesLeft % 2 == 0)
                winner = "Bob";
            else
                winner = "Alice";
            Console.WriteLine(winner);
        }
    }
}
