using csharp.ItemFactory;
using csharp.Models;
using System.Collections.Generic;
namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                IUpdateStrategy strategy = UpdateStrategyFactory.GenerateUpdateStrategyForItem(item);
                strategy.UpdateItem(item);
            }
        }
    }
}
