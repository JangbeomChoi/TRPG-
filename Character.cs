using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_개인과제
{
    public partial class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; } 
        public int Gold { get; set; }
        public Item EquippedWeapon { get; set; }
        public Item EquippedArmor { get; set; }
        public List<Item> Inventory { get; private set; }


        public Character(string name, string job, int level, int atk, int def, int hp, int mp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Mp = mp;
            Gold = gold;

            Inventory = new List<Item>(); //인벤토리 초기화
        }
        public void AddToCharacter(Item item) // 아이템을 캐릭터에 구매후 바로 장착
        {
            Inventory.Add(item);
            Console.WriteLine($"{item.ItemName}을(를) 장착하였습니다.");
        }


        public void RemoveFromInventory(Item item)
        {
            if (Inventory.Contains(item))
            {
                var inventoryList = Inventory.ToList();
                inventoryList.Remove(item);
                Inventory = inventoryList;
            } 
        }
    }
}
