#pragma checksum "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809f1fc8a9c35f480b96ad9352539feb90d7814f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\_ViewImports.cshtml"
using SEDC.PizzApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809f1fc8a9c35f480b96ad9352539feb90d7814f", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac86c6d454259826656f07799af37aa3eb6324af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Contact.cshtml"
  
    ViewBag.Title = "Contact";

#line default
#line hidden
            BeginContext(39, 349, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>For any problems with our deliveries or feedback you can contact us on:</h1>
    <h4>Email</h4>
    <p>hello@pizzapp.com</p>
    <h4>Phone</h4>
    <p>38970999999</p>
    <h4>Address</h4>
    <p>Pizza St. No. 23/4</p>
    <p>
        <h3>Leave Feedback</h3>
        <button class=""btn btn-primary btn-lg"">");
            EndContext();
            BeginContext(389, 47, false);
#line 15 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Contact.cshtml"
                                          Write(Html.ActionLink("Feedback", "Feedback", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(436, 49, true);
            WriteLiteral("</button>\r\n    </p>\r\n</div>\r\n<h1></h1>\r\n<p></p>\r\n");
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
