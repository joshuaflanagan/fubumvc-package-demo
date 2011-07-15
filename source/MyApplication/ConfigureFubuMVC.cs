using System;
using System.Collections.Generic;
using FubuMVC.Core;
using FubuMVC.WebForms;
using MyApplication.Actions;
using MyApplication.Actions.Home;
using FubuCore;

namespace MyApplication
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            var httpVerbs = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase){"GET", "POST", "PUT", "HEAD"};

            // This line turns on the basic diagnostics and request tracing
            IncludeDiagnostics(true);

            // All public methods from concrete classes ending in "Action"
            // in this assembly are assumed to be action methods
            Actions
                .IncludeTypes(t => t.Namespace.StartsWith(typeof(ActionUrlPolicy).Namespace) && t.Name.EndsWith("Action"))
                .IncludeMethods(action => httpVerbs.Contains(action.Method.Name));

            httpVerbs.Each(verb => Routes.ConstrainToHttpMethod(action => 
                action.Method.Name.EqualsIgnoreCase(verb), verb));
            
            // Policies
            Routes
                .HomeIs<HomeAction>(x => x.Get())
                .IgnoreControllerNamesEntirely()
                .IgnoreMethodSuffix("Html")
                .RootAtAssemblyNamespace()
                .UrlPolicy<ActionUrlPolicy>();

            // Match views to action methods by matching
            // on model type, view name, and namespace
            Views.TryToAttachWithDefaultConventions();
            Import<WebFormsEngine>();
        }
    }
}