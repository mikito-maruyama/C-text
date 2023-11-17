using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRPG
{
    internal class Player
    {
        private string name;
        private int hp;

        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }
        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }
        // 攻撃メソッド
        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        // 防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
