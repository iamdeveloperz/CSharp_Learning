namespace Practice_7
{

    internal class Practice_7
    {
        public void Practice_7_1()
        {
            Console.WriteLine("이름을 입력해주세요. (3~10글자)");
            string userInputName = Console.ReadLine();

            int nameLength = userInputName.Length;

            if (nameLength < 3 || nameLength > 10)
                Console.WriteLine("이름을 확인해주세요.");
            else
                Console.WriteLine("안녕하세요! 제 이름은 " + userInputName + " 입니다.");
        }

        public void Practice_7_2()
        {
            while (true)
            {
                Console.WriteLine("이름을 입력해주세요. (3~10글자)");
                string userInputName = Console.ReadLine();

                int nameLength = userInputName.Length;

                if (nameLength < 3 || nameLength > 10)
                    Console.WriteLine("이름을 확인해주세요.");
                else
                {
                    Console.WriteLine("안녕하세요! 제 이름은 " + userInputName + " 입니다.");
                    break;
                }
            }
        }

        public void Practice_7_3()
        {
            while (true)
            {
                Console.WriteLine("이름을 입력해주세요. (3~10글자)");
                string userInputName = Console.ReadLine();

                int nameLength = userInputName.Length;

                if (nameLength < 3 || nameLength > 10)
                {
                    Console.Clear();
                    Console.WriteLine("이름을 확인해주세요.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("안녕하세요! 제 이름은 " + userInputName + " 입니다.");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Practice_7 practice = new Practice_7();

            // practice.Practice_7_1();
            // practice.Practice_7_2();
            practice.Practice_7_3();
        }
    }
}