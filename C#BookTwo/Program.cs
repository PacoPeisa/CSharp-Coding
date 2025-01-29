namespace C_BookTwo
{
    class Exercise
    {
        public static void PascalTriangle()
        {
            const int HEIGHT = 12;
            long[][] triangle = new long[HEIGHT + 1][];

            for(int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;
            for(int row = 0; row < HEIGHT - 1; row++)
            {
                for(int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for(int row = 0; row < HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for(int col = 0; col <= row;col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
        public static bool CheckArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static void MaxPlatform2x2(int[,] matrix)
        {
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for(int row = 0;row < matrix.GetLength(0) - 1;row++)
            {
                for(int col = 0; col < matrix.GetLength(1) - 1;col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if(sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine("The best platform is :");
            Console.WriteLine("  {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            Console.WriteLine("  {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }
    class DimensionalArrays
    {
        public static void CreateMatrix()
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of cols");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for(int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine("matrix[{0} {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            
            }

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col< matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
    class Arrays
    {
        public static void ArrayBubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped) break;

            }
        }

        public static void ArrayPrint(int[] array)
        {
            string result = "";
            foreach (int item in array)
            {
                result += item + " ";
            }
            Console.WriteLine("Array : {0}", result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 1, 3, 9, 1, 44, 9 };

            Console.WriteLine("Array before BubbleSort : ");
            Arrays.ArrayPrint(array);
            Console.WriteLine();
            Arrays.ArrayBubbleSort(array);
            Console.WriteLine("Array after BubbleSort : ");
            Arrays.ArrayPrint(array);
            Console.WriteLine();

            DimensionalArrays.CreateMatrix();
            Console.WriteLine();

            int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 4, 6, 7, 9 ,1 ,0 },
                { 1, 3, 9, 8, 5, 6 },
            };

            Exercise.MaxPlatform2x2(matrix);
            Console.WriteLine();

            Exercise.PascalTriangle();
            Console.WriteLine();


            Console.Write("Enter first array (split with intervals): ");
            int[] array1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.Write("Enter second array (split with intervals):  ");
            int[] array2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            
            if (Exercise.CheckArrays(array1, array2))
            {
                Console.WriteLine("Arrays are the same");
            }
            else
            {
                Console.WriteLine("Arrays are different");
            }



        }
    }
}
