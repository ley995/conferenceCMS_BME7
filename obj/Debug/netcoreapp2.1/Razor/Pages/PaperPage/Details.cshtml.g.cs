#pragma checksum "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5f93eec73667924153a6e174f9c4aa4da1d4c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BME77.Pages.PaperPage.Pages_PaperPage_Details), @"mvc.1.0.razor-page", @"/Pages/PaperPage/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PaperPage/Details.cshtml", typeof(BME77.Pages.PaperPage.Pages_PaperPage_Details), null)]
namespace BME77.Pages.PaperPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\_ViewImports.cshtml"
using BME77;

#line default
#line hidden
#line 3 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\_ViewImports.cshtml"
using BME77.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f93eec73667924153a6e174f9c4aa4da1d4c24", @"/Pages/PaperPage/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c628f7725e5b6dc5050af5f6c5a1756e8fc2a2d7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PaperPage_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
  
    ViewData["Title"] = Model.Paper.Title;

#line default
#line hidden
            BeginContext(103, 101, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Paper</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 47, false);
#line 14 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Paper.Title));

#line default
#line hidden
            EndContext();
            BeginContext(252, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(296, 43, false);
#line 17 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
       Write(Html.DisplayFor(model => model.Paper.Title));

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(383, 48, false);
#line 20 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Paper.Author));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(475, 44, false);
#line 23 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
       Write(Html.DisplayFor(model => model.Paper.Author));

#line default
#line hidden
            EndContext();
            BeginContext(519, 80, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Time\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 30 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
              
                var item = Model.Paper;
                string timeTypex = "";
                if ((item.TimeStart < DateTime.Now) && (item.TimeEnd > DateTime.Now))
                {
                    timeTypex = "success";
                }
                else if (item.TimeStart > DateTime.Now)
                {
                    timeTypex = "primary";
                }
                else
                {
                    timeTypex = "secondary";
                }

            

#line default
#line hidden
            BeginContext(1127, 17, true);
            WriteLiteral("            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1144, "\"", 1174, 3);
            WriteAttributeValue("", 1152, "badge", 1152, 5, true);
            WriteAttributeValue(" ", 1157, "badge-", 1158, 7, true);
#line 47 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
WriteAttributeValue("", 1164, timeTypex, 1164, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1175, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1177, 41, false);
#line 47 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
                                            Write(item.TimeStart.ToString("dd MMMM, HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 8, true);
            WriteLiteral("&rsaquo;");
            EndContext();
            BeginContext(1227, 30, false);
#line 47 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
                                                                                              Write(item.TimeEnd.ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 102, true);
            WriteLiteral("</span>\r\n        </dd>\r\n\r\n        <dt>\r\n            Session\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1360, 50, false);
#line 54 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
       Write(Html.DisplayFor(model => model.Paper.Session.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
#line 56 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
         if (!String.IsNullOrEmpty(Model.Paper.Abstract))
        {

#line default
#line hidden
            BeginContext(1497, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(1532, 50, false);
#line 59 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Paper.Abstract));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1638, 46, false);
#line 62 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
           Write(Html.DisplayFor(model => model.Paper.Abstract));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 64 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"

        }

#line default
#line hidden
            BeginContext(1718, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 66 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
         if (!String.IsNullOrEmpty(Model.Paper.FullTextLink))
        {

#line default
#line hidden
            BeginContext(1792, 36, true);
            WriteLiteral("            <dd>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1828, "\"", 1860, 1);
#line 69 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
WriteAttributeValue("", 1835, Model.Paper.FullTextLink, 1835, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1861, 35, true);
            WriteLiteral(">Full Text</a>\r\n            </dd>\r\n");
            EndContext();
#line 71 "C:\Users\ley99\Downloads\BME7\BME7\BME77\Pages\PaperPage\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1907, 40, true);
            WriteLiteral("\r\n        \r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
            BeginContext(2019, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2023, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "088d8079ed884cf6822b05be19659628", async() => {
                BeginContext(2045, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2061, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BME77.Pages.PaperPage.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BME77.Pages.PaperPage.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BME77.Pages.PaperPage.DetailsModel>)PageContext?.ViewData;
        public BME77.Pages.PaperPage.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
