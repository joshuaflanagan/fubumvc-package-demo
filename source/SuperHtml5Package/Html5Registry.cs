using Bottles;
using StructureMap.Configuration.DSL;

namespace SuperHtml5Package
{
    public class Html5Registry : Registry
    {
        public Html5Registry()
        {
            For<IActivator>().Add<Html5Activator>();
        }
    }
}