namespace Decorator
{
    public class DecoratorCustomAction : ICustomAction
    {
        private readonly ICustomAction _customAction;
        public DecoratorCustomAction(ICustomAction customAction)
        {
            _customAction = customAction;
        }

        public void Do(int number)
        {
            if (number % 2 == 0)
                _customAction.Do(number);
            else
                Console.WriteLine($"DecoratorCustomAction : {number}");
        }
    }
}
