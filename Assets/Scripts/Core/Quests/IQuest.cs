using System.Collections.Generic;
using UnityEngine;

namespace DigThemGraves
{
    public interface IQuestObjective
    {
        bool Finished { get; }
        bool Failed { get; }
    }

    public class BuildObjective : IQuestObjective
    {
        public bool Finished => throw new System.NotImplementedException();

        public bool Failed => throw new System.NotImplementedException();
    }

    public class BuildObjectiveAdapter : QuestObjectiveAdapter<BuildObjective>
    {

    }

    public abstract class QuestObjectiveAdapter<T> : MonoBehaviour, IQuestObjective where T : IQuestObjective
    {
        protected T TargetQuestObjective;

        public virtual bool Finished => TargetQuestObjective.Finished;

        public virtual bool Failed => TargetQuestObjective.Failed;
    }



    public interface IQuest : IQuestObjective, IQuestReward
    {

    }
}
