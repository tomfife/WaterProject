#pragma checksum "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850362ca3356fafd5e6e7af1397103395fdacbb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/_ViewImports.cshtml"
using WaterProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/_ViewImports.cshtml"
using WaterProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850362ca3356fafd5e6e7af1397103395fdacbb3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2466a95c20a627dfcb52660c824df5cc1b7dce8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<header>\n    <h1>Give the Gift of Water</h1>\n</header>\n\n");
#nullable restore
#line 11 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <h4>Program Name: ");
#nullable restore
#line 14 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml"
                     Write(x.Program);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>Program Type: ");
#nullable restore
#line 15 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml"
                    Write(x.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Impact: ");
#nullable restore
#line 16 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml"
              Write(x.Impact);

#line default
#line hidden
#nullable disable
            WriteLiteral(" people served</p>\n    </div>\n");
#nullable restore
#line 18 "/Users/thomas.fife/Projects/WaterProject/WaterProject/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
