using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Snake", "Snake.jpg", 35, 35, 3, 5, 5, 1);

                    AddLootItem(snake, 2001, 25);
                    AddLootItem(snake, 2002, 75);

                    return snake;

                case 2:
                    Monster bat =
                        new Monster("Bat", "Bat.jpeg", 20, 20, 2, 3, 5, 1);

                    AddLootItem(bat, 2005, 25);
                    AddLootItem(bat, 2006, 75);

                    return bat;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}