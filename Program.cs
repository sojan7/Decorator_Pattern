using Decorator_Pattern.Component;
using Decorator_Pattern.ConcreteComponent;
using Decorator_Pattern.ConcreteDecorator;
using Decorator_Pattern.ConcreteWidget;
using Decorator_Pattern.WidgetComponent;

namespace Decorator_Pattern
{
    internal class Program
    {
        private static void Main()
        {
            IWebPage webPage = new BaseWebPage();

            webPage = new MobileVersionDecorator(webPage);
            webPage = new DesktopVersionDecorator(webPage);

            List<IWidget> widgets =
            [
                new Widget(2),
                new Widget(3)
            ];

            int totalRank = webPage.GetRank() + widgets.Sum(w => w.GetRank());
            Console.WriteLine("Rank of the webpage: " + totalRank);
        }
    }
}