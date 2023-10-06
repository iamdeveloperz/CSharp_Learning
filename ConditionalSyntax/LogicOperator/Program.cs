namespace LogicOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isComplete_A = true;
            bool isComplete_B = false;

            if (isComplete_A && isComplete_B)
                Console.WriteLine("둘 다 참입니다.");
            else if (isComplete_A || isComplete_B)
                Console.WriteLine("둘 중 하나가 참입니다.");
            else
                Console.WriteLine("둘 다 참이 아닙니다.");

            if (isComplete_A && (!isComplete_B))
                Console.WriteLine("B를 부정했기에 둘 다 참입니다.");
        }
    }
}