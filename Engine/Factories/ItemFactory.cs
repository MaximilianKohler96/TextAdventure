using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Wooden Spear", 2, 2, 4));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 3, 6));
            _standardGameItems.Add(new GameItem(2001, "Snake Poison", 5));
            _standardGameItems.Add(new GameItem(2002, "Snake Leather", 2));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if(standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }
    }


}
