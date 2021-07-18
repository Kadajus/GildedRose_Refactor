using System;

namespace PovilasSvazas_GildedRose
{
    public static class CustomHelpers
    {
        public static int ClampValue(int value, int min, int max)
        {
            //Clamp value between min and max
            return Math.Min(max, Math.Max(value, min));
        }
    }
}
