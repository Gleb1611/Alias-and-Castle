using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class GameItems
    {
        public static List<MedKit> medKits { get; set; } = new List<MedKit>
        {
            new MedKit { Index = 1, Size = "Маленькая аптечка", Quantity = 1, Heals = 5, Price = 2},
            new MedKit { Index = 2, Size = "Средняя аптечка", Quantity = 1, Heals = 10, Price = 4},
            new MedKit { Index = 3, Size = "Большая аптечка", Quantity = 1, Heals = 20, Price = 5},
        };

        public static List<Weapon> weapons { get; set; } = new List<Weapon>
        {
            new Weapon { Index = 1, Name = "Палка", Damage = 8, CreatRate = 5, CreatDamage = 11, Price = 0},
            new Weapon { Index = 2, Name = "Тупой меч", Damage = 15, CreatRate = 20, CreatDamage = 25, Price = 2},
            new Weapon { Index = 3, Name = "Меч", Damage = 30, CreatRate = 20, CreatDamage = 40, Price = 10},
            new Weapon { Index = 4, Name = "Кинжал", Damage = 16, CreatRate = 20, CreatDamage = 30, Price = 8},
        };

        public static List<Keys> keys { get; set; } = new List<Keys>
        {
            new Keys { Index = 1, Name ="Ключ от первого монумента"},
            new Keys { Index = 2, Name ="Ключ от второго монумента"},
            new Keys { Index = 3, Name ="Ключ от третьего монумента"},
        };

        public static List<LittleThings> littleThings { get; set; } = new List<LittleThings>
        {
            new LittleThings { Index = 1, Name = "Монет", Quantity = 0},
        };

        public static List<PlayerInventory> playerInventories = new List<PlayerInventory>
        {

        };
    }

    class MedKit
    {
        public int Index { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public int Heals { get; set; }
        public int Price { get; set; }
    }

    class Weapon
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int CreatRate { get; set; }
        public int CreatDamage { get; set; }
        public int Price { get; set; }
    }

    class Keys
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }

    class LittleThings
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    class PlayerInventory
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int CreatRate { get; set; }
        public int CreatDamage { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public int Heals { get; set; }
        public int Price { get; set; }
    }
}