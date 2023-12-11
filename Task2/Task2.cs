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
        public int FindAck (int m, int n){
            if (m == 0) return n + 1;
            if (n == 0) return FindAck (m - 1, 1);
            return FindAck (n - 1, FindAck(n, m - 1));
        }
    }
}