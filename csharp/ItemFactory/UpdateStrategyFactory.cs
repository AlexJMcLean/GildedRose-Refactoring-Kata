using csharp.Models;

namespace csharp.ItemFactory
{
    public static class UpdateStrategyFactory
    {
        public static IUpdateStrategy GenerateUpdateStrategyForItem(Item item)
        {
            switch (item.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasItemStrategy();
                case "Aged Brie":
                    return new BrieItemStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassStrategy();
                default:
                    return new DefaultItemStrategy();
            }
        }
    }
}
