#pragma checksum "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c1f6d3fb3090f5cd5199a78a80b0a53fbcfa08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comparing_Index), @"mvc.1.0.view", @"/Views/Comparing/Index.cshtml")]
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
#line 1 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShop.Db.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c1f6d3fb3090f5cd5199a78a80b0a53fbcfa08", @"/Views/Comparing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b6e7d84013a44bd0102d53deedd73339cf0c715", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comparing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
   ViewData["Title"] = "Товары для сравнения"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 6 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
     foreach (var product in Model)
    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-3 card shadow\">\r\n        <br />\r\n        <a class=\"btn btn-secondary\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 255, "\"", 291, 2);
            WriteAttributeValue("", 262, "/comparing/remove/", 262, 18, true);
#nullable restore
#line 10 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
WriteAttributeValue("", 280, product.Id, 280, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Убрать</a>\r\n        <br />\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 354, "\"", 378, 1);
#nullable restore
#line 12 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
WriteAttributeValue("", 360, product.ImagePath, 360, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n        <h5>");
#nullable restore
#line 13 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><br />\r\n        <h5>");
#nullable restore
#line 14 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
       Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб.</h5><br />\r\n        <h8>");
#nullable restore
#line 15 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
       Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h8><br />\r\n        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 550, "\"", 588, 2);
            WriteAttributeValue("", 557, "/cart/add?productId=", 557, 20, true);
#nullable restore
#line 16 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
WriteAttributeValue("", 577, product.Id, 577, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Добавить в корзину</a><br />\r\n\r\n\r\n    </div>");
#nullable restore
#line 19 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Comparing\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
