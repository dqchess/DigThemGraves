using System.Collections.Generic;
using UnityEngine;

namespace DigThemGraves
{
    public class QuestAdapter<T> : MonoBehaviour, IQuest where T : IQuest
    {
        protected T targetQuest;

        public virtual long Points => targetQuest.Points;

        public virtual List<Item> Items => targetQuest.Items;

        public virtual bool Finished => targetQuest.Finished;

        public virtual bool Failed => targetQuest.Failed;
    }
}
