﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class DefaultItem : ItemWrapper
    {
        public DefaultItem(Item item) : base(item) { }

        protected override void IncreaseQuality() { }

        protected override void DecreaseQuality()
        {
            if (Quality > 0)
                Quality--;
        }

        public override void UpdateState()
        {
            DecreaseQuality();
            AgeTheSellIn();
            if (SellIn < 0)
            {
                DecreaseQuality();
            }
        }


    }
}
