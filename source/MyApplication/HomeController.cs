using FubuMVC.WebForms;

namespace MyApplication
{
    public class HomeController
    {
        public HomeViewModel Index()
        {
            return new HomeViewModel();
        }
    }

    public class HomeViewModel
    {
    }

    public class Index : FubuPage<HomeViewModel>
    {
    }
}