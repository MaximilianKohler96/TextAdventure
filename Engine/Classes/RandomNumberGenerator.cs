using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine.Classes
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _Generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _Generator.Next(minimumValue, maximumValue + 1);
        }
    }
}
 
