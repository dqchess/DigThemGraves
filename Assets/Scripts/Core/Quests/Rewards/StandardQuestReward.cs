using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigThemGraves
{
    [Serializable]
    public class StandardQuestReward : IQuestReward
    {
        [SerializeField]
        private long points;
        [SerializeField]
        private List<Item> items;

        public long Points => points;

        public List<Item> Items => items;
    }
}