using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator;

namespace Decorator_Pattern.ConcreteDecorator
{
    internal class MobileVersionDecorator : WebPageDecorator
    {
        public MobileVersionDecorator(IWebPage webPage) : base(webPage)
        {
        }

        public override int GetRank()
        {
            return base.GetRank() + 2;
        }
    }
}