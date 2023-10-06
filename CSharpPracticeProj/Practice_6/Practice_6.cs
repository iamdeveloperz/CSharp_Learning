namespace Practice_6
{
    internal class Practice_6
    {
        public void Practice_6_1()
        {
            for (int i = 2; i < 10; ++i)
                Console.WriteLine("2 x " + i + " = " + 2 * i);
        }

        public void Practice_6_2()
        {
            Console.WriteLine("출력하고 싶은 단을 입력해주세요.");
            string userInput = Console.ReadLine();

            int outValue;

            if (!int.TryParse(userInput, out outValue))
                Console.WriteLine("숫자가 아닙니다.");
            else
            {
                for (int i = 2; i < 10; ++i)
                    Console.WriteLine(outValue + " x " + i + " = " + outValue * i);
            }
        }

        public void Practice_6_3()
        {
            int lvalue = 0;
            int rvalue = 1;
            
            for(int i = 0; i < 10; ++i)
            {
                Console.Write(rvalue + " ");
                int result = lvalue + rvalue;
                lvalue = rvalue;
                rvalue = result;
            }
        }

        public void Practice_6_4()
        {
            int lvalue = 0;
            int rvalue = 1;

            Console.WriteLine("몇개의 피보나치 수열을 출력하고 싶으신가요?");
            string userInput = Console.ReadLine();

            int outValue;
            if (!int.TryParse(userInput, out outValue))
                Console.WriteLine("숫자가 아닙니다.");
            else
            {
                if (outValue <= 0)
                    Console.WriteLine("양수를 입력해주세요.");
                else if (outValue >= 47)
                    Console.WriteLine("숫자가 너무 큽니다.");
                else
                {
                    for(int i = 0; i < outValue; ++i)
                    {
                        Console.Write(rvalue + " ");
                        int result = lvalue + rvalue;
                        lvalue = rvalue;
                        rvalue = result;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Practice_6 practice = new Practice_6();

            // practice.Practice_6_1();
            // practice.Practice_6_2();
            // practice.Practice_6_3();
            practice.Practice_6_4();
        }
    }
}