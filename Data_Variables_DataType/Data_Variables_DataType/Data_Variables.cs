namespace Data_Variables_DataType
{
    internal class Data_Variables
    {
        static void Main(string[] args)
        {
            int integerTypeValue = 10;
            float floatingTypeValue = 3.101f;
            char characterTypeValue = 'A';

            Console.WriteLine("printf처럼 사용하기 int data : %d\n", integerTypeValue);
            Console.WriteLine(characterTypeValue + "\n");       // 자바처럼 쓰기
            Console.WriteLine("C++처럼 쓰기" + "도 가능하다. floating data : " + floatingTypeValue);

            characterTypeValue = 'B';
            Console.WriteLine("당신의 성적은 : " + characterTypeValue);
        }
    }
}