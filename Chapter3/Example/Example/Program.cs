using System;
using System.Xml.Linq;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int math = 80;      // 数学の点数
            int english = 66;   // 英語の点数
            int history = 95;   // 歴史の点数

            // 平均値を計算して表示
            float average = (math + english + history) / 3.0f;
            Console.WriteLine("平均は" + average + "点");
        }
    }
}