#pragma checksum "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343a312458765c8e3cbf670975fb60187db2e828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Menu.cshtml", typeof(AspNetCore.Views_Home_Menu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343a312458765c8e3cbf670975fb60187db2e828", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac86c6d454259826656f07799af37aa3eb6324af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Menu.cshtml"
  
    ViewBag.Title = "Menu";

#line default
#line hidden
            BeginContext(58, 38, true);
            WriteLiteral("\r\n<h1 align=\"center\">Pizza Menu</h1>\r\n");
            EndContext();
#line 7 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Menu.cshtml"
 for (int i = 0; i < Model.Menu.Count; i++)
{
    

#line default
#line hidden
            BeginContext(149, 173, false);
#line 9 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Menu.cshtml"
Write(Html.Partial("_PizzaItem", new PizzaViewModel()
    {
        Name = Model.Menu[i].Name,
        Price = Model.Menu[i].Price,
        Image = Model.Menu[i].Image
    }));

#line default
#line hidden
            EndContext();
#line 14 "C:\Users\DraganGelevski\source\repos\SEDC.PizzApp.Remastered\SEDC.PizzApp.WebApp\Views\Home\Menu.cshtml"
      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591