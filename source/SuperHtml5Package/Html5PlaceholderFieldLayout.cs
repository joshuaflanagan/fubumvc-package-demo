using System.Collections.Generic;
using FubuMVC.Core.UI.Forms;
using HtmlTags;
using FubuCore;

namespace SuperHtml5Package
{
    public class Html5PlaceholderFieldLayout : ILabelAndFieldLayout
    {
        public IEnumerable<HtmlTag> AllTags()
        {
            return new HtmlTag[0];
        }

        public HtmlTag LabelTag { get; set; }

        public HtmlTag BodyTag { get; set; }

        public override string ToString()
        {
            // if it's type=text, then don't render label, but use placeholder
            var attr = BodyTag.Attr("type");
            if( attr.IsNotEmpty() && attr.EqualsIgnoreCase("text"))
            {
                var labelText = LabelTag.Text();
                BodyTag.Attr("placeholder", labelText);
                return BodyTag.ToString();
            }
            
            // otherwise, render like normal (wrap the label around the body tag)
            LabelTag.Append(BodyTag);
            return LabelTag.ToString();
        }
    }
}