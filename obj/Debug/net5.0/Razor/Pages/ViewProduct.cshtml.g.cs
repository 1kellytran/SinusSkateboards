#pragma checksum "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e0ed5432e321173153a6ef9fa0deda930c5958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SinusSkateboards.Pages.Pages_ViewProduct), @"mvc.1.0.razor-page", @"/Pages/ViewProduct.cshtml")]
namespace SinusSkateboards.Pages
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
#line 1 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\_ViewImports.cshtml"
using SinusSkateboards;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e0ed5432e321173153a6ef9fa0deda930c5958", @"/Pages/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bed562a6329955c4af4c92e5dabfff99c913fcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewProduct : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
     foreach (var item in Model.Product)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6e0ed5432e321173153a6ef9fa0deda930c59585016", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 261, "~/images/products/", 261, 18, true);
#nullable restore
#line 11 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
AddHtmlAttributeValue("", 279, item.Image, 279, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                                    Write(item.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                     if (item.Category > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text\">Size: <b>");
#nullable restore
#line 17 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                                                  Write(((Models.WearableModel)item).Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n");
#nullable restore
#line 18 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SEK </p>\r\n");
#nullable restore
#line 20 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                     if (item.Stock > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text\"><i>");
#nullable restore
#line 22 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                                           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> in Stock</p>\r\n");
#nullable restore
#line 23 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><i><b>Out of Stock</b></i></p>\r\n");
#nullable restore
#line 27 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                     if (item.MaxStock > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6e0ed5432e321173153a6ef9fa0deda930c595810662", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                                                     WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\kelly\OneDrive\Skrivbord\Newton\Objektorienterad Programmering 1\SinusSkateboards\SinusSkateboards\SinusSkateboards\Pages\ViewProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SinusSkateboards.Pages.ViewPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SinusSkateboards.Pages.ViewPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SinusSkateboards.Pages.ViewPageModel>)PageContext?.ViewData;
        public SinusSkateboards.Pages.ViewPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591