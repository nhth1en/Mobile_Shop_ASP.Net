#pragma checksum "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec9c43280da23b517d6443a4ca7011cb09d68f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoryManagement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoryManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CategoryManagement/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_CategoryManagement_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec9c43280da23b517d6443a4ca7011cb09d68f3", @"/Areas/Admin/Views/CategoryManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60903519c4e7745bb5980f9332ec0c1241a7f90f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CategoryManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/CategoryManagement/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(130, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(131, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ec9c43280da23b517d6443a4ca7011cb09d68f35995", async() => {
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
            BeginContext(207, 66, true);
            WriteLiteral("\n<div class=\"wrapper-content\">\n    <h2>QUẢN LÝ LOẠI SẢN PHẨM</h2>\n");
            EndContext();
#line 10 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
     if (TempData["CantDelele"] != null)
    {

#line default
#line hidden
            BeginContext(320, 71, true);
            WriteLiteral("        <p style=\"color: red; text-align: center; margin-bottom: 5px;\">");
            EndContext();
            BeginContext(392, 22, false);
#line 12 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                                                                  Write(TempData["CantDelele"]);

#line default
#line hidden
            EndContext();
            BeginContext(414, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 13 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(425, 184, true);
            WriteLiteral("    <table>\n        <tr>\n            <th>#</th>\n            <th>Tên loại sản phẩm</th>\n            <th>Mô tả</th>\n            <th>SL</th>\n            <th>Hành động</th>\n        </tr>\n\n");
            EndContext();
#line 23 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
          int i = 1, z = 0;

#line default
#line hidden
#line 24 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
          
            int[] q = new int[Model.Count()];
            foreach (var item in ViewBag.query)
            {
                q[z] = item;
                z++;
            }

            z = 0;
            foreach (var category in Model)
            {

#line default
#line hidden
            BeginContext(899, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(945, 1, false);
#line 36 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(946, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(977, 22, false);
#line 37 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(category.Category_Name);

#line default
#line hidden
            EndContext();
            BeginContext(999, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1030, 29, false);
#line 38 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(category.Category_Description);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 31, true);
            WriteLiteral("</td>\n\n                    <td>");
            EndContext();
            BeginContext(1091, 4, false);
#line 40 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(q[z]);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 56, true);
            WriteLiteral("</td>\n\n                    <td>\n                        ");
            EndContext();
            BeginContext(1151, 311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec9c43280da23b517d6443a4ca7011cb09d68f310661", async() => {
                BeginContext(1225, 230, true);
                WriteLiteral("\n                            <button type=\"submit\" class=\"action-edit\">\n                                <i class=\"fas fa-edit\"></i>\n                                Sửa\n                            </button>\n                        ");
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
#line 43 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                                                  WriteLiteral(category.Category_Id);

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
            BeginContext(1462, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1487, 396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec9c43280da23b517d6443a4ca7011cb09d68f313745", async() => {
                BeginContext(1564, 312, true);
                WriteLiteral(@"
                            <button type=""submit"" class=""action-delete"" onclick=""return confirm('Bạn có chắc chắn muốn xóa loại sản phẩm này ?');"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                                                    WriteLiteral(category.Category_Id);

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
            BeginContext(1883, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 57 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                i++;
                z++;
            }
        

#line default
#line hidden
            BeginContext(1998, 25, true);
            WriteLiteral("\n    </table>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591