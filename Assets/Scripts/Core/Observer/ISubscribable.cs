namespace DigThemGraves
{
    public interface ISubscribable
    {
        void Subscribe(string callbackName, ISubscriber subscriber);
        void Unsubscribe(string callbackName);
        void Trigger();
    }
}