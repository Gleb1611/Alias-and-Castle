using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle.blanks_for_repetitive_actions
{
    internal static class InventoryActions
    {
        public static void AddToInventory(Weapon weapon, List<PlayerInventory> playerInventories)
        {
            var existingWeapon = playerInventories.Find(item => item.Name == weapon.Name);

            if (existingWeapon != null)
            {
                existingWeapon.Quantity++;
            }
            else
            {
                playerInventories.Add(new PlayerInventory
                {
                    Name = weapon.Name,
                    Damage = weapon.Damage,
                    CreatRate = weapon.CreatRate,
                    CreatDamage = weapon.CreatDamage,
                    Quantity = 1,
                    Price = weapon.Price
                });
            }
        }

        public static void AddMedKitToInventory(MedKit medKit, List<PlayerInventory> playerInventories)
        {
            var existingMedKit = playerInventories.Find(item => item.Size == medKit.Size);

            if (existingMedKit != null)
            {
                existingMedKit.Quantity += medKit.Quantity;
            }
            else
            {
                playerInventories.Add(new PlayerInventory
                {
                    Size = medKit.Size,
                    Heals = medKit.Heals,
                    Quantity = medKit.Quantity,
                    Price = medKit.Price
                });
            }
        }

        public static void AddCoinsToInventory(LittleThings coins, List<PlayerInventory> playerInventories)
        {
            var existingCoins = playerInventories.Find(item => item.Name == coins.Name);

            if (existingCoins != null)
            {
                existingCoins.Quantity += coins.Quantity;
            }
            else
            {
                playerInventories.Add(new PlayerInventory
                {
                    Name = coins.Name,
                    Quantity = coins.Quantity,
                    Price = coins.Price
                });
            }
        }
    }
}