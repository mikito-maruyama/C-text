using System;

namespace SampleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("ひろし", 100);
            player.Hp -= 70;
            Console.WriteLine("HPは" + player.Hp);
        }
    }
}
