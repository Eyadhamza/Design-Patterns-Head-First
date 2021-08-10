namespace Head_First_Design_Patterns.Contracts
{
    public interface ISubject
    {
        public void RegisterObserver();
        public void RemoveObserver();
        public void NotifyObserver();
    }
}
