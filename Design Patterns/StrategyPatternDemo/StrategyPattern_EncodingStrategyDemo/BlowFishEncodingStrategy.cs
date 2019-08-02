﻿using System;

namespace StrategyPattern_EncodingStrategyDemo
{
    /// <summary>
    /// ConcreteStrategy class
    /// </summary>
    public class BlowFishEncodingStrategy : IEncodingStrategy
    {
        public void EncodeValue(string value)
        {
            // Implement Encoding strategy
            Console.WriteLine("Value {0} is Encoded using BlowFish Algorithm", value);
        }
    }
}