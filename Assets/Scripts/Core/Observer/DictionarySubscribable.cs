using  System.Collections.Generic;

namespace DigThemGraves
{
    public class DictionarySubscribable : ISubscribable
    {
        private Dictionary<string, ISubscriber> subscribers;

        public DictionarySubscribable()
        {
            subscribers = new Dictionary<string, ISubscriber>();
        }
		
        public void Subscribe(string callbackName, ISubscriber subscriber)
        {
            subscribers.Add(callbackName, subscriber);		
        }

        public void Unsubscribe(string callbackName)
        {
            subscribers.Remove(callbackName);
        }

        public void Trigger()
        {
            foreach (var keyValuePair in subscribers)
            {
                var subscriber = keyValuePair.Value;
                subscriber.DoAction();
            }	
        }
    }
}