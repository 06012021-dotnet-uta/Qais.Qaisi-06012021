#pragma checksum "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\Home\StoresDataList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd0619ec951218003713a953c02bf44bf69f1a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StoresDataList), @"mvc.1.0.view", @"/Views/Home/StoresDataList.cshtml")]
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
#line 1 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd0619ec951218003713a953c02bf44bf69f1a9", @"/Views/Home/StoresDataList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StoresDataList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shopping.Models.StoresName>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\Home\StoresDataList.cshtml"
  
    ViewData["Title"] = "StoresDataList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Stores List</h1>

<p>
   <!-- <a asp-action=""Create"">Create New</a>-->
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Store Name
            </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\Home\StoresDataList.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\Home\StoresDataList.cshtml"
               Write(Html.DisplayFor(modelItem => item.StoreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\Home\StoresDataList.cshtml"
               Write(Html.ActionLink("Select", "StoreBranchesList", new { id = item.StoreNameId, item.StoreName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\QQais\OneDrive\Desktop\ShoppingMVC\ShoppingStoreMVC\Shopping\Views\Home\StoresDataList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shopping.Models.StoresName>> Html { get; private set; }
    }
}
#pragma warning restore 1591
