using System.Collections.Generic;
using UnityEngine;

namespace DigThemGraves
{
    public abstract class QuestRewardAdapter<T> : MonoBehaviour, IQuestReward where T : IQuestReward
    {
        [SerializeField]
        protected T targetQuestReward;

        public long Points => targetQuestReward.Points;

        public List<Item> Items => targetQuestReward.Items;
    }
}