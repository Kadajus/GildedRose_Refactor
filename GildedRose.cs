using System.Collections.Generic;

namespace PovilasSvazas_GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateItemsQuality()
        {
            foreach (var item in Items)
                item.DayPassed();
        }
    }
}
