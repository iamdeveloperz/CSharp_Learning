namespace Practice_3
{
    internal class Practice_3
    {
        static void Main(string[] args)
        {
            #region Practice 3-1
            {
                // 입력받은 데이터가 숫자인지 문자열인지 판단.
                string userInput = Console.ReadLine();

                int outValue;

                if(int.TryParse(userInput, out outValue))
                {
                    Console.WriteLine("숫자입니다.");
                }
                else
                {
                    Console.WriteLine("문자열입니다.");
                }
            }
            #endregion

            #region Practice 3-2
            {
                // 입력받은 데이터가 숫자인지 문자인지 불리언인지
                string userInput = Console.ReadLine();

                int outValue;
                bool bOutValue;

                if (int.TryParse(userInput, out outValue))
                    Console.WriteLine("숫자입니다.");
                else if (bool.TryParse(userInput, out bOutValue))
                    Console.WriteLine("불리언 입니다.");
                else
                    Console.WriteLine("문자열입니다.");
            }
            #endregion

            #region Practice 3-3
            {
                string userInput = Console.ReadLine();

                int outValue;

                if(!int.TryParse(userInput, out outValue))
                {
                    Console.WriteLine("숫자가 아닙니다.");
                }
                else
                {
                    if (outValue >= 100)
                        Console.WriteLine(outValue + "은(는) 100보다 같거나 큰 수 입니다.");
                    else
                        Console.WriteLine(outValue + "은(는) 100보다 작은 수 입니다.");
                }
            }
            #endregion

            #region Practice 3-4
            {
                string userInput = Console.ReadLine();

                int outValue;

                if (!int.TryParse(userInput, out outValue))
                {
                    Console.WriteLine("숫자가 아닙니다.");
                }
                else
                {
                    if (outValue % 2 == 0)
                        Console.WriteLine(outValue + "는 짝수입니다.");
                    else
                        Console.WriteLine(outValue + "는 홀수입니다.");
                }
            }
            #endregion
        }
    }
}