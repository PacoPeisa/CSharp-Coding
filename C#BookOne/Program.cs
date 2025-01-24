namespace C_BookOne
{   
    class Arrays
    {   public static void ArrayBubbleSort(int[] array)
        {
            //int[] array = new int[] { 4, 2, 7, 8, 15, 91, 0 };

            int n = array.Length;

            for(int i = 0; i < n - 1; i++) 
            {
                bool swapped = false;

                for(int j = 0; j < n - i - 1; j++)
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
            foreach(int item in array)
            {
                result += item + " ";
            }
            Console.WriteLine("Array : {0}", result);
        }
        public static void ArrayDimensional()
        {
            //Matrix
            int[,] twoDimensionalArray;
            int[,,] threeDimensionalArray;

            int[,] intMatrix = new int[3, 4];

            int[,] matrix = { { 1, 2, 3 },    // row 0 values
                              { 4, 5, 6 },    // row 1 values
                            }; 
            Console.WriteLine(matrix[0,0]);
            Console.WriteLine(matrix[1,0]);
        }
        public static void ArrayWorking()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Output : ");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = 2 * array[i];
                Console.WriteLine(array[i] + " ");
            }

            string[] arrayTwo = new string[] { "Sofia", "Washington D. C.", "Paris", "London" };

            foreach(var capital in arrayTwo)
            {
                Console.WriteLine(capital);
            }
        }
        public static void ArrayPrinting()
        {
            string[] array = { "One", "Two", "Three", "Four" };

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
        }
        public static void ArrayCheckSymmetry()
        {
            Console.WriteLine("Enter the array's length");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element at {0} index :", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;

            for(int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[n - i - 1]) symmetric = false; break;
            }

            Console.WriteLine("Is symmetric? {0}", symmetric);
        }
        public static void ArrayCreation()
        {
            string result = "";

            Console.WriteLine("Enter the array's length");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Enter element at {0} index :", i);
                array[i] = int.Parse(Console.ReadLine()); 
            }

            foreach(int num in array)
            {
             result += num + " ";   
            }
            
            Console.WriteLine(result);
        }
        public static void ArrayReverse()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int length = array.Length;
            int[] reversed = new int[length];
            string result = "";

            for(int i = 0; i < length; i++)
            {
                reversed[length - i - 1] = array[i];
            }

            for(int i = 0; i < length; i++)
            {
                result += reversed[i] + " ";
            }

            Console.WriteLine(result);
        }
        static void Main1()
        {
            int[] array = new int[] { 4, 2, 7, 8, 15, 91, 0 };

            int[] myArray = new int[6]; // Създаване на масив от числа;
            myArray[1] = 1;
            myArray[5] = 5;

            int[] myArrayTwo = { 1, 2, 3, 4, 5, 6 };


        }
    }
    class Loops
    {
        static void Main9()
        {
            //Simple loop

            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine("Number : " + counter);
                counter++;
            }

            //Prime checker
            
            Console.WriteLine("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;

            while (prime && divider <= maxDivider)
            {
                if(num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);

            //Factorial task

            Console.Write("n = ");

            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            do
            {
                factorial *= n;
                n--;
            }
            while (n > 0);
            Console.WriteLine("n! = " + factorial);

            //Simple 'for' loop

            for(int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
            {
                Console.WriteLine("i = {0}, sum = {1}", i, sum);
            }

            // Task with 'continue'

            int x = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 1; i <= x; i += 2)
            {
                if(i % 7 == 0)
                {
                    continue;
                }
                sum1 += i;
            }
            Console.WriteLine("sum = " + sum1);

            // Task with 'foreach'

            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach(int i in numbers)
            {
                Console.WriteLine(" " + i);
            }

            String[] towns = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            foreach(String s in towns) {  Console.WriteLine(" " + s); }
        }
    }
    class PrimeNotPrimeNums
    {
        static void Main8()
        {
            int number = 6;
            switch(number)
            {
                case 4:
                case 6:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Not a prime num"); break;
                case 1:
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Prime number"); break;
                default:
                    Console.WriteLine("I don't know what this number is");
                    break;
            }
        }

    }
    class UsingBoolean
    {
        static void Main7()
        {
            int weight = 700;
            Console.WriteLine(weight <= 500); // False

            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b);
            Console.WriteLine(condition); // True

            Console.WriteLine('B' == 'A' + 1); //Сравняваме тяхната лексикографска подредба // True

            Console.WriteLine(5.0 == 5L); // True // Сравняваме техните стойности
        }
    }
    class PrintingLetter
    {   static void Main5()
        {
            Console.Write("Enter person's name: ");
            string person = Console.ReadLine();

            Console.WriteLine("Enter book's name: ");
            string book = Console.ReadLine();

            string from = "Author's team";

            Console.WriteLine("  Dear {0},", person);
            Console.Write("We are pleased to inform " + "you that \"{1}\" is the best Bulgarian book. {2}" +
                          "The authors of the book wish you good luck, {0}!{2}", person, book, Environment.NewLine);
            Console.WriteLine("  Yours,"); Console.WriteLine("  {0}", from);
        }
    }
    class ReadingNumbers
    {
        static void Main4()
        {
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            Console.WriteLine("f = ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} / {2} = {3}", a, b, f, a * b / f);


            Console.Write("Enter a floating-point number");
            string line = Console.ReadLine();
            double number = double.Parse(line);
            Console.WriteLine("You entered: {0}", number);
        }

    }
    class UsingRead
    {
        static void Main3()
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                if(codeRead != 0) 
                {
                    Console.Write((char)codeRead);
                }
            }
            while (codeRead != 10);
        }
    }
    class UsingReadLine
    {
        static void Main2()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.Write("Hello, {0} {1}!", firstName, lastName);
        }    
    }
    internal class Program
    {  
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 2, 7, 8, 15, 91, 0 };

            Arrays.ArrayPrint(array);
            Arrays.ArrayBubbleSort(array);
            Arrays.ArrayPrint(array);

            Arrays.ArrayDimensional();
            Console.ReadLine();

            Arrays.ArrayPrinting();
            Console.ReadLine();

            Arrays.ArrayReverse();
            Console.ReadLine();

            Arrays.ArrayCreation();
            Console.ReadLine();

            Arrays.ArrayCheckSymmetry();
            Console.ReadLine();

            Arrays.ArrayWorking();
            Console.ReadLine();



            int[] myArray = new int[6]; // Създаване на масив от числа;
            myArray[1] = 1;
            myArray[5] = 5;

            int[] myArrayTwo = { 1, 2, 3, 4, 5, 6 };
            /*
           string name = "Plamen";
           int age = 20;
           string town = "Yambol";

           Console.WriteLine("{0} is {1} years old from {2}!\n", name, age, town);


           int a = 5; int b = 10; int temp = 0;
           temp = a; a = b; b = temp;
           Console.WriteLine(a + ", " + b);
           Console.WriteLine(DateTime.Now);

           int[] arr = { 1, 2, 4, 5 };
           Console.WriteLine(arr[1]);

           string[] arr2 = { "kis", "mrr", "bau", "Mqy" };

           string combine = "";
           for (int i = 0; i < arr2.Length; i++)
           {
               string place = arr2[i];

               combine += place + " ";

           }

           Console.WriteLine("Array: {0}",combine);

           Console.WriteLine("Enter number:");
           int number = Convert.ToInt32(Console.ReadLine());

           double result = number * 0.17;

           Console.WriteLine(result);
            */
        }
    }
}
