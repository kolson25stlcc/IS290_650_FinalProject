#pragma checksum "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d9ac1cebc6112c2dd62cf158139380be7f4954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_ShowData), @"mvc.1.0.view", @"/Views/Demo/ShowData.cshtml")]
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
#line 1 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\_ViewImports.cshtml"
using SampleDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d9ac1cebc6112c2dd62cf158139380be7f4954", @"/Views/Demo/ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449c2e4aa0e03b686f30b0bfbb6eb51889159cad", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_ShowData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SampleDemo.Models.Name>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d9ac1cebc6112c2dd62cf158139380be7f49544020", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ShowData</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d9ac1cebc6112c2dd62cf158139380be7f49545082", async() => {
                WriteLiteral("\r\n<p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13d9ac1cebc6112c2dd62cf158139380be7f49545351", async() => {
                    WriteLiteral("Create New");
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
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ID }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.ActionLink("Detail", "Detail", new { id = item.ID }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                ");
#nullable restore
#line 48 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }, new { onclick = "return confirm('Are sure wants to delete?');" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Crocus_Sativas\Desktop\Kathlyn\School\IS290_650\SampleSQLServerDemo2\SampleSQLServerDemo\IS290_650_FinalProject\SampleSQLServerDemo\Views\Demo\ShowData.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SampleDemo.Models.Name>> Html { get; private set; }
    }
}
#pragma warning restore 1591