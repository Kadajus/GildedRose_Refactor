using System;

namespace PovilasSvazas_GildedRose
{
    //Would rename to ItemBase, but scared of Goblin :)
    public class Item
    {
        protected string Name;
        protected int SellIn;
        protected int Quality;

        protected int maxQuality = 50;
        protected int minQuality = 0;
        protected int degradeRate = 0;

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
        
        public virtual void DayPassed()
        {
            SellIn--;
            UpdateQuality();
        }

        protected virtual void UpdateQuality()
        {
        }
        
    }
}
