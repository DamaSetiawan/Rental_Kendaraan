#pragma checksum "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba56b147f0815433db0133fad019e27863bad812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peminjamen_Index), @"mvc.1.0.view", @"/Views/Peminjamen/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Peminjamen/Index.cshtml", typeof(AspNetCore.Views_Peminjamen_Index))]
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
#line 1 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\_ViewImports.cshtml"
using RentalKendaraan;

#line default
#line hidden
#line 2 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\_ViewImports.cshtml"
using RentalKendaraan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba56b147f0815433db0133fad019e27863bad812", @"/Views/Peminjamen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d4cf402426243d0707a5ebfc9b45e52c09d1fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Peminjamen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentalKendaraan.Models.Peminjaman>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36be786ac9dc4bbeb89e8694cc65f9d3", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 49, false);
#line 16 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TglPeminjaman));

#line default
#line hidden
            EndContext();
            BeginContext(306, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 41, false);
#line 19 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(403, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(459, 56, false);
#line 22 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCustomerNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(515, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(571, 55, false);
#line 25 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdJaminanNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(626, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(682, 57, false);
#line 28 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdKendaraanNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(739, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(857, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(906, 48, false);
#line 37 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TglPeminjaman));

#line default
#line hidden
            EndContext();
            BeginContext(954, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1010, 40, false);
#line 40 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1106, 66, false);
#line 43 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCustomerNavigation.IdCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1228, 64, false);
#line 46 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdJaminanNavigation.IdJaminan));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1348, 68, false);
#line 49 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdKendaraanNavigation.IdKendaraan));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1471, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2199bd3fc1f4f1d8f2f122696e5cfd0", async() => {
                BeginContext(1526, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
                                       WriteLiteral(item.IdPeminjaman);

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
            BeginContext(1534, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1554, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fde663adeb648f8aa99c006eb37b122", async() => {
                BeginContext(1612, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
                                          WriteLiteral(item.IdPeminjaman);

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
            BeginContext(1623, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1643, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2963c75da5264c7faa96f58d6a394a57", async() => {
                BeginContext(1700, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
                                         WriteLiteral(item.IdPeminjaman);

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
            BeginContext(1710, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "F:\DATA KULIAH\SEMESTER 9\PENGEMBANGAN APLIKASI WEB SEMESTER 5\RentalKendaraan\RentalKendaraan\Views\Peminjamen\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1749, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentalKendaraan.Models.Peminjaman>> Html { get; private set; }
    }
}
#pragma warning restore 1591
