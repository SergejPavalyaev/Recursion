namespace Task2
{
    public class Task2
    {
        // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
        // Даны два неотрицательных числа m и n.
        public static void Main (string [] args){
            System.Console.Write("Input number M => ");
            int m = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Input number N => ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Function Ack(M,N) = ");
            int result = FindAck(m, n);
            System.Console.WriteLine($"{result}");
        }
        public static int FindAck (int m, int n){
            if (m == 0) return n + 1;
            else if (n == 0) return FindAck (m - 1, 1);
            else return FindAck (m - 1, FindAck(m, n - 1));
        }
    }
}