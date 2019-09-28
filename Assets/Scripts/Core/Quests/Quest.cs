using System.Collections.Generic;

namespace DigThemGraves
{
    public class Quest : IQuest
    {
        protected IQuestReward questReward;
        protected IQuestObjective questObjective;

        public virtual long Points => questReward.Points;

        public virtual List<Item> Items => questReward.Items;

        public virtual bool Finished => questObjective.Finished;

        public virtual bool Failed => questObjective.Failed;
    }
}
