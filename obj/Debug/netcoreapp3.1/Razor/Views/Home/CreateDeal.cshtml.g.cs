#pragma checksum "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6a17e6ab6ccf297f29c2158be5d95de55e3228a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateDeal), @"mvc.1.0.view", @"/Views/Home/CreateDeal.cshtml")]
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
#line 1 "/Users/admin/Projects/NewProj/NewProj/Views/_ViewImports.cshtml"
using NewProj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Projects/NewProj/NewProj/Views/_ViewImports.cshtml"
using NewProj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a17e6ab6ccf297f29c2158be5d95de55e3228a", @"/Views/Home/CreateDeal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffdc5b2315d87c473f6911cfbb1e3d8646e4cedc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateDeal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewProj.Models.Deal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
  
    ViewBag.Title = "CreateDeal";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Создание сделки</h2>\r\n\r\n");
#nullable restore
#line 9 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
 using (Html.BeginForm("SaveDeal", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n        .deal {\r\n            width: 600px;\r\n            margin: 0 auto;\r\n        }\r\n\r\n        .deal > * {\r\n            width: 100%;\r\n        }\r\n    </style>\r\n    <div class=\"deal\">\r\n        ");
#nullable restore
#line 22 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
   Write(Html.HiddenFor(m => m.DealId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <p>\r\n            ");
#nullable restore
#line 24 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.LabelFor(m => m.DealName, "Описание технического задания"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 26 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.EditorFor(m => m.DealName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 29 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.LabelFor(m => m.Owner, "Владелец"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 31 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.EditorFor(m => m.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 35 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.LabelFor(m => m.Customer, "Бригада конструкторов"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 37 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.EditorFor(m => m.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </p>\r\n        <p>\r\n            ");
#nullable restore
#line 41 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.LabelFor(m => m.Price, "Стоимость проектирования и строительства"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 43 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
       Write(Html.EditorFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p><input type=\"submit\" class=\"btn btn-primary\" value=\"Создать\" /></p>\r\n    </div>\r\n");
#nullable restore
#line 47 "/Users/admin/Projects/NewProj/NewProj/Views/Home/CreateDeal.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewProj.Models.Deal> Html { get; private set; }
    }
}
#pragma warning restore 1591
