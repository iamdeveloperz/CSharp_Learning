namespace ClassAndObject
{
    internal class Player
    {
        // 속성(Attribute)에 해당하는 부분
        private string userName;
        private int userLv;
        private int userHp;

        // 기능(Function)에 해당하는 부분
        public string GetUserName() { return userName; }
        public int GetUserLevel() { return userLv; }
        public int GetUserHp() { return userHp; }

        public void SettingPlayerInfo()
        {
            Console.Write("플레이어 이름을 입력하세요 >> ");
            string pName = Console.ReadLine();

            userName = pName;
            userLv = 5;
            userHp = 150;
        }
        
        public void PrintPlayerInfo()
        {
            Console.WriteLine("플레이어의 이름은 \"" + userName + "\" 입니다.");
            Console.WriteLine("레벨은 " + userLv + "이며, 체력은 " + userHp + " 입니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.SettingPlayerInfo();
            player.PrintPlayerInfo();
        }
    }
}