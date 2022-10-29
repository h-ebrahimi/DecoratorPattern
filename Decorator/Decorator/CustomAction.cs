namespace Decorator
{
    public class CustomAction : ICustomAction
    {
        public void Do(int number)
        {
            Console.WriteLine($"CustomAction : {number}");
        }
    }
}
