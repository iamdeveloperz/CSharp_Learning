namespace CSharpPracticeProj
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            #region P1, P2
            {
                int level, number;
                float percentage, speed;
                string nickName, description;

                level = 1; number = 10;
                percentage = 50f; speed = 3.5f;
                nickName = "HS"; description = "설명";
            }
            #endregion

            #region P3
            {
                int iTen = 10;
                float fTen;
                fTen = (float)iTen;

                float fFive = 5.5f;
                int iFive = (int)fFive;
            }
            #endregion

            #region P4
            {
                int n = 10;
                float f = 0.5f;

                string nTo = n.ToString();
                string fTo = f.ToString();
            }
            #endregion

            #region P5
            {
                string strTen = "10";
                string strSix = "6.2";
                int ivalue = int.Parse(strTen);
                float fvalue = float.Parse(strSix);
            }
            #endregion
        }
    }
}