#pragma checksum "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74775a76a5656e227aff0341f6b8de1214e11c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nonameblog.Pages.Nomeblog.Pages_Nomeblog_Search), @"mvc.1.0.razor-page", @"/Pages/Nomeblog/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Nomeblog/Search.cshtml", typeof(Nonameblog.Pages.Nomeblog.Pages_Nomeblog_Search), null)]
namespace Nonameblog.Pages.Nomeblog
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\_ViewImports.cshtml"
using Nonameblog;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74775a76a5656e227aff0341f6b8de1214e11c8a", @"/Pages/Nomeblog/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3decab95cc441a5272c1d09ac53fbf250c1a51", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Nomeblog_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Nomeblog/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
  
    ViewData["Title"] = "搜尋結果";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
  
    if (Model.Artcile.Count > 0)
    {
        var orderedList = Model.Artcile.OrderByDescending(x => x.ReleaseDate).ToList();
        foreach (var item in orderedList)
        {

#line default
#line hidden
            BeginContext(330, 119, true);
            WriteLiteral("            <div style=\"width:400px;font-family:DFKai-SB; white-space:nowrap;overflow:hidden;text-overflow:ellipsis;\">【");
            EndContext();
            BeginContext(450, 9, false);
#line 14 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
                                                                                                                  Write(item.Type);

#line default
#line hidden
            EndContext();
            BeginContext(459, 3, true);
            WriteLiteral("】  ");
            EndContext();
            BeginContext(463, 11, false);
#line 14 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
                                                                                                                               Write(item.Tittle);

#line default
#line hidden
            EndContext();
            BeginContext(474, 187, true);
            WriteLiteral("</div><p></p>\r\n            <div style=\"width:600px;height:150px ;white-space:nowrap;overflow-y:scroll;overflow-x:hidden;text-overflow:ellipsis; font-size:20px; font-family:DFKai-SB\"><pre>");
            EndContext();
            BeginContext(662, 22, false);
#line 15 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
                                                                                                                                                                       Write(Html.Raw(item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(684, 32, true);
            WriteLiteral("</pre></div>\r\n            <br />");
            EndContext();
            BeginContext(716, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73074cff3cc04cfa8108480a89851c92", async() => {
                BeginContext(787, 7, true);
                WriteLiteral("閱讀更多...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(798, 42, true);
            WriteLiteral("\r\n            <hr width=\"100%\" size=\"3\">\r\n");
            EndContext();
#line 18 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(875, 18, true);
            WriteLiteral("        <h1>找不到關於【");
            EndContext();
            BeginContext(894, 18, false);
#line 22 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
             Write(Model.SearchString);

#line default
#line hidden
            EndContext();
            BeginContext(912, 35, true);
            WriteLiteral("】的資訊...</h1><p></p><br />\r\n        ");
            EndContext();
            BeginContext(947, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "050cda3778ae4fd29be68a18cedc5f9e", async() => {
                BeginContext(977, 12, true);
                WriteLiteral("去論壇列表探索其他文章吧");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(993, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\Search.cshtml"
    }


#line default
#line hidden
            BeginContext(1007, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nonameblog.Pages.Nomeblog.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nonameblog.Pages.Nomeblog.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nonameblog.Pages.Nomeblog.SearchModel>)PageContext?.ViewData;
        public Nonameblog.Pages.Nomeblog.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
