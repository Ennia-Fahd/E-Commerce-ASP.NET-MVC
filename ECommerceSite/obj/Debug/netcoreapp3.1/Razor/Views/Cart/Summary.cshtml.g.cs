#pragma checksum "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef1b19385f042df1a8459a4acb803046b0cd125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Summary), @"mvc.1.0.view", @"/Views/Cart/Summary.cshtml")]
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
#line 1 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\_ViewImports.cshtml"
using ECommerceSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\_ViewImports.cshtml"
using ECommerceSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef1b19385f042df1a8459a4acb803046b0cd125", @"/Views/Cart/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2991dc09725cc946c2c227ea7e06c909e10eacd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerceSite.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
   ViewData["Title"] = "Summary"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Panier</h1>\n\n\n");
#nullable restore
#line 8 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Ton Panier est vide !</h2> ");
#nullable restore
#line 10 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
                               }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 36 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 39 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 42 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 45 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                  \n            </td>\n           \n\n        </tr>\n");
#nullable restore
#line 53 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<h4>Total :  $");
#nullable restore
#line 56 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
         Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef1b19385f042df1a8459a4acb803046b0cd1258113", async() => {
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-primary\">Order</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"
AddHtmlAttributeValue("", 1292, Url.Action("ClearCart", "Cart"), 1292, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 62 "C:\Users\user\Desktop\DOTNET\ECommerceSite-master\ECommerceSite\Views\Cart\Summary.cshtml"



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerceSite.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591