#pragma checksum "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e70a9ee1be2104663cc5a2c19a0f13eadc1500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Search), @"mvc.1.0.view", @"/Views/Search/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e70a9ee1be2104663cc5a2c19a0f13eadc1500", @"/Views/Search/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b6e7d84013a44bd0102d53deedd73339cf0c715", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
   ViewData["Title"] = "Поиск"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 5 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3 card shadow\">\r\n\r\n            <div class=\"card-body\">\r\n                <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 241, "\"", 277, 2);
            WriteAttributeValue("", 248, "/comparing/add?id=", 248, 18, true);
#nullable restore
#line 10 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
WriteAttributeValue("", 266, product.Id, 266, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\"><img class=\"figure-img\" src=\"http://s1.iconbird.com/ico/2013/6/289/w512h5121371656132tasks.png\" height=\"40\" width=\"40\" /></a>\r\n                <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 450, "\"", 486, 2);
            WriteAttributeValue("", 457, "/favorites/add?id=", 457, 18, true);
#nullable restore
#line 11 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
WriteAttributeValue("", 475, product.Id, 475, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button""><img class=""figure-img text-lg-right"" src=""http://s1.iconbird.com/ico/2013/9/450/w256h2561380453904heart256x25632.png"" height=""30"" width=""30"" /></a>
                <br />
                <br />
                <img class=""card-img-bottom""");
            BeginWriteAttribute("src", " src=\"", 744, "\"", 768, 1);
#nullable restore
#line 14 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
WriteAttributeValue("", 750, product.ImagePath, 750, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"container\">\r\n\r\n                <div class=\"row align-items-end\">\r\n\r\n                    <div class=\"col\">\r\n\r\n                        <a style=\"color:blueviolet\"");
            BeginWriteAttribute("href", " href=\"", 980, "\"", 1013, 2);
            WriteAttributeValue("", 987, "/product/index/", 987, 15, true);
#nullable restore
#line 23 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
WriteAttributeValue("", 1002, product.Id, 1002, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5>");
#nullable restore
#line 23 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
                                                                                     Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n                        <h5>");
#nullable restore
#line 24 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
                       Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб.</h5><br />\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1152, "\"", 1190, 2);
            WriteAttributeValue("", 1159, "/cart/add?productId=", 1159, 20, true);
#nullable restore
#line 25 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
WriteAttributeValue("", 1179, product.Id, 1179, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Добавить в корзину</a>\r\n                        <br />\r\n                        <br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>");
#nullable restore
#line 31 "E:\MyShopWebApp\OnlineShop\OnlineShopWebApp\Views\Search\Search.cshtml"
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
