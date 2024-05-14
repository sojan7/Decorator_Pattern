using Decorator_Pattern.Component;

namespace Decorator_Pattern.ConcreteComponent
{
    internal class BaseWebPage : IWebPage
    {
        public int GetRank()
        {
            return 1;
        }
    }
}