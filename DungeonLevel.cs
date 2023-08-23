using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_개인과제
{
    public class DungeonLevel
    {
        
        
        public static void EasyDungeon()
        {
            Console.Clear();

            Console.WriteLine("        ,    ,\r\n       /(.-\"\"-.)\\\r\n   |\\  \\/      \\/  /|\r\n   | \\ / =.  .= \\ / |\r\n   \\( \\   o\\/o   / )/\r\n    \\_, '-/  \\-' ,_/\r\n      /   \\__/   \\\r\n      \\ \\__/()\\__/\r\n       \\ ,__\\/__,\r\n        \\_____/\r\n");
            Console.WriteLine();

            string message = "고블린이 출현했습니다!!!";
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine(); //줄바꿈

            string message1 = "전투를 준비하세요!";
            foreach (char c in message1)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine() ;

            //플레이어 hp,mp설정
            //int playerHp = player.Hp;
            //int playerMp = player.Mp;

            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine($"1. 일반공격      2. 스킬   |  HP: {playerHp}  ");
            //Console.WriteLine($"3. 도망가기                |  MP: {playerMp}  ");
            //Console.WriteLine();

            Console.WriteLine("원하는 행동을 선택하세요.");

        }

        public static void NormalDungeon()  
        {
            Console.Clear();
        }

        public static void HardDungeon()
        {
            Console.Clear();
        }

        public static void DungeonClear() //던전 클리어
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("던전 클리어");
            Console.ResetColor(); //컬러 리셋
            Console.WriteLine("축하합니다!!!");
            Console.WriteLine("쉬운 던전을 클리어 하였습니다");
            Console.WriteLine();

            Console.WriteLine("[탐험 결과]");
            Console.WriteLine();
        }
    }
}
