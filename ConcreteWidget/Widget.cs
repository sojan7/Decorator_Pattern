using Decorator_Pattern.WidgetComponent;

namespace Decorator_Pattern.ConcreteWidget
{
    internal class Widget : IWidget
    {
        private readonly int _rank;

        public Widget(int rank)
        {
            _rank = rank;
        }

        public int GetRank()
        {
            return _rank;
        }
    }
}