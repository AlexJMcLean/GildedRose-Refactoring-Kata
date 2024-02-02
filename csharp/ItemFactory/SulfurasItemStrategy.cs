using csharp.Models;

namespace csharp.ItemFactory
{
    public class SulfurasItemStrategy : IUpdateStrategy
    {
        public void UpdateItem(Item item)
        {
            AdjustSellInDate(item);
            UpdateQuality(item);
        }
        public void AdjustSellInDate(Item item)
        {
            return;
        }

        public void UpdateQuality(Item item)
        {
            return;
        }
    }
}
