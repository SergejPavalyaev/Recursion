namespace Task3
{
    public class Task3
    {
        // Задача 3: Задайте произвольный массив.
        // Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
        public static void Main (string [] args){
            int size = 10;
            int min = 1;
            int max = 9;
            int [] array = CreateArray(size, min, max);
            PrintArray(array);
            System.Console.WriteLine(TurnAroundArray(array, size - 1));
        }
        public static string TurnAroundArray (int [] array, int index){
            if (index == 0) return $"{array[index]}";
            return $"{array[index]} " + TurnAroundArray(array, index - 1);
        }
        public static int [] CreateArray (int size, int min, int max){
            Random rand = new Random();
            int [] array = new int [size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }
            return array;
        }
        public static void PrintArray (int [] array){
            foreach (int item in array)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }
    }
}