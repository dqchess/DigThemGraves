using System.Collections.Generic;

namespace DigThemGraves
{
    public interface IInventory
    {
        List<Item> CurrentItems { get; }
        long CurrentPoints { get; }
        void AddPoints(long points);
        void AddItem(Item toAdd);
        void AddMultipleItem(List<Item> toAdd);
    }

}
