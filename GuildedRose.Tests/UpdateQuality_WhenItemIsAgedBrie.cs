using csharp;
using csharp.Models;

namespace GuildedRose.Tests
{
    public class UpdateQuality_WhenItemIsAgedBrie
    {
        [Fact]
        public void UpdateQuality_ShouldIncreaseQuality_WhenQualityIsLessThan50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(6, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldNotIncreaseQuality_WhenQulaityIs50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy2_WhenSellByDatePassed()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(3, Items[0].Quality);
        }
    }
}
