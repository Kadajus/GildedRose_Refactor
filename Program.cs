using System;
using System.Collections.Generic;

namespace PovilasSvazas_GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new ItemDefault("+5 Dexterity Vest", 10, 20),
                new ItemAgeable("Aged Brie", 2, 0),
                new ItemDefault("Elixir of the Mongoose", 5, 7),
                new ItemLegendary ("Sulfuras, Hand of Ragnaros", 0),
                new ItemLegendary ("Sulfuras, Hand of Ragnaros", -1),
                new ItemTicket("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new ItemTicket("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new ItemTicket("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                new ItemConjured("Conjured Mana Cake", 3, 6)
            };

            var app = new GildedRose(Items);
            
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (var item in Items)
                    Console.WriteLine(item);

                Console.WriteLine("");
                app.UpdateItemsQuality();
            }
        }
    }
}
