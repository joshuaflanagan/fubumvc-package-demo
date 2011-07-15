using System;
using System.Collections.Generic;
using Bottles;
using Bottles.Diagnostics;
using FubuMVC.Core.UI.Tags;

namespace SuperHtml5Package
{
    public class Html5Activator : IActivator
    {
        private readonly TagProfileLibrary _profileLibrary;

        public Html5Activator(TagProfileLibrary profileLibrary)
        {
            _profileLibrary = profileLibrary;
        }

        public void Activate(IEnumerable<IPackageInfo> packages, IPackageLog log)
        {
            _profileLibrary.DefaultProfile.UseLabelAndFieldLayout<Html5PlaceholderFieldLayout>();
        }
    }
}