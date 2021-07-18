namespace PovilasSvazas_GildedRose
{
    class ItemLegendary : Item
    {
        private int legendaryQuality = 80;

        public ItemLegendary(string _name, int _sellIn)
        {
            Name = _name;
            SellIn = _sellIn;

            Quality = legendaryQuality;
        }

        public override void DayPassed()
        {
            return;
        }
    }
}
