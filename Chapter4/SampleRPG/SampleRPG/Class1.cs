using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRPG
{
    internal class Class1
    {
        public string name; 
        public int hp;      

        // 攻撃メソッド
        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        // 防御メソッド
        public void Run()
        {
            Console.WriteLine(this.name + "は逃走した");
        }
    }
}
