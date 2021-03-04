using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using WaterProject.Models.ViewModels;

namespace WaterProject.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;     // As long as the object is alive, it will stay in memory

        public PageLinkTagHelper(IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }


        [ViewContext]
        [HtmlAttributeNotBound]     // These are attributes
                                    
        public ViewContext ViewContext { get; set; }     // These are properties

        public PagingInfo PageModel { get; set; }   // Internal class rather than a system class

        public string PageAction { get; set; }


        // Storing a key and whatever object goes with that key

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]

        public Dictionary<string, object> PageUrlValues { get; set; } = new Dictionary<string, object>();


        public bool PageClassesEnabled { get; set; } = false;

        public string PageClass { get; set; }

        public string PageClassNormal { get; set; }

        public string PageClassSelected { get; set; }



        // Overriding
        public override void Process(TagHelperContext context, TagHelperOutput output)  // Takes in 2 parameters // Overriding the process
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)     // PagingInfo object, pull Total Pages from class
            {
                TagBuilder tag = new TagBuilder("a");

                PageUrlValues["page"] = i;
                tag.Attributes["href"] = urlHelper.Action(PageAction,
                    PageUrlValues);

                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);      // Short-hand if statement
                }

                tag.InnerHtml.Append(i.ToString());

                result.InnerHtml.AppendHtml(tag);
            }

            output.Content.AppendHtml(result.InnerHtml);    // This is the finished product of all of the HTML that we have constructed
        }
    }
}
