﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Wooden Spear", 2, 2, 4));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 3, 6));
            _standardGameItems.Add(new Weapon(1003, "Dagger", 20, 10, 15));
            _standardGameItems.Add(new Weapon(1004, "Longsword", 35, 12, 17));
            
            _standardGameItems.Add(new GameItem(2001, "Snake Poison", 3));
            _standardGameItems.Add(new GameItem(2002, "Snake Leather", 1));
            _standardGameItems.Add(new GameItem(2003, "Garlic", 1));
            _standardGameItems.Add(new GameItem(2004, "Apple", 1));
            _standardGameItems.Add(new GameItem(2005, "Bat Wings", 3));
            _standardGameItems.Add(new GameItem(2006, "Bat Claws", 1));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if(standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }

            return null;
        }
    }


}
