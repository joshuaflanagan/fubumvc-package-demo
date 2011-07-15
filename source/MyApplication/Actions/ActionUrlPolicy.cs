using FubuMVC.Core.Diagnostics;
using FubuMVC.Core.Registration.Conventions;
using FubuMVC.Core.Registration.Nodes;
using FubuMVC.Core.Registration.Routes;

namespace MyApplication.Actions
{
    public class ActionUrlPolicy : IUrlPolicy
    {
        public bool Matches(ActionCall call, IConfigurationObserver log)
        {
            return call.HandlerType.Name.EndsWith("Action");
        }

        public IRouteDefinition Build(ActionCall call)
        {
            var routeDefinition = call.ToRouteDefinition();
            routeDefinition.Append(call.HandlerType.Namespace.Replace(GetType().Namespace + ".", string.Empty).ToLower());
            routeDefinition.Append(call.HandlerType.Name.Replace("Action", string.Empty).ToLower());
            return routeDefinition;
        }
    }
}