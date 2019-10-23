using UnityEngine;

namespace DigThemGraves
{
    public abstract class QuestObjectiveAdapter<T> : MonoBehaviour, IQuestObjective where T : IQuestObjective
    {
        [SerializeField]
        protected T targetQuestObjective;

        public virtual bool Finished => targetQuestObjective.Finished;

        public virtual bool Failed => targetQuestObjective.Failed;
    }
}