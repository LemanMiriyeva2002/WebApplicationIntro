#pragma checksum "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b64ab37f3b090b0ad37eb18a5a3ccaa43b51c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index3), @"mvc.1.0.view", @"/Views/Product/Index3.cshtml")]
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
#line 1 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\_ViewImports.cshtml"
using WebApplicationIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\_ViewImports.cshtml"
using WebApplicationIntro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b64ab37f3b090b0ad37eb18a5a3ccaa43b51c79", @"/Views/Product/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ade97e748c5397429aadec9a195e4e242f09f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item active\">All Products</li>\r\n");
#nullable restore
#line 6 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                  
                    foreach (var category in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">");
#nullable restore
#line 9 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                                               Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </ul>
        </div>
    <div class=""col-9"">
        <table class=""table table-striped"">
            <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>CategoryId</th>
                <th>ProductName</th>
                <th>UnitPrice</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                   Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                   Write(product.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                   Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
                   Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\User\source\repos\WebApplicationIntro\WebApplicationIntro\Views\Product\Index3.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
