namespace ConsoleApp27
{ 
    internal class ArrayCreator
    {
        public static int[] CreateArray(int size, bool sorted)
        {
            Random random = new Random(Environment.TickCount);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, size);
            }
            if (sorted)
            {
                Array.Sort(array);
            }
            return array;
        }
    }

    internal class Program
    {
        public static int LinearSearchWithTranspose(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (i != 0)
                    {
                        int temp = array[i];
                        array[i] = array[0];
                        array[0] = temp;
                    }
                    return i; 
                }
            }
            return -1; 
        }

        static void Main(string[] args)
        {
            int[] array = ArrayCreator.CreateArray(10, false);

            Console.WriteLine("Масивът:");
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int target = 5; 
            Console.WriteLine($"Търсим елемента {target}.");

            int index = LinearSearchWithTranspose(array, target);

            if (index != -1)
            {
                Console.WriteLine($"Елементът {target} е намерен на индекс {index}.");
                Console.WriteLine("Масив след транспониране:");
                foreach (var num in array)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Елементът не е намерен.");
            }
        }
    }
}

