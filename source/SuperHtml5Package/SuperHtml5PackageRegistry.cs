using System;
using System.ComponentModel.DataAnnotations;
using FubuMVC.Core;
using FubuMVC.Core.UI;
using FubuCore;

namespace SuperHtml5Package
{
    public class SuperHtml5PackageRegistry : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.HtmlConvention<SuperHtml5Conventions>();
        }
    }

    public class SuperHtml5Conventions : HtmlConventionRegistry
    {
        public SuperHtml5Conventions()
        {
            // date
            Editors.IfPropertyIs<DateTime>().Modify(t => t.Attr("type", "date"));
            
            // email
            Editors.If(d => d.Accessor.Name.ToLowerInvariant().EndsWith("email")).Modify(t => t.Attr("type", "email"));
            
            // number
            Editors.If(d => d.Accessor.PropertyType.IsNumeric()).Modify(t => t.Attr("type", "number"));
            
            // required
            Editors.ModifyForAttribute<RequiredAttribute>(t => t.Attr("required", "required"));
            
            // range (look for data annotations range attribute)
            Editors.ModifyForAttribute<RangeAttribute>((t,a) => t
                    .Attr("size", 2)
                    .Attr("min", a.Minimum)
                    .Attr("max", a.Maximum));
        }
    }
}