#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3c46b8a87e79ca5fd86b1f7f46f4c758211007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductManagement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductManagement/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductManagement_Index))]
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
#line 1 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3c46b8a87e79ca5fd86b1f7f46f4c758211007", @"/Areas/Admin/Views/ProductManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8282febc87a857b1dd3c8924bd5c37fdb8cfb2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/ProductManagement/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("witdh", new global::Microsoft.AspNetCore.Html.HtmlString("10%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(102, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68945dd40a644d35a682e997c4d5e79f", async() => {
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
            BeginContext(177, 341, true);
            WriteLiteral(@"

<div class=""wrapper-content"">
    <h2>TẤT CẢ SẢN PHẨM</h2>
    <table>
        <tr>
            <th>#</th>
            <th>Hình ảnh</th>
            <th>Tên sản phẩm</th>
            <th>Loại sản phẩm</th>
            <th>Giá</th>
            <th>Trạng thái</th>
            <th>Yêu thích</th>
            <th>Hành động</th>
        </tr>
");
            EndContext();
#line 21 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
          int i = 1;

#line default
#line hidden
            BeginContext(540, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 22 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(599, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(637, 1, false);
#line 25 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(638, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(685, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13dfc6aa870b488d8f5ed9bae415baa4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 695, "~/images/", 695, 9, true);
#line 27 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
AddHtmlAttributeValue("", 704, product.Product_ImageThumbnail, 704, 31, false);

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
            BeginContext(763, 43, true);
            WriteLiteral("\n                </td>\n                <td>");
            EndContext();
            BeginContext(807, 20, false);
#line 29 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
               Write(product.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(827, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 30 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                 foreach (var category in Model.Categories)
                {
                    if (product.Category_Id == category.Category_Id)
                    {

#line default
#line hidden
            BeginContext(1002, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1031, 22, false);
#line 34 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                       Write(category.Category_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 35 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1099, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1120, 39, false);
#line 37 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
               Write(product.Product_Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 38 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                 if (product.Product_InStock)
                {

#line default
#line hidden
            BeginContext(1229, 132, true);
            WriteLiteral("                    <td>\n                        <span style=\"background-color: #218838;\">Còn hàng</span>\n                    </td>\n");
            EndContext();
#line 43 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1418, 132, true);
            WriteLiteral("                    <td>\n                        <span style=\"background-color: #c82333;\">Hết hàng</span>\n                    </td>\n");
            EndContext();
#line 49 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1568, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 50 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                 if (product.Product_IsPreferred)
                {

#line default
#line hidden
            BeginContext(1636, 58, true);
            WriteLiteral("                    <td><i class=\"fas fa-check\"></i></td>\n");
            EndContext();
#line 53 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1751, 36, true);
            WriteLiteral("                    <td>&nbsp;</td>\n");
            EndContext();
#line 57 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1805, 49, true);
            WriteLiteral("                    <td>\n                        ");
            EndContext();
            BeginContext(1854, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f9c298cbeb6425e945b01a61cd70a5a", async() => {
                BeginContext(1928, 244, true);
                WriteLiteral("\n                            <button type=\"submit\" class=\"action-detail\">\n                                <i class=\"fas fa-info-circle\"></i>\n                                Chi tiết\n                            </button>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                                                    WriteLiteral(product.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2179, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2204, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b838e505bc24be6b2d096bda4b48a31", async() => {
                BeginContext(2276, 230, true);
                WriteLiteral("\n                            <button type=\"submit\" class=\"action-edit\">\n                                <i class=\"fas fa-edit\"></i>\n                                Sửa\n                            </button>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                                                  WriteLiteral(product.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2513, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2538, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d21640d3786f4c39bf23aed1c06850f3", async() => {
                BeginContext(2613, 307, true);
                WriteLiteral(@"
                            <button type=""submit"" class=""action-delete"" onclick=""return confirm('Bạn có chắc chắn muốn xóa sản phẩm này ?');"">
                                <i class=""fas fa-trash-alt""></i>
                                Xóa
                            </button>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
                                                    WriteLiteral(product.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2927, 45, true);
            WriteLiteral("\n                    </td>\n            </tr>\n");
            EndContext();
#line 79 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Index.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(2999, 20, true);
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
