#pragma checksum "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37e0017ef5f62a0d09335d67bc00b0e4594a523b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Index.cshtml", typeof(AspNetCore.Views_Invoice_Index))]
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
#line 5 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37e0017ef5f62a0d09335d67bc00b0e4594a523b", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e27e96eba088818141acbdf1afd6992bd62d8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
  
    ViewBag.Title = "Invoices";


#line default
#line hidden
            BeginContext(116, 33, true);
            WriteLiteral("<!doctype html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(149, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37e0017ef5f62a0d09335d67bc00b0e4594a523b5654", async() => {
                BeginContext(155, 39, true);
                WriteLiteral("\n    <title>MbmStore Catalogue</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(201, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(203, 1515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37e0017ef5f62a0d09335d67bc00b0e4594a523b6874", async() => {
                BeginContext(209, 30, true);
                WriteLiteral("\n\n    <h2>Invoices</h2>\n\n\n    ");
                EndContext();
                BeginContext(239, 281, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37e0017ef5f62a0d09335d67bc00b0e4594a523b7288", async() => {
                    BeginContext(303, 27, true);
                    WriteLiteral("\n        <div>\n            ");
                    EndContext();
                    BeginContext(330, 106, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37e0017ef5f62a0d09335d67bc00b0e4594a523b7716", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 21 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Customers"] as List<SelectListItem>;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(436, 77, true);
                    WriteLiteral("\n            <button type=\"submit\">Show invoices</button>\n        </div>\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(520, 236, true);
                WriteLiteral("\n\n    <table>\n        <tr>\n            <th>Customer</th>\n            <th>\n                <div style=\"float:left;width:80%;\">Product</div>\n                <div style=\"float:right;width:50px;\">Price</div>\n            </th>\n        </tr>\n");
                EndContext();
#line 34 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
         foreach (Invoice invoice in ViewBag.Invoices)
        {

#line default
#line hidden
                BeginContext(821, 49, true);
                WriteLiteral("            <tr>\n                <td width=\"150\">");
                EndContext();
                BeginContext(871, 26, false);
#line 37 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                           Write(invoice.Customer.Firstname);

#line default
#line hidden
                EndContext();
                BeginContext(897, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(899, 25, false);
#line 37 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                                                       Write(invoice.Customer.Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(924, 55, true);
                WriteLiteral("</td>\n                <td>\n                    <table>\n");
                EndContext();
#line 40 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                          decimal price = 0M;

#line default
#line hidden
                BeginContext(1026, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 41 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                         foreach (OrderItem orderItem in invoice.OrderItems)
                        {

#line default
#line hidden
                BeginContext(1129, 81, true);
                WriteLiteral("                            <tr>\n                                <td width=\"500\">");
                EndContext();
                BeginContext(1211, 23, false);
#line 44 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                                           Write(orderItem.Product.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1234, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(1237, 42, false);
#line 44 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                                                                     Write(orderItem.Product.ToString().Substring(16));

#line default
#line hidden
                EndContext();
                BeginContext(1279, 77, true);
                WriteLiteral(") </td>\n                                <td style=\"width:50px\" class=\"price\">");
                EndContext();
                BeginContext(1357, 23, false);
#line 45 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                                                                Write(orderItem.Product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1380, 40, true);
                WriteLiteral("</td>\n                            </tr>\n");
                EndContext();
#line 47 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                            price += orderItem.Product.Price;
                        }

#line default
#line hidden
                BeginContext(1508, 85, true);
                WriteLiteral("                        <tr><td><strong>Total</strong></td><td class=\"price\"><strong>");
                EndContext();
                BeginContext(1594, 5, false);
#line 49 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
                                                                                Write(price);

#line default
#line hidden
                EndContext();
                BeginContext(1599, 89, true);
                WriteLiteral("</strong></td></tr>\n                    </table>\n                </td>\n            </tr>\n");
                EndContext();
#line 53 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Invoice\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1698, 13, true);
                WriteLiteral("    </table>\n");
                EndContext();
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
            EndContext();
            BeginContext(1718, 9, true);
            WriteLiteral("\n</html>\n");
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
