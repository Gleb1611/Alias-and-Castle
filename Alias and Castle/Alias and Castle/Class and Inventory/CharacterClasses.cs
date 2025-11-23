using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alias_and_Castle
{
    internal class CharacterClasses
    {
        public static void CharacterClas()
        {
            List<Class> classes = new List<Class>
            {
                new Class{ Index = 1, Name ="Человек", Heals = 100, Damage = 8, MaxHeal = 100},
                new Class{ Index = 2, Name ="Эльф", Heals = 100, Damage = 7, MaxHeal = 100},
                new Class{ Index = 3, Name ="Гоблин", Heals = 80, Damage = 5, MaxHeal = 80, Mood = 100},
                new Class{ Index = 4, Name ="Зверолюд", Heals = 110, Damage = 10, MaxHeal = 110, Mood = 100},
                new Class{ Index = 5, Name ="Вампир", Heals = 110, Damage = 10, MaxHeal = 110, Mood = 100},
            };


        }
    }

    class Class
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Heals { get; set; }
        public int Damage { get; set; }
        public int MaxHeal { get; set; }
        public int Mood { get; set; }
    }
}
