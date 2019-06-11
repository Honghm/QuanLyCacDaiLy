using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay.Controllor
{
    class QTV
    {
        
        public static string RandomString(int size, bool lowerCase) //Tạo chuỗi ký tự ngẫu nhiên
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public static int RandomNumber(int min, int max) //Tạo chuỗi số ngẫu nhiên
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(3, true));
            builder.Append(RandomNumber(100, 999));
            return builder.ToString();
        }
    }
}
