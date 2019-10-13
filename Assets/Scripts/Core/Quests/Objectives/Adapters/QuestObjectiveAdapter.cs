using UnityEngine;

namespace DigThemGraves
{
    public abstract class QuestObjectiveAdapter<T> : MonoBehaviour, IQuestObjective where T : IQuestObjective
    {
        protected T TargetQuestObjective;

        public virtual bool Finished => TargetQuestObjective.Finished;

        public virtual bool Failed => TargetQuestObjective.Failed;
    }
}