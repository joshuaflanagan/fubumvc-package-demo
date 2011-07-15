using FubuMVC.WebForms;

namespace MyApplication.Actions.Home
{
    public class HomeAction
    {
        public HomeViewModel Get()
        {
            return new HomeViewModel();
        }
    }

    public class HomeViewModel
    {
    }

    public class Home : FubuPage<HomeViewModel>
    {
    }
}