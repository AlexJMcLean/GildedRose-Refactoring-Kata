using csharp;
using csharp.Models;

namespace GuildedRose.Tests
{
    public class UpdateQuality_WhenItemIsSulfuras
    {
        [Fact]
        public void UpdateQuality_ShouldNotIncreaseQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldNotDecreaseSellByDate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(1, Items[0].SellIn);
        }
    }
}
