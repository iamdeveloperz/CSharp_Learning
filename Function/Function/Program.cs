namespace Function
{
    internal class Program
    {
        void PrintText()
        {
            Console.WriteLine("출력 전용 함수입니다.");
            Console.WriteLine("현재 출력되는 부분은 함수 영역 부분입니다.");
        }

        void Attack(ref int characterHp, int damage)
        {
            if(characterHp - damage <= 0)
            {
                characterHp = 0;        // 캐릭터 사망처리
                Console.WriteLine("받은 데미지 : " + damage + "\t\t현재 체력 : " + characterHp);
                Console.WriteLine("캐릭터가 사망하였습니다.");
                return;
            }

            characterHp -= damage;
            Console.WriteLine("받은 데미지 : " + damage + "\t\t현재 체력 : " + characterHp);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int characterHp = 100;

            program.Attack(ref characterHp, 70);
            program.Attack(ref characterHp, 10);
            program.Attack(ref characterHp, 10);
            program.Attack(ref characterHp, 100);
            //int characterPoint = 0;

            //for (int i = 0; i < 3; ++i)
            //{
            //    characterPoint += GetReward();
            //    Console.WriteLine("현재 포인트 : " + characterPoint);
            //}

            // program.PrintText();
            //Attack();
            //Attack();
            //Attack();
            //Attack();
            //Attack();
            //Attack();       // 출력하지 않음.

            void Attack()
            {
                if (characterHp <= 0)
                    return;
                --characterHp;
                Console.WriteLine("데미지 : 1\t현재 체력 : " + characterHp);
            }

            int GetReward()
            {
                Console.WriteLine("보상으로 100포인트를 획득 하셨습니다.");
                return 100;
            }
        }
    }
}