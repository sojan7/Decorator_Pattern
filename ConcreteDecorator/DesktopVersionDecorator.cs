using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator;

namespace Decorator_Pattern.ConcreteDecorator
{
    internal class DesktopVersionDecorator : WebPageDecorator
    {
        public DesktopVersionDecorator(IWebPage webPage) : base(webPage)
        {
        }

        public override int GetRank()
        {
            return base.GetRank() + 3; // Increment rank for desktop version
        }
    }
}