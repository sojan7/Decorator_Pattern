using Decorator_Pattern.Component;

namespace Decorator_Pattern.Decorator
{
    internal abstract class WebPageDecorator : IWebPage
    {
        protected IWebPage _webPage;

        public WebPageDecorator(IWebPage webPage)
        {
            _webPage = webPage;
        }

        public virtual int GetRank()
        {
            return _webPage.GetRank();
        }
    }
}