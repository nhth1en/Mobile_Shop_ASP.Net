#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd37e86885f2a6d78d3517ac825ee6b478c5304"
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
#line 1 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd37e86885f2a6d78d3517ac825ee6b478c5304", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8282febc87a857b1dd3c8924bd5c37fdb8cfb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/css/Product/DetailCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(99, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3dca52d16e67438b868458965d5b9ae0", async() => {
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
            BeginContext(164, 1598, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""row-box"">
        <h5>
            DANH MỤC SẢN PHẨM
            <i class=""far fa-hand-point-down""></i>
        </h5>
        <span>
            <i class=""fas fa-map-marker-alt""></i>
            Địa chỉ: 123 Bình Giã, Vũng Tàu
        </span>
        <span>
            <i class=""fas fa-phone-alt""></i>
            Hotline: 1900.0702
        </span>
    </div>
</div>



<div class=""product-category"">
    <ul>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/iPhone-(Apple)42-b_16.jpg""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Samsung42-b_25.jpg""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/OPPO42-b_57.jpg""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Xiaomi42-b_31.png""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Huawei42-b_30.jpg""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Realme42-b_37.png""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Vsmar");
            WriteLiteral(@"t42-b_40.png""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Nokia42-b_21.jpg""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Coolpad42-b_33.png""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Asus-(Zenfone)42-b_14.jpg""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/BlackBerry42-b_38.png""></a></li>
        <li><a href=""#""><img src=""//cdn.tgdd.vn/Brand/1/Mobiistar42-b_20.jpg""></a></li>
    </ul>
</div>

<div class=""product-detail"">
    <div class=""product-detail__title"">
        <h2>Điện thoại ");
            EndContext();
            BeginContext(1763, 18, false);
#line 45 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                  Write(Model.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1781, 313, true);
            WriteLiteral(@"</h2>
    </div>
    <div class=""product-detail__content"">
        <div class=""product-image"">
            <img src=""https://cdn.tgdd.vn/Products/Images/42/198986/sieu-pham-galaxy-s-moi-2-512gb-black-400x460.png"" alt=""image"">
        </div>
        <div class=""product-xxx"">
            <h2 class=""product-price"">");
            EndContext();
            BeginContext(2095, 37, false);
#line 52 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                                 Write(Model.Product_Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 312, true);
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
            BeginContext(2445, 29, false);
#line 60 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_OperatingSystem);

#line default
#line hidden
            EndContext();
            BeginContext(2474, 140, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Chipset(Hãng SX CPU):</td>\n                        <td>");
            EndContext();
            BeginContext(2615, 21, false);
#line 64 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_Chipset);

#line default
#line hidden
            EndContext();
            BeginContext(2636, 130, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Tốc độ CPU:</td>\n                        <td>");
            EndContext();
            BeginContext(2767, 22, false);
#line 68 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_CPUSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(2789, 137, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Chip đồ họa (GPU):</td>\n                        <td>");
            EndContext();
            BeginContext(2927, 17, false);
#line 72 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_GPU);

#line default
#line hidden
            EndContext();
            BeginContext(2944, 265, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Màn hình</th>
                    </tr>
                    <tr>
                        <td>Độ phân giải:</td>
                        <td>");
            EndContext();
            BeginContext(3210, 30, false);
#line 79 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_ScreenResolution);

#line default
#line hidden
            EndContext();
            BeginContext(3240, 133, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Màn hình rộng:</td>\n                        <td>");
            EndContext();
            BeginContext(3374, 25, false);
#line 83 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_ScreenWidth);

#line default
#line hidden
            EndContext();
            BeginContext(3399, 264, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Bộ nhớ & lưu trữ</th>
                    </tr>
                    <tr>
                        <td>RAM:</td>
                        <td>");
            EndContext();
            BeginContext(3664, 17, false);
#line 90 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_RAM);

#line default
#line hidden
            EndContext();
            BeginContext(3681, 132, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Bộ nhớ trong:</td>\n                        <td>");
            EndContext();
            BeginContext(3814, 17, false);
#line 94 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_ROM);

#line default
#line hidden
            EndContext();
            BeginContext(3831, 106, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Hỗ trợ thẻ nhớ:</td>\n");
            EndContext();
#line 98 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                         if (Model.Product_SDCardSupport == true)
                        {

#line default
#line hidden
            BeginContext(4029, 40, true);
            WriteLiteral("                            <td>Có</td>\n");
            EndContext();
#line 101 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4150, 43, true);
            WriteLiteral("                            <td>Không</td>\n");
            EndContext();
#line 105 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
            BeginContext(4219, 127, true);
            WriteLiteral("                    </tr>\n                    <tr>\n                        <td>Thẻ nhớ ngoài:</td>\n                        <td>");
            EndContext();
            BeginContext(4347, 20, false);
#line 109 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_SDCard);

#line default
#line hidden
            EndContext();
            BeginContext(4367, 263, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th class=""product-info__label"" colspan=""2"">Camera</th>
                    </tr>
                    <tr>
                        <td>Camera trước:</td>
                        <td>");
            EndContext();
            BeginContext(4631, 25, false);
#line 116 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_FrontCamera);

#line default
#line hidden
            EndContext();
            BeginContext(4656, 130, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Camera sau:</td>\n                        <td>");
            EndContext();
            BeginContext(4787, 24, false);
#line 120 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                       Write(Model.Product_RearCamera);

#line default
#line hidden
            EndContext();
            BeginContext(4811, 88, true);
            WriteLiteral("</td>\n                    </tr>\n                </table>\n            </div>\n            ");
            EndContext();
            BeginContext(4899, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68a76603869b444988e496324102dca0", async() => {
                BeginContext(4996, 17, true);
                WriteLiteral("THÊM VÀO GIỎ HÀNG");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
                                                                              WriteLiteral(Model.Product_Id);

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
            BeginContext(5017, 1636, true);
            WriteLiteral(@"
        </div>
        <div class=""product-related"">
            <h2>Các sản phẩm liên quan</h2>
            <ul>
                <li>
                    <a href=""#"">
                        <img src=""https://cdn.tgdd.vn/Products/Images/42/202028/oppo-a9-2020-green-1-400x400.jpg"" alt="""">
                    </a>
                    <span>Điện thoại OPPO F12 PRO 256GB</span>
                </li>
                <li>
                    <a href=""#"">
                        <img src=""https://cdn.tgdd.vn/Products/Images/42/202028/oppo-a9-2020-green-1-400x400.jpg"" alt="""">
                    </a>
                    <span>Điện thoại OPPO F12 PRO 256GB</span>
                </li>
                <li>
                    <a href=""#"">
                        <img src=""https://cdn.tgdd.vn/Products/Images/42/202028/oppo-a9-2020-green-1-400x400.jpg"" alt="""">
                    </a>
                    <span>Điện thoại OPPO F12 PRO 256GB</span>
                </li>
                <li>
                    <a href=""#");
            WriteLiteral(@""">
                        <img src=""https://cdn.tgdd.vn/Products/Images/42/202028/oppo-a9-2020-green-1-400x400.jpg"" alt="""">
                    </a>
                    <span>Điện thoại OPPO F12 PRO 256GB</span>
                </li>
                <li>
                    <a href=""#"">
                        <img src=""https://cdn.tgdd.vn/Products/Images/42/202028/oppo-a9-2020-green-1-400x400.jpg"" alt="""">
                    </a>
                    <span>Điện thoại OPPO F12 PRO 256GB</span>
                </li>
            </ul>
        </div>

        <div class=""product-description"">
            <p>");
            EndContext();
            BeginContext(6654, 29, false);
#line 163 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Product\Detail.cshtml"
          Write(Model.Product_LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(6683, 39, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
