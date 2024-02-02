using csharp;
using csharp.Models;

namespace GuildedRose.Tests
{
    public class UpdateQuality_WhenDefaultItem
    {
        [Fact]
        public void UpdateQuality_ShouldDecreaseInValue_WhenMethodCalled()
        {

            IList<Item> Items = new List<Item> { new Item { Name = "item", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].Quality);

        }

        [Fact]
        public void UpdateQuality_ShouldDecreaseInSellByDate_WhenMethodCalled()
        {

            IList<Item> Items = new List<Item> { new Item { Name = "item", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].SellIn);

        }

        [Fact]
        public void UpdateQuality_ShouldNotDecreaseQuality_WhenQualityIsZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "item", SellIn = 1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldDecreaseQualityByTwo_WhenSellByDateHasPassed()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "item", SellIn = 0, Quality = 4 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(2, Items[0].Quality);
        }
    }
}