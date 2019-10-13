namespace DigThemGraves
{
    public interface IQuestObjective
    {
        bool Finished { get; }
        bool Failed { get; }
    }
}
