#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598b5ddeed413e7afa2f238a5d408853e9cfd2b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_View), @"mvc.1.0.view", @"/Pages/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598b5ddeed413e7afa2f238a5d408853e9cfd2b3", @"/Pages/View.cshtml")]
    public class Pages_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASM.Share.Models.Nguoidung>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Admin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Locked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Admin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Locked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2342, "\"", 2374, 1);
#nullable restore
#line 82 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
WriteAttributeValue("", 2357, item.NguoidungID, 2357, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2427, "\"", 2459, 1);
#nullable restore
#line 83 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
WriteAttributeValue("", 2442, item.NguoidungID, 2442, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2514, "\"", 2546, 1);
#nullable restore
#line 84 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
WriteAttributeValue("", 2529, item.NguoidungID, 2529, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\View.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASM.Share.Models.Nguoidung>> Html { get; private set; }
    }
}
#pragma warning restore 1591