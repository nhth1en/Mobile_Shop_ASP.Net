#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d24cd4d3dc3fe18a8591283e4e0ca6623548d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_OrderManagement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/OrderManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/OrderManagement/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_OrderManagement_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d24cd4d3dc3fe18a8591283e4e0ca6623548d61", @"/Areas/Admin/Views/OrderManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8282febc87a857b1dd3c8924bd5c37fdb8cfb2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_OrderManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/OrderManagement/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(132, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fc31e88fd93e48b39727cb44bf4033c9", async() => {
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
            BeginContext(205, 64, true);
            WriteLiteral("\r\n<div class=\"wrapper-content\">\r\n    <h2>QUẢN LÝ ĐƠN HÀNG</h2>\r\n");
            EndContext();
#line 9 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
     if (TempData["CompleteSuccess"] != null)
    {

#line default
#line hidden
            BeginContext(323, 73, true);
            WriteLiteral("        <p style=\"color: green; text-align: center; margin-bottom: 5px;\">");
            EndContext();
            BeginContext(397, 27, false);
#line 11 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                                                                    Write(TempData["CompleteSuccess"]);

#line default
#line hidden
            EndContext();
            BeginContext(424, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(437, 230, true);
            WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Mã đơn hàng</th>\r\n            <th>Ngày đặt</th>\r\n            <th>Tổng tiền</th>\r\n            <th>Trạng thái</th>\r\n            <th>Hành động</th>\r\n        </tr>\r\n");
            EndContext();
#line 23 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
          int i = 1;

#line default
#line hidden
            BeginContext(690, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 24 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(739, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(778, 1, false);
#line 27 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(779, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(807, 13, false);
#line 28 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
               Write(item.Order_Id);

#line default
#line hidden
            EndContext();
            BeginContext(820, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(848, 17, false);
#line 29 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
               Write(item.Order_Placed);

#line default
#line hidden
            EndContext();
            BeginContext(865, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(893, 16, false);
#line 30 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
               Write(item.Order_Total);

#line default
#line hidden
            EndContext();
            BeginContext(909, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                 if (item.IsCompleted == true)
                {

#line default
#line hidden
            BeginContext(983, 41, true);
            WriteLiteral("                    <td>Hoàn thành</td>\r\n");
            EndContext();
#line 34 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1084, 46, true);
            WriteLiteral("                    <td>Chưa hoàn thành</td>\r\n");
            EndContext();
#line 38 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1149, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1191, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f151323be74b88a27332cd92ea562b", async() => {
                BeginContext(1260, 229, true);
                WriteLiteral("\r\n                        <button class=\"action-detail\" type=\"submit\">\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                            Chi tiết\r\n                        </button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                                                WriteLiteral(item.Order_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1496, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                     if (item.IsCompleted == false)
                    {

#line default
#line hidden
            BeginContext(1574, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1598, 404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f456cddb44548059af594307c3130e1", async() => {
                BeginContext(1670, 325, true);
                WriteLiteral(@"
                            <button class=""action-complete"" type=""submit"" onclick=""return confirm('Bạn có chắc muốn hoàn thành đơn hàng này?');"">
                                <i class=""fas fa-check-double""></i>
                                Hoàn thành
                            </button>
                        ");
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
#line 48 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                                                      WriteLiteral(item.Order_Id);

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
            BeginContext(2002, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2027, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\OrderManagement\Index.cshtml"
            i++;
        }

#line default
#line hidden
            BeginContext(2098, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591