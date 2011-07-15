using FubuMVC.Core;
using FubuMVC.Core.UI.Extensibility;
using FubuMVC.Core.View;
using MyApplication.Actions.Todo;
using FubuMVC.WebForms;
using RemindersPackage.Partials.Todo;

namespace RemindersPackage
{
    public class RemindersExtension : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Extensions().For<NewTodoOutput>("new-todo", GetBodyContent);
        }

        private static object GetBodyContent(IFubuPage<NewTodoOutput> page)
        {
            return page.RenderPartialFor(new Reminder()).Using<NewReminder>().ToString();
        }
    }
}