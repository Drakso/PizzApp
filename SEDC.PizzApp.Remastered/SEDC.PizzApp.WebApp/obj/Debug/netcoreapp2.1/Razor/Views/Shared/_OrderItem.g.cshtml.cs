#pragma checksum "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6ebbf22158162787ca59e59790b25df7d00d793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderItem), @"mvc.1.0.view", @"/Views/Shared/_OrderItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OrderItem.cshtml", typeof(AspNetCore.Views_Shared__OrderItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ebbf22158162787ca59e59790b25df7d00d793", @"/Views/Shared/_OrderItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac86c6d454259826656f07799af37aa3eb6324af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 67, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <h3>User: ");
            EndContext();
            BeginContext(95, 15, false);
#line 5 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml"
             Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(110, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(112, 14, false);
#line 5 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml"
                              Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(126, 32, true);
            WriteLiteral("</h3>\r\n        <p><b>Price: </b>");
            EndContext();
            BeginContext(159, 11, false);
#line 6 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml"
                    Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(170, 72, true);
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <h3>Pizzas:</h3>\r\n");
            EndContext();
#line 10 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml"
         foreach (var pizza in Model.Pizzas)
        {

#line default
#line hidden
            BeginContext(299, 47, true);
            WriteLiteral("            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(347, 33, false);
#line 13 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml"
           Write(Html.Partial("_PizzaItem", pizza));

#line default
#line hidden
            EndContext();
            BeginContext(380, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 15 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Shared\_OrderItem.cshtml"
        }

#line default
#line hidden
            BeginContext(413, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
