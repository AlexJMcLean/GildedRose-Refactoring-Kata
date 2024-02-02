using csharp.Models;

namespace csharp.ItemFactory;

public interface IUpdateStrategy
{
    public void UpdateItem(Item item);
    public void UpdateQuality(Item item);
    public void AdjustSellInDate(Item item);
}
