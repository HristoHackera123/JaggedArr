using System.Data.Common;

namespace MaximalPloshtatka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of the square arr");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            int[][] arr = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Write the numbers on the {i+1}th arr, seperated with space (must be exactly {rows} numbers long)");
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                try
                {
                    arr[i] = new int[]{ input[0], input[1], input[2], input[3], input[4] };
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
            int maxSum = int.MinValue;
            int sum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0;row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int firstNum = arr[row][col];
                    int secNum = arr[row][col + 1];
                    int thirdNum = arr[row + 1][col];
                    int fourthNum = arr[row + 1][col+1];
                    sum += firstNum + secNum + thirdNum + fourthNum;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine($"{arr[maxRow][maxCol]}  {arr[maxRow][maxCol+1]}\n" +
                                $"{arr[maxRow + 1][maxCol]}  {arr[maxRow+1][maxCol+1]}");
        }
    }
}
