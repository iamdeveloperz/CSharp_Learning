namespace ArithmeticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 입력 >> ");
            int lvalue = int.Parse(Console.ReadLine());

            if (lvalue % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}