namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int16 _16intValue = 10;
            //Int32 _32intValue = 20;
            //Int64 _64intValue = 30;
            //int defaultInt = 0;     // 운영체제에 맞게 처리 32, 64

            //float fPI = 3.141592f;
            //double dPI = 3.141592d;
            //float fTestValue = 3.141592;        // 에러 발생 f나 d를 붙이지 않으면 default = double

            int ivalue1 = 5;
            int ivalue2 = 2;

            float divSum = ivalue1 / (float)ivalue2;

            Console.WriteLine(divSum);
        }
    }
}