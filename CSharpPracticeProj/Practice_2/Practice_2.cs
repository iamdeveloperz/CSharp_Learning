namespace Practice_2
{
    internal class Practice_2
    {
        static void Main(string[] args)
        {
            #region Practice 2-1
            {
                int ten = 10;
                int result;
                float fresult;

                result = ten + 7;
                Console.WriteLine(result);
                result = ten - 3;
                Console.WriteLine(result);
                result = ten * 2;
                Console.WriteLine(result);
                fresult = ten * 1.5f;
                Console.WriteLine(fresult);
                fresult = ten / 3.0f;
                Console.WriteLine(fresult);
                result = 10 % 4;
                Console.WriteLine(result);
            }
            #endregion

            #region Practice 2-2
            {
                string name = "Arin";
                int year = 2023;

                string introduce = "안녕하세요. 제 이름은 \"" + name + "\" 입니다.";
                string thisYear = "올해는 \'" + year + "년\' 입니다.";

                Console.WriteLine(introduce);
                Console.WriteLine(thisYear);
            }
            #endregion

            #region Practice 2-3
            {
                int ten = 10;

                bool result_1 = ten == 10;
                bool result_2 = ten != 11;
                bool result_3 = ten < 20;
                bool result_4 = ten > 5;

                Console.WriteLine(result_1.ToString() + result_2.ToString() + result_3.ToString() + result_4.ToString());
            }
            #endregion
        }
    }
}