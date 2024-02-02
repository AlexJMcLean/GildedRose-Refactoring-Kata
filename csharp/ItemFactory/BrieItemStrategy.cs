using csharp.Models;

namespace csharp.ItemFactory
{
    public class BrieItemStrategy : IUpdateStrategy
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
            if (item.Quality == 50) return;
            if (item.SellIn >= 0)
            {
                item.Quality++;
            }
            else
            {
                item.Quality += 2;
            }
            return;
        }
    }
}
