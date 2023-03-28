namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a1 = number / 1000;
            int a2 = number / 100 %10;
            int a3 = number / 10 % 10;
            int a4 = number % 10 ;
            Console.WriteLine($"The result : {a1 * a2 * a3 * a4}");
        }
    }
}