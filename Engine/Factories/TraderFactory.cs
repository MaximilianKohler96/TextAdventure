﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader captain = new Trader("Captain");
            captain.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader weaponsmith = new Trader("Weaponsmith");
            weaponsmith.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            AddTraderToList(captain);
            AddTraderToList(weaponsmith);
        }

        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }

            _traders.Add(trader);
        }
    }
}