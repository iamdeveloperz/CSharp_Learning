namespace ConditionalSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("1번 선택. 오늘 저녁은 짜장면이다.");
                    break;
                case 2:
                    Console.WriteLine("2번 선택. 오늘 저녁은 짬뽕이다.");
                    break;
                case 3:
                    Console.WriteLine("3번 선택. 오늘 저녁은 짬짜면이다.");
                    break;
                default:
                    Console.WriteLine("1, 2, 3번 난 모르겠다. 다시켜!");
                    break;
            }
        }
    }
}