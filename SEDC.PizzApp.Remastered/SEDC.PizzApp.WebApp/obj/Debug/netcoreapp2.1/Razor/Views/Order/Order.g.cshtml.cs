#pragma checksum "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe453c4e55376deaf964fdb1b5ef4cf0065b68be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Order.cshtml", typeof(AspNetCore.Views_Order_Order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe453c4e55376deaf964fdb1b5ef4cf0065b68be", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac86c6d454259826656f07799af37aa3eb6324af", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
  
    ViewBag.Title = "Order Pizza";

#line default
#line hidden
            BeginContext(66, 26, true);
            WriteLiteral("<h1>Order pizza</h1>\r\n<h3>");
            EndContext();
            BeginContext(93, 13, false);
#line 6 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(106, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 7 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(143, 157, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"input-group input-group-lg\">\r\n                <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(301, 31, false);
#line 12 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                                           Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(332, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(358, 66, false);
#line 13 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
           Write(Html.TextBoxFor(x => x.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(424, 172, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"input-group input-group-lg\">\r\n                <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(597, 30, false);
#line 18 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                                           Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(627, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(653, 65, false);
#line 19 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
           Write(Html.TextBoxFor(x => x.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(718, 207, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"input-group input-group-lg\">\r\n                <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(926, 29, false);
#line 26 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                                           Write(Html.LabelFor(x => x.Address));

#line default
#line hidden
            EndContext();
            BeginContext(955, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(981, 64, false);
#line 27 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
           Write(Html.TextBoxFor(x => x.Address, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 172, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"input-group input-group-lg\">\r\n                <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(1218, 27, false);
#line 32 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                                           Write(Html.LabelFor(x => x.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 25, true);
            WriteLiteral("</span>\r\n                ");
            EndContext();
            BeginContext(1271, 62, false);
#line 33 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
           Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 37 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
     for (int i = 0; i < Model.Pizzas.Count; i++)
    {
        

#line default
#line hidden
            BeginContext(1450, 32, false);
#line 39 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
   Write(Html.HiddenFor(x => x.Pizzas[i]));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 22, true);
            WriteLiteral("        <h1>Pizza no: ");
            EndContext();
            BeginContext(1508, 5, false);
#line 40 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                  Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 180, true);
            WriteLiteral("</h1>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"input-group input-group-lg\">\r\n                    <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(1695, 36, false);
#line 44 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                                               Write(Html.LabelFor(x => x.Pizzas[i].Name));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 29, true);
            WriteLiteral("</span>\r\n                    ");
            EndContext();
            BeginContext(1761, 71, false);
#line 45 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
               Write(Html.TextBoxFor(x => x.Pizzas[i].Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 192, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"input-group input-group-lg\">\r\n                    <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(2025, 36, false);
#line 50 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
                                               Write(Html.LabelFor(x => x.Pizzas[i].Size));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 29, true);
            WriteLiteral("</span>\r\n                    ");
            EndContext();
            BeginContext(2091, 132, false);
#line 51 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
               Write(Html.DropDownListFor(x => x.Pizzas[i].Size, Html.GetEnumSelectList(Model.Pizzas[i].Size.GetType()), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 55 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
    }

#line default
#line hidden
            BeginContext(2292, 68, true);
            WriteLiteral("    <button class=\"btn btn-default\" type=\"submit\"> Order </button>\r\n");
            EndContext();
#line 57 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Order\Order.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591