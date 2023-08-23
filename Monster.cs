using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TRPG_개인과제
{
    internal class Monster
    {
        public string MonsterName { get; set; }
        public int MonsterHealth { get; set; }
        public int MonsterAttack { get; }
        public int MonsterDefense { get; }

        public Monster(string monsterName, int monsterHealth, int monsterAttack, int monsterDefense)
        {
            MonsterName = monsterName;
            MonsterHealth = monsterHealth;
            MonsterAttack = monsterAttack;
            MonsterDefense = monsterDefense;
        }

        public void MonsterTakeDamage(int damage)
        {
            int damageTaken = Math.Max(0, damage - MonsterDefense);
            MonsterHealth -= damageTaken;
        }

        public bool IsMonsterAlive()
        {
            return MonsterHealth > 0;
        }

        public void DisplayMonsterInfo()
        {
            Console.WriteLine($"[몬스터 정보] - 이름: {MonsterName} | 체력: {MonsterHealth} | 공격력: {MonsterAttack} | 방어력: {MonsterDefense}");
        }
    }
}

