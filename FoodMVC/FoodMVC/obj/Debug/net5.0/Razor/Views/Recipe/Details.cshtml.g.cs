#pragma checksum "C:\Users\Alban\source\repos\FoodMVC\FoodMVC\Views\Recipe\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30c8fcb62e3f123b41538a626c1b76eda8daaed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Details), @"mvc.1.0.view", @"/Views/Recipe/Details.cshtml")]
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
#line 1 "C:\Users\Alban\source\repos\FoodMVC\FoodMVC\Views\_ViewImports.cshtml"
using FoodMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alban\source\repos\FoodMVC\FoodMVC\Views\_ViewImports.cshtml"
using FoodMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30c8fcb62e3f123b41538a626c1b76eda8daaed1", @"/Views/Recipe/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a07292cfd067281e29864bd2496a7a5859d1d92", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 style=\"color:whitesmoke; margin-left:80px\" >Recipe Details</h1>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Alban\source\repos\FoodMVC\FoodMVC\Views\Recipe\Details.cshtml"
  
    var recipesD = (Recipe)ViewData["recipesD"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 20rem; margin-left:70px\">\r\n \r\n        <img");
            BeginWriteAttribute("src", " src=\"", 206, "\"", 231, 1);
#nullable restore
#line 10 "C:\Users\Alban\source\repos\FoodMVC\FoodMVC\Views\Recipe\Details.cshtml"
WriteAttributeValue("", 212, recipesD.dishImage, 212, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" width=\"300\" height=\"400\">\r\n    \r\n    <div class=\"card-body\">\r\n \r\n        <p class=\"card-text\" style=\"font-family: \'Comic Sans MS\'\">");
#nullable restore
#line 14 "C:\Users\Alban\source\repos\FoodMVC\FoodMVC\Views\Recipe\Details.cshtml"
                                                             Write(recipesD.ingredients);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
