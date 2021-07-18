using NUnit.Framework;
using System.Collections.Generic;

namespace PovilasSvazas_GildedRose
{
    [TestFixture]
    public class GildedRoseTest
    {
        // Original program functionality tests
        /*
        [Test]
        public void DefaultItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Item", SellIn = 10, Quality = 10 }, //Default check
                new Item { Name = "Item Past SellIn", SellIn = 0, Quality = 10 }, //Past SellIn Check
                new Item { Name = "Item NonNegative Quality", SellIn = -2, Quality = 0 } //Quality non negative check
                //Starting quality over 50 not implemented? Should jump to 50 if over?
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Item, 9, 9", Items[0].ToString());
                Assert.AreEqual("Item Past SellIn, -1, 8", Items[1].ToString());
                Assert.AreEqual("Item NonNegative Quality, -3, 0", Items[2].ToString());
            });
        }

        [Test]
        public void AgebaleItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 }, //Default check
                new Item { Name = "Aged Brie", SellIn = -2, Quality = 10 }, //Past SellIn Check
                new Item { Name = "Aged Brie", SellIn = -5, Quality = 49 } //Max Quality Not Over 50 Check
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Aged Brie, 9, 21", Items[0].ToString());
                Assert.AreEqual("Aged Brie, -3, 12", Items[1].ToString());
                Assert.AreEqual("Aged Brie, -6, 50", Items[2].ToString());
            });
        }

        [Test]
        public void LegendaryItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 }, //Default check
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -2, Quality = 80 }, //Past SellIn Check
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Sulfuras, Hand of Ragnaros, 10, 80", Items[0].ToString());
                Assert.AreEqual("Sulfuras, Hand of Ragnaros, -2, 80", Items[1].ToString());
            });
        }

        [Test]
        public void TicketItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 30, Quality = 15 }, //Default check
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 19 }, //SellIn in 10 days check
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 7 }, //SellIn in 5 days check
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -3, Quality = 11 }, //SellIn negative check
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert, 29, 16", Items[0].ToString());
                Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert, 9, 21", Items[1].ToString());
                Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert, 4, 10", Items[2].ToString());
                Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert, -4, 0", Items[3].ToString());
            });
        }
        */

        // Refactored program functionality tests
        [Test]
        public void DefaultItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new ItemDefault("Item", 10, 10 ), //Default check
                new ItemDefault("Item Past SellIn", 0, 10 ), //Past SellIn Check
                new ItemDefault("Item NonNegative Quality", -2, 0 ) //Quality non negative check
                //Starting quality over 50 not implemented? Should jump to 50 if over?
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateItemsQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Item, 9, 9", Items[0].ToString());
                Assert.AreEqual("Item Past SellIn, -1, 8", Items[1].ToString());
                Assert.AreEqual("Item NonNegative Quality, -3, 0", Items[2].ToString());
            });
        }

        [Test]
        public void ConjuredItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new ItemConjured("Conjured Item", 10, 10 ), //Default check
                new ItemConjured("Conjured Item Past SellIn", 0, 10 ), //Past SellIn Check
                new ItemConjured("Conjured Item NonNegative Quality", -2, 0 ) //Quality non negative check
                //Starting quality over 50 not implemented? Should jump to 50 if over?
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateItemsQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Conjured Item, 9, 8", Items[0].ToString());
                Assert.AreEqual("Conjured Item Past SellIn, -1, 6", Items[1].ToString());
                Assert.AreEqual("Conjured Item NonNegative Quality, -3, 0", Items[2].ToString());
            });
        }

        [Test]
        public void AgebaleItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new ItemAgeable ("Aged Brie", 10, 20 ), //Default check
                new ItemAgeable ("Aged Brie Past SellIn", -2, 10 ), //Past SellIn Check
                new ItemAgeable ("Aged Brie Maq Quality", -5, 49 ) //Max Quality Not Over 50 Check
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateItemsQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Aged Brie, 9, 21", Items[0].ToString());
                Assert.AreEqual("Aged Brie Past SellIn, -3, 12", Items[1].ToString());
                Assert.AreEqual("Aged Brie Maq Quality, -6, 50", Items[2].ToString());
            });
        }

        [Test]
        public void LegendaryItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new ItemLegendary ("Sulfuras", 10), //Default check
                new ItemLegendary ("Sulfuras Past SellIn", -2) //Past SellIn Check
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateItemsQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Sulfuras, 10, 80", Items[0].ToString());
                Assert.AreEqual("Sulfuras Past SellIn, -2, 80", Items[1].ToString());
            });
        }

        [Test]
        public void TicketItemVariationsTest()
        {
            IList<Item> Items = new List<Item> {
                new ItemTicket ("Ticket", 30, 15 ), //Default check
                new ItemTicket ("Ticket 10days", 10, 19 ), //SellIn in 10 days check
                new ItemTicket ("Ticket 5days", 5, 7 ), //SellIn in 5 days check
                new ItemTicket ("Ticket past", -3, 11 ) //SellIn negative check
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateItemsQuality();

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Ticket, 29, 16", Items[0].ToString());
                Assert.AreEqual("Ticket 10days, 9, 21", Items[1].ToString());
                Assert.AreEqual("Ticket 5days, 4, 10", Items[2].ToString());
                Assert.AreEqual("Ticket past, -4, 0", Items[3].ToString());
            });
        }
    }
}
