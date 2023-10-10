namespace Array
{
    internal class Program
    {
        void ArrayDataSaved()
        {
            string[] gameName = new string[3];

            // 인덱스 ( 0 ~ 2 )를 사용하여 원소를 삽입
            gameName[1] = "League of Legends";
            gameName[2] = "Maple Story";
            gameName[0] = "First My Game";
            //gameName[3] = "배열 크기를 초과";

            for (int i = 0; i < gameName.Length; ++i)
                Console.WriteLine(gameName[i]);
        }

        void ArrayAndLoop()
        {
            int[] years = new int[5];
            const int currentYear = 2023;

            // 데이터를 저장
            for(int i = 0; i < years.Length; ++i)
                years[i] = currentYear + (i + 1);

            // 데이터 활용(출력)
            for (int i = 0; i < years.Length; ++i)
                Console.WriteLine("Next Year : " + years[i]); 
        }

        void ArrayForeach()
        {
            string[] gameNames = new string[3];

            for (int i = 0; i < gameNames.Length; ++i)
                gameNames[i] = "League of Legends [" + (i + 1).ToString() + "]";

            foreach (string gameName in gameNames)
                Console.WriteLine(gameName);
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            //program.ArrayDataSaved();
            //program.ArrayAndLoop();
            program.ArrayForeach();
        }
    }
}