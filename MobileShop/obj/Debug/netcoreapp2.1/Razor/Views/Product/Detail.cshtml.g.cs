#pragma checksum "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dabc154985900b8feba20007f81da2710692f8bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Detail.cshtml", typeof(AspNetCore.Views_Product_Detail))]
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
#line 1 "D:\Tool\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "D:\Tool\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "D:\Tool\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dabc154985900b8feba20007f81da2710692f8bd", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8282febc87a857b1dd3c8924bd5c37fdb8cfb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/css/Product/DetailCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dabc154985900b8feba20007f81da2710692f8bd5569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(177, 94, true);
            WriteLiteral("\n\n<div class=\"product-detail\">\n    <div class=\"product-detail__title\">\n        <h2>Điện thoại ");
            EndContext();
            BeginContext(272, 28, false);
#line 10 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                  Write(ViewBag.Product.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(300, 107, true);
            WriteLiteral("</h2>\n    </div>\n    <div class=\"product-detail__content\">\n        <div class=\"product-image\">\n            ");
            EndContext();
            BeginContext(407, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dabc154985900b8feba20007f81da2710692f8bd7363", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 417, "~/images/products/", 417, 18, true);
#line 14 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 435, ViewBag.Product.Product_ImageThumbnail, 435, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(488, 88, true);
            WriteLiteral("\n        </div>\n        <div class=\"product-xxx\">\n            <h2 class=\"product-price\">");
            EndContext();
            BeginContext(577, 47, false);
#line 17 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                                 Write(ViewBag.Product.Product_Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(624, 312, true);
            WriteLiteral(@"</h2>
            <div class=""product-info"">
                <table>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Hệ điều hành - CPU</th>
                    </tr>
                    <tr>
                        <td>Hệ điều hành:</td>
                        <td>");
            EndContext();
            BeginContext(937, 39, false);
#line 25 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_OperatingSystem);

#line default
#line hidden
            EndContext();
            BeginContext(976, 140, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Chipset(Hãng SX CPU):</td>\n                        <td>");
            EndContext();
            BeginContext(1117, 31, false);
#line 29 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_Chipset);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 130, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Tốc độ CPU:</td>\n                        <td>");
            EndContext();
            BeginContext(1279, 32, false);
#line 33 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_CPUSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 137, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Chip đồ họa (GPU):</td>\n                        <td>");
            EndContext();
            BeginContext(1449, 27, false);
#line 37 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_GPU);

#line default
#line hidden
            EndContext();
            BeginContext(1476, 265, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Màn hình</th>
                    </tr>
                    <tr>
                        <td>Độ phân giải:</td>
                        <td>");
            EndContext();
            BeginContext(1742, 40, false);
#line 44 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_ScreenResolution);

#line default
#line hidden
            EndContext();
            BeginContext(1782, 133, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Màn hình rộng:</td>\n                        <td>");
            EndContext();
            BeginContext(1916, 35, false);
#line 48 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_ScreenWidth);

#line default
#line hidden
            EndContext();
            BeginContext(1951, 264, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Bộ nhớ & lưu trữ</th>
                    </tr>
                    <tr>
                        <td>RAM:</td>
                        <td>");
            EndContext();
            BeginContext(2216, 27, false);
#line 55 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_RAM);

#line default
#line hidden
            EndContext();
            BeginContext(2243, 132, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Bộ nhớ trong:</td>\n                        <td>");
            EndContext();
            BeginContext(2376, 27, false);
#line 59 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_ROM);

#line default
#line hidden
            EndContext();
            BeginContext(2403, 106, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Hỗ trợ thẻ nhớ:</td>\n");
            EndContext();
#line 63 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                         if (ViewBag.Product.Product_SDCardSupport == true)
                        {

#line default
#line hidden
            BeginContext(2611, 40, true);
            WriteLiteral("                            <td>Có</td>\n");
            EndContext();
#line 66 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2732, 43, true);
            WriteLiteral("                            <td>Không</td>\n");
            EndContext();
#line 70 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
            BeginContext(2801, 127, true);
            WriteLiteral("                    </tr>\n                    <tr>\n                        <td>Thẻ nhớ ngoài:</td>\n                        <td>");
            EndContext();
            BeginContext(2929, 30, false);
#line 74 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_SDCard);

#line default
#line hidden
            EndContext();
            BeginContext(2959, 263, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Camera</th>
                    </tr>
                    <tr>
                        <td>Camera trước:</td>
                        <td>");
            EndContext();
            BeginContext(3223, 35, false);
#line 81 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_FrontCamera);

#line default
#line hidden
            EndContext();
            BeginContext(3258, 130, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Camera sau:</td>\n                        <td>");
            EndContext();
            BeginContext(3389, 34, false);
#line 85 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                       Write(ViewBag.Product.Product_RearCamera);

#line default
#line hidden
            EndContext();
            BeginContext(3423, 76, true);
            WriteLiteral("</td>\n                    </tr>\n                </table>\n            </div>\n");
            EndContext();
#line 89 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
             if (ViewBag.Product.Product_InStock == true)
            {

#line default
#line hidden
            BeginContext(3571, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3587, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dabc154985900b8feba20007f81da2710692f8bd16688", async() => {
                BeginContext(3694, 17, true);
                WriteLiteral("THÊM VÀO GIỎ HÀNG");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                                                                                  WriteLiteral(ViewBag.Product.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3715, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 92 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3761, 94, true);
            WriteLiteral("                <a style=\"background-color: #f76464;\" disabled=\"disable\">SẢN PHẨM TẠM HẾT</a>\n");
            EndContext();
#line 96 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3869, 109, true);
            WriteLiteral("        </div>\n        <div class=\"product-related\">\n            <h2>Các sản phẩm khác</h2>\n            <ul>\n");
            EndContext();
#line 101 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
            BeginContext(4038, 49, true);
            WriteLiteral("                    <li>\n                        ");
            EndContext();
            BeginContext(4087, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dabc154985900b8feba20007f81da2710692f8bd20265", async() => {
                BeginContext(4139, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(4168, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dabc154985900b8feba20007f81da2710692f8bd20673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4178, "~/images/products/", 4178, 18, true);
#line 105 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 4196, p.Product_ImageThumbnail, 4196, 25, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4235, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 104 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                                                 WriteLiteral(p.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4264, 31, true);
            WriteLiteral("\n                        <span>");
            EndContext();
            BeginContext(4296, 14, false);
#line 107 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                         Write(p.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(4310, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 109 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(4362, 117, true);
            WriteLiteral("            </ul>\n        </div>\n        <div class=\"product-description\">\n            <h2>Mô tả</h2>\n            <p>");
            EndContext();
            BeginContext(4480, 35, false);
#line 114 "D:\Tool\MobileShop\MobileShop\Views\Product\Detail.cshtml"
          Write(ViewBag.Product.Product_Description);

#line default
#line hidden
            EndContext();
            BeginContext(4515, 39, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
