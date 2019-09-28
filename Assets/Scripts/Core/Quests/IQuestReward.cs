using System.Collections.Generic;

namespace DigThemGraves
{
    public interface IQuestReward
    {
        long Points { get; }
        List<Item> Items { get; }
    }
}
