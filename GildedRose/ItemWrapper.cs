﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public abstract class ItemWrapper : Item
    {
        public ItemWrapper(Item item)
        {
            Name = item.Name;
            SellIn = item.SellIn;
            Quality = item.Quality;
        }

        protected void AgeTheSellIn()
        {
            SellIn--;
        }

        public abstract void UpdateState();
    }
}
