#pragma checksum "C:\Dragan\Drakso\MVC\sedc7-08-aspnetmvc\g5\SEDC.PizzApp.Reworked\SEDC.PizzApp.WebApp\Views\Shared\_Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7938073318dff8cd1b3f44f2d1e8321808853aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Error), @"mvc.1.0.view", @"/Views/Shared/_Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Error.cshtml", typeof(AspNetCore.Views_Shared__Error))]
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
#line 1 "C:\Dragan\Drakso\MVC\sedc7-08-aspnetmvc\g5\SEDC.PizzApp.Reworked\SEDC.PizzApp.WebApp\Views\_ViewImports.cshtml"
using SEDC.PizzApp.WebApp;

#line default
#line hidden
#line 2 "C:\Dragan\Drakso\MVC\sedc7-08-aspnetmvc\g5\SEDC.PizzApp.Reworked\SEDC.PizzApp.WebApp\Views\_ViewImports.cshtml"
using SEDC.PizzApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7938073318dff8cd1b3f44f2d1e8321808853aa", @"/Views/Shared/_Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da1b657eb2d39b8bad0a8185b132f90f17b91ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Dragan\Drakso\MVC\sedc7-08-aspnetmvc\g5\SEDC.PizzApp.Reworked\SEDC.PizzApp.WebApp\Views\Shared\_Error.cshtml"
  
    ViewBag.Title = "Sorry";

#line default
#line hidden
            BeginContext(37, 226, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>Sorry but there is no order/address on this url</h1>\r\n    <p>For any problems please contact us or leave feedback to help us improve</p>\r\n    <p>\r\n        <button class=\"btn btn-danger btn-lg\">");
            EndContext();
            BeginContext(264, 47, false);
#line 8 "C:\Dragan\Drakso\MVC\sedc7-08-aspnetmvc\g5\SEDC.PizzApp.Reworked\SEDC.PizzApp.WebApp\Views\Shared\_Error.cshtml"
                                         Write(Html.ActionLink("Feedback", "Feedback", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(311, 29, true);
            WriteLiteral("</button>\r\n    </p>\r\n</div>\r\n");
            EndContext();
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