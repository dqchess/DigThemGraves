using System;

namespace DigThemGraves
{
    public class Subscriber : ISubscriber
    {
        private readonly Action targetAction;
        public Subscriber(Action targetAction)
        {
            this.targetAction = targetAction;
        }

        public void DoAction()
        {
            this.targetAction();
        }
    }
}