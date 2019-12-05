using System;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

namespace DigThemGraves
{
    public interface IBuildableProxy
    {
        IBuildable Buildable { get; }
    }

    public class LastBuiltGrave : IBuildableProxy
    {
        private IBuildable buildable;
        private IGraveyard graveyard;

        public IBuildable Buildable => graveyard.LastBuildGrave as IBuildable;
    }

    [Serializable]
    public class BuildObjective : IQuestObjective
    {
        [SerializeField]
        private IBuildable blueprint;

        private IBuildableProxy mostRecentBuildable;

        public bool Finished => false;

        public bool Failed => throw new System.NotImplementedException();
    }
}
