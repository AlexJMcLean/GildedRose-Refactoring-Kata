using csharp;
using csharp.Models;

namespace GuildedRose.Tests
{
    public class UpdateQuality_WhenItemIsBackStagePass
    {
        [Fact]
        public void UpdateQuality_ShouldIncreaseQuality_WhenMoreThan10DaysRemaining()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(6, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldReduceQualityToZero_WhenSellByDatePassed()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy2_WhenMoreThan5DaysButLessThan10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(3, Items[0].Quality);
        }
        [Fact]
        public void UpdateQuality_ShouldIncreaseQualityBy2_WhenLessThan5Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(4, Items[0].Quality);
        }
        [Fact]
        public void UpdateQuality_ShouldNotIncreaseQuality_WhenQualityIs50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }
    }
}
