#pragma checksum "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\Analytics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528e2a7449587c92d9ec056b94080047c73072f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Analytics_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Analytics/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Analytics/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Analytics_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528e2a7449587c92d9ec056b94080047c73072f8", @"/Areas/Admin/Views/Analytics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60903519c4e7745bb5980f9332ec0c1241a7f90f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Analytics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/Analytics/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\Analytics\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(102, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "528e2a7449587c92d9ec056b94080047c73072f84427", async() => {
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
            BeginContext(169, 155, true);
            WriteLiteral("\n<div class=\"wrapper-content\">\n    <h2>THỐNG KÊ</h2>\n    <div class=\"box\">\n        <div class=\"left\">\n            <h3>TỔNG SỐ SẢN PHẨM</h3>\n            <p>");
            EndContext();
            BeginContext(325, 19, false);
#line 12 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\Analytics\Index.cshtml"
          Write(Model.TotalProducts);

#line default
#line hidden
            EndContext();
            BeginContext(344, 108, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"right\">\n            <h3>TỔNG SỐ SẢN PHẨM ĐÃ BÁN</h3>\n            <p>");
            EndContext();
            BeginContext(453, 23, false);
#line 16 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\Analytics\Index.cshtml"
          Write(Model.TotalProductsSold);

#line default
#line hidden
            EndContext();
            BeginContext(476, 138, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n    <div class=\"box\">\n        <div class=\"left\">\n            <h3>TỔNG SÔ LOẠI SẢN PHẨM</h3>\n            <p>");
            EndContext();
            BeginContext(615, 21, false);
#line 22 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\Analytics\Index.cshtml"
          Write(Model.TotalCategories);

#line default
#line hidden
            EndContext();
            BeginContext(636, 117, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"right\">\n            <h3>TỔNG SỐ ĐƠN HÀNG CHƯA HOÀN THÀNH</h3>\n            <p>");
            EndContext();
            BeginContext(754, 26, false);
#line 26 "D:\Tool\MobileShop\MobileShop\Areas\Admin\Views\Analytics\Index.cshtml"
          Write(Model.TotalOrderIncomplete);

#line default
#line hidden
            EndContext();
            BeginContext(780, 44, true);
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n\n\n\n\n\n\n");
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