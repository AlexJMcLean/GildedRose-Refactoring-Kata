using csharp.Models;

namespace csharp.ItemFactory
{
    public class BackStagePassStrategy : IUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            AdjustSellInDate(item);
            UpdateQuality(item);
        }
        public void AdjustSellInDate(Item item)
        {
            item.SellIn--;
            return;
        }

        public void UpdateQuality(Item item)
        {
            if (item.Quality == 50 && item.SellIn >= 0) return;
            if (item.SellIn >= 10)
            {
                item.Quality++;
            }
            else if (item.SellIn >= 5)
            {
                item.Quality += 2;
            }
            else if (item.SellIn >= 0)
            {
                item.Quality += 3;
            }
            else
            {
                item.Quality = 0;
            }
            return;
        }
    }
}
