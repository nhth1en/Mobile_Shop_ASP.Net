#pragma checksum "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f788f1320dc6bbb8750f14fb420978f2f3b7a1dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductManagement_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductManagement/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductManagement/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductManagement_Detail))]
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
#line 1 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f788f1320dc6bbb8750f14fb420978f2f3b7a1dd", @"/Areas/Admin/Views/ProductManagement/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60903519c4e7745bb5980f9332ec0c1241a7f90f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductManagement_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/ProductManagement/DetailCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block; margin-top: 20px; font-size: 18px; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(117, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f788f1320dc6bbb8750f14fb420978f2f3b7a1dd6591", async() => {
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
            BeginContext(193, 130, true);
            WriteLiteral("\n<div class=\"wrapper-content\">\n    <h2>CHI TIẾT SẢN PHẨM</h2>\n    <div class=\"box\">\n        <div class=\"box__detail\">\n            ");
            EndContext();
            BeginContext(323, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f788f1320dc6bbb8750f14fb420978f2f3b7a1dd7982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 333, "~/images/products/", 333, 18, true);
#line 11 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
AddHtmlAttributeValue("", 351, Model.Product_ImageThumbnail, 351, 29, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 185, true);
            WriteLiteral("\n        </div>\n        <div class=\"box__detail\">\n            <table>\n                <tr>\n                    <td style=\"font-weight: bold;\">Tên sản phẩm:</td>\n                    <td>");
            EndContext();
            BeginContext(602, 18, false);
#line 17 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(620, 134, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td style=\"font-weight: bold;\">Giá:</td>\n                    <td>");
            EndContext();
            BeginContext(755, 37, false);
#line 21 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(792, 117, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td style=\"font-weight: bold;\">Trạng thái:</td>\n");
            EndContext();
#line 25 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                     if (@Model.Product_InStock == true)
                    {

#line default
#line hidden
            BeginContext(988, 42, true);
            WriteLiteral("                        <td>Còn hàng</td>\n");
            EndContext();
#line 28 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1099, 42, true);
            WriteLiteral("                        <td>Hết hàng</td>\n");
            EndContext();
#line 32 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1163, 110, true);
            WriteLiteral("                </tr>\n                <tr>\n                    <td style=\"font-weight: bold;\">Yêu thích:</td>\n");
            EndContext();
#line 36 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                     if (@Model.Product_IsPreferred == true)
                    {

#line default
#line hidden
            BeginContext(1356, 62, true);
            WriteLiteral("                        <td><i class=\"fas fa-check\"></i></td>\n");
            EndContext();
#line 39 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1487, 40, true);
            WriteLiteral("                        <td>&nbsp;</td>\n");
            EndContext();
#line 43 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1549, 133, true);
            WriteLiteral("                </tr>\n                <tr>\n                    <td style=\"font-weight: bold;\">Lượt mua:</td>\n                    <td>");
            EndContext();
            BeginContext(1683, 23, false);
#line 47 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Purchased);

#line default
#line hidden
            EndContext();
            BeginContext(1706, 61, true);
            WriteLiteral("</td>\n                </tr>\n            </table>\n            ");
            EndContext();
            BeginContext(1767, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f788f1320dc6bbb8750f14fb420978f2f3b7a1dd13455", async() => {
                BeginContext(1869, 22, true);
                WriteLiteral("Chỉnh sửa sản phẩm này");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1895, 289, true);
            WriteLiteral(@"
        </div>
        <div class=""box__detail"">
            <table>
                <tr>
                    <th class=""product-info__label"" colspan=""2"">Hệ điều hành - CPU</th>
                </tr>
                <tr>
                    <td>Hệ điều hành:</td>
                    <td>");
            EndContext();
            BeginContext(2185, 29, false);
#line 59 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_OperatingSystem);

#line default
#line hidden
            EndContext();
            BeginContext(2214, 124, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Chipset(Hãng SX CPU):</td>\n                    <td>");
            EndContext();
            BeginContext(2339, 21, false);
#line 63 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Chipset);

#line default
#line hidden
            EndContext();
            BeginContext(2360, 114, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Tốc độ CPU:</td>\n                    <td>");
            EndContext();
            BeginContext(2475, 22, false);
#line 67 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_CPUSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(2497, 121, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Chip đồ họa (GPU):</td>\n                    <td>");
            EndContext();
            BeginContext(2619, 17, false);
#line 71 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_GPU);

#line default
#line hidden
            EndContext();
            BeginContext(2636, 237, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <th class=\"product-info__label\" colspan=\"2\">Màn hình</th>\n                </tr>\n                <tr>\n                    <td>Độ phân giải:</td>\n                    <td>");
            EndContext();
            BeginContext(2874, 30, false);
#line 78 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_ScreenResolution);

#line default
#line hidden
            EndContext();
            BeginContext(2904, 117, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Màn hình rộng:</td>\n                    <td>");
            EndContext();
            BeginContext(3022, 25, false);
#line 82 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_ScreenWidth);

#line default
#line hidden
            EndContext();
            BeginContext(3047, 236, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <th class=\"product-info__label\" colspan=\"2\">Bộ nhớ & lưu trữ</th>\n                </tr>\n                <tr>\n                    <td>RAM:</td>\n                    <td>");
            EndContext();
            BeginContext(3284, 17, false);
#line 89 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_RAM);

#line default
#line hidden
            EndContext();
            BeginContext(3301, 116, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Bộ nhớ trong:</td>\n                    <td>");
            EndContext();
            BeginContext(3418, 17, false);
#line 93 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_ROM);

#line default
#line hidden
            EndContext();
            BeginContext(3435, 94, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Hỗ trợ thẻ nhớ:</td>\n");
            EndContext();
#line 97 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                     if (Model.Product_SDCardSupport == true)
                    {

#line default
#line hidden
            BeginContext(3613, 36, true);
            WriteLiteral("                        <td>Có</td>\n");
            EndContext();
#line 100 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3718, 39, true);
            WriteLiteral("                        <td>Không</td>\n");
            EndContext();
#line 104 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(3779, 111, true);
            WriteLiteral("                </tr>\n                <tr>\n                    <td>Thẻ nhớ ngoài:</td>\n                    <td>");
            EndContext();
            BeginContext(3891, 20, false);
#line 108 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_SDCard);

#line default
#line hidden
            EndContext();
            BeginContext(3911, 235, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <th class=\"product-info__label\" colspan=\"2\">Camera</th>\n                </tr>\n                <tr>\n                    <td>Camera trước:</td>\n                    <td>");
            EndContext();
            BeginContext(4147, 25, false);
#line 115 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_FrontCamera);

#line default
#line hidden
            EndContext();
            BeginContext(4172, 114, true);
            WriteLiteral("</td>\n                </tr>\n                <tr>\n                    <td>Camera sau:</td>\n                    <td>");
            EndContext();
            BeginContext(4287, 24, false);
#line 119 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_RearCamera);

#line default
#line hidden
            EndContext();
            BeginContext(4311, 79, true);
            WriteLiteral("</td>\n                </tr>\n            </table>\n        </div>\n    </div>\n    ");
            EndContext();
            BeginContext(4390, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f788f1320dc6bbb8750f14fb420978f2f3b7a1dd21740", async() => {
                BeginContext(4425, 64, true);
                WriteLiteral("\n        <i class=\"fas fa-arrow-left\"></i>\n        Quay lại\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4493, 8, true);
            WriteLiteral("\n</div>\n");
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
