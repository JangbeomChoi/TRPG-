using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_개인과제
{
    public class Item
    {
        public string ItemName { get; }
        public int ItemNumber { get; set; }
        public int Armor { get; set; }
        public int AttackPower { get; set; }
        public string Description { get; }
        public int ItemGold { get; set; }

        public bool IsPurchased { get; set; }
        public bool IsSelled { get; set; }

        public void MarkAsPurchased()
        {
            IsPurchased = true;
        }

        public Item(string name, int itemnum, int attackpower, int armor, string description, int itemgold)
        {
            ItemName = name;
            ItemNumber = itemnum;
            AttackPower = attackpower;
            Armor = armor;
            Description = description;
            ItemGold = itemgold;

        }
    }
}
