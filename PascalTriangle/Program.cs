namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide pascal triangle length.");
            int h = int.Parse(Console.ReadLine());
            int[][] pascal = new int[h][];
            pascal[0] = new int[] { 1 };
            for (int row = 1; row < h; row++)
            {
                pascal[row] = new int[row+1];
                for (int col = 0; col < row+1; col++)
                {
                    if (col != 0 && col != row)
                    {
                        pascal[row][col] = pascal[row-1][col-1] + pascal[row-1][col];
                    }
                    else
                    {
                        pascal[row][col] = 1;
                    }
                }
            }
            for (int row = 0; row < h; row++)
            {
                string space = new string (' ', h-row);
                Console.WriteLine(space + string.Join("  ", pascal[row]));
            }
        }
    }
}
