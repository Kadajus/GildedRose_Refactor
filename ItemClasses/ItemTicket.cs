namespace PovilasSvazas_GildedRose
{
    class ItemTicket : Item
    {
        public ItemTicket(string _name, int _sellIn, int _quality)
        {
            Name = _name;
            SellIn = _sellIn;
            Quality = _quality;
        }

        protected override void UpdateQuality()
        {
            int newQuality = Quality;

            if (SellIn < 0)
                newQuality = 0;
            else if (SellIn < 5)
                newQuality += 3;
            else if (SellIn < 10)
                newQuality += 2;
            else
                newQuality += 1;

            Quality = CustomHelpers.ClampValue(newQuality, minQuality, maxQuality);
        }
    }
}
