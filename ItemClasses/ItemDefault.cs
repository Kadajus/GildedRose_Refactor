namespace PovilasSvazas_GildedRose
{
    class ItemDefault : Item
    {
        public ItemDefault(string _name, int _sellIn, int _quality)
        {
            Name = _name;
            SellIn = _sellIn;
            Quality = _quality;

            degradeRate = 1;
        }

        protected override void UpdateQuality()
        {
            if (Quality <= minQuality)
                return;

            int newQuality = Quality;

            if (SellIn >= 0)
                newQuality -= degradeRate;
            else
                newQuality -= degradeRate * 2;

            Quality = CustomHelpers.ClampValue(newQuality, minQuality, maxQuality);
        }
    }
}
