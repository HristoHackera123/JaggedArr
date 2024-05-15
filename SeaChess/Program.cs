namespace SeaChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] igra = new string[3][];
            for (int i = 0; i < igra.Length; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                try
                {
                    igra[i] = new string[] { input[0], input[1], input[2] };
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
            for (int i = 0;i < igra.Length; i++)
            {
                if (igra[i][0] == igra[i][1] && igra[i][1] == igra[i][2])
                {
                    Console.WriteLine($"The winner is: {igra[i][0]}");
                    return;
                }
                if (igra[0][i] == igra[1][i] && igra[1][i] == igra[2][i])
                {
                    Console.WriteLine($"The winner is: {igra[0][i]}");
                    return;
                }
            }
            if ((igra[0][0] == igra[1][1] && igra[1][1] == igra[2][2]) || (igra[0][2] == igra[1][1] && igra[1][1] == igra[2][0]))
            {
                Console.WriteLine($"The winner is {igra[1][1]}");
                return;
            }
            Console.WriteLine("There is no winner");
        }
    }
}
