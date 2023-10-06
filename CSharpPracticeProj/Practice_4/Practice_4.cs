namespace Practice_4
{
    internal class Practice_4
    {
        static void Main(string[] args)
        {
            #region Practice 4-1
            {
                Console.WriteLine("첫번째 수를 입력해 주세요.");
                string userInput1 = Console.ReadLine();
                Console.WriteLine("두번째 수를 입력해 주세요.");
                string userInput2 = Console.ReadLine();

                int ivalue1, ivalue2;

                if (int.TryParse(userInput1, out ivalue1) && int.TryParse(userInput2, out ivalue2))
                    Console.WriteLine("두 데이터는 모두 숫자입니다.");
                else
                    Console.WriteLine("숫자가 아닙니다.");
            }
            #endregion

            #region Practice 4-2
            {
                Console.WriteLine("첫번째 수를 입력해 주세요.");
                string userInput1 = Console.ReadLine();
                Console.WriteLine("두번째 수를 입력해 주세요.");
                string userInput2 = Console.ReadLine();

                int ivalue1, ivalue2;

                if (int.TryParse(userInput1, out ivalue1) && int.TryParse(userInput2, out ivalue2))
                    Console.WriteLine("두 데이터는 모두 숫자입니다.");
                else if(int.TryParse(userInput1, out ivalue1) || int.TryParse(userInput2, out ivalue2))
                    Console.WriteLine("하나의 데이터만 숫자입니다.");
                else
                    Console.WriteLine("두 데이터 모두 숫자가 아닙니다.");
            }
            #endregion

            #region Practice 4-3
            {
                Console.WriteLine("첫번째 수를 입력해 주세요.");
                string userInput1 = Console.ReadLine();
                Console.WriteLine("두번째 수를 입력해 주세요.");
                string userInput2 = Console.ReadLine();

                int ivalue1, ivalue2;

                if (int.TryParse(userInput1, out ivalue1) && int.TryParse(userInput2, out ivalue2))
                {
                    if (ivalue1 == ivalue2)
                        Console.WriteLine(ivalue1 + "와(과) " + ivalue2 + "은(는) 같습니다.");
                    else if (ivalue1 > ivalue2)
                        Console.WriteLine(ivalue1 + "은(는) " + ivalue2 + "보다 큽니다.");
                    else
                        Console.WriteLine(ivalue1 + "은(는) " + ivalue2 + "보다 작습니다.");
                }
                else
                    Console.WriteLine("두 개의 숫자를 입력해주세요.");
            }
            #endregion
        }
    }
}