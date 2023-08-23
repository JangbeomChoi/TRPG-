using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_개인과제
{
    public partial class Character
    {
        public bool IsArmorEquipped(Item armor)
        {
            return EquippedArmor == armor;
        }
        public bool IsWeaponEquipped(Item armor)
        {
            return EquippedWeapon == armor;
        }

        public void EquipWeapon(Item weapon)
        {
            if (EquippedWeapon != null)
            {
                Atk -= EquippedWeapon.AttackPower;
            }
            EquippedWeapon = weapon;
            Atk += weapon.AttackPower;
            Console.WriteLine($"Equipped {weapon.ItemName} (Attack +{weapon.AttackPower})");
        }

        public void UnequipWeapon()
        {
            if (EquippedWeapon != null)
            {
                Atk -= EquippedWeapon.AttackPower;
                Console.WriteLine($"Unequipped {EquippedWeapon.ItemName} (Attack -{EquippedWeapon.AttackPower})");
                EquippedWeapon = null;
            }
        }

        public void EquipArmor(Item armor)
        {
            if (EquippedArmor != null)
            {
                Def -= EquippedArmor.Armor;
            }
            EquippedArmor = armor;
            Def += armor.Armor;
            Console.WriteLine($"Equipped {armor.ItemName} (Defense +{armor.Armor})");
        }

        public void UnequipArmor()
        {
            if (EquippedArmor != null)
            {
                Def -= EquippedArmor.Armor;
                Console.WriteLine($"Unequipped {EquippedArmor.ItemName} (Defense -{EquippedArmor.Armor})");
                EquippedArmor = null;
            }
        }
    }
}
