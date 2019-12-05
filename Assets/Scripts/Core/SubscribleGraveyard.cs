using UnityEngine;
using System.Collections.Generic;

namespace DigThemGraves
{
    [SerializeField]
    public class SubscribableGraveyard : Subscribable, IGraveyard
    {
        [SerializeField]
        private List<IBuildSlot> buildSlots;
        private IGrave lastBuildGrave;

        public List<IBuildSlot> BuildSlots => buildSlots;

        public IGrave LastBuildGrave => lastBuildGrave;
    }
}