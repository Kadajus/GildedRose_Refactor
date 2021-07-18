namespace PovilasSvazas_GildedRose
{
    class ItemConjured : ItemDefault
    {
        public ItemConjured(string _name, int _sellIn, int _quality) : base(_name, _sellIn, _quality)
        {
            degradeRate = degradeRate * 2;
        }
    }
}
