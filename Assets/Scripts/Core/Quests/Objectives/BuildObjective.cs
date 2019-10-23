using System;
using UnityEngine;

namespace DigThemGraves
{
    [Serializable]
    public class BuildObjective : IQuestObjective
    {
        [SerializeField]
        private IBuildable blueprint;

        public bool Finished => throw new System.NotImplementedException();

        public bool Failed => throw new System.NotImplementedException();
    }
}
