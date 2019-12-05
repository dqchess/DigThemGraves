namespace DigThemGraves
{
    public abstract class Subscribable : ISubscribable
    {
        private readonly ISubscribable defaultSubscribable;
		
        public void Subscribe(string callbackName, ISubscriber subscriber)
        {
            defaultSubscribable.Subscribe(callbackName, subscriber);
        }

        public void Unsubscribe(string callbackName)
        {
            defaultSubscribable.Unsubscribe(callbackName);
        }

        public void Trigger()
        {
            defaultSubscribable.Trigger();
        }
    }
}