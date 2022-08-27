namespace Game
{
    public interface IEventSystem
    {
        void Publish(string managerEvent, params object[] args);
        void Subscribe(string managerEvent, Subscription subscription);
        void Unsubscribe(string managerEvent, Subscription subscription);
        void SaveEvent(string managerEvent, bool status, Subscription subscription);
    }
}