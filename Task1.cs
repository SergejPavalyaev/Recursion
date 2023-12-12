namespace Task1
{
    public class Task1
    {
        // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
        // в промежутке от M до N. Использовать рекурсию, не использовать циклы.
        public static void Main (string [] args){
            System.Console.Write("Input number M => ");
            int M = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Input number N => ");
            int N = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(PrintNaturalsNumber(M, N));
        }
        public static string PrintNaturalsNumber (int M, int N){
            if (M == N) return $"{N}";
            return $"{M} " + PrintNaturalsNumber(M+1, N);
        }
    }
}