namespace ConsoleApp1
{
    public interface IObserver
    {
        void Update(AObservable subject);

        //Push Mechanism
        //void Update(object data)
    }
}
