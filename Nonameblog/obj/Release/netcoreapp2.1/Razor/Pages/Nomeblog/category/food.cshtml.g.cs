#pragma checksum "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbeb5de494f4a5c40fab36a3f55d320b85cb956a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nonameblog.Pages.Nomeblog.category.Pages_Nomeblog_category_food), @"mvc.1.0.razor-page", @"/Pages/Nomeblog/category/food.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Nomeblog/category/food.cshtml", typeof(Nonameblog.Pages.Nomeblog.category.Pages_Nomeblog_category_food), null)]
namespace Nonameblog.Pages.Nomeblog.category
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbeb5de494f4a5c40fab36a3f55d320b85cb956a", @"/Pages/Nomeblog/category/food.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3decab95cc441a5272c1d09ac53fbf250c1a51", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Nomeblog_category_food : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
  
    ViewData["Title"] = "美食";

#line default
#line hidden
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
  
    var orderedList = Model.Artcile.OrderByDescending(x => x.ReleaseDate).ToList();
    foreach (var item in orderedList)
    {
        if (item.Type == Models.Artcile_type.美食)
        {

#line default
#line hidden
            BeginContext(296, 119, true);
            WriteLiteral("            <div style=\"width:400px;font-family:DFKai-SB; white-space:nowrap;overflow:hidden;text-overflow:ellipsis;\">【");
            EndContext();
            BeginContext(416, 9, false);
#line 13 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
                                                                                                                  Write(item.Type);

#line default
#line hidden
            EndContext();
            BeginContext(425, 3, true);
            WriteLiteral("】  ");
            EndContext();
            BeginContext(429, 11, false);
#line 13 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
                                                                                                                               Write(item.Tittle);

#line default
#line hidden
            EndContext();
            BeginContext(440, 182, true);
            WriteLiteral("</div><p></p>\r\n            <div style=\"width:600px;height:150px ;white-space:nowrap;overflow-y:scroll;overflow-x:hidden;text-overflow:ellipsis; font-size:20px; font-family:DFKai-SB\">");
            EndContext();
            BeginContext(623, 22, false);
#line 14 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
                                                                                                                                                                  Write(Html.Raw(item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(645, 26, true);
            WriteLiteral("</div>\r\n            <br />");
            EndContext();
            BeginContext(671, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d2f7a939a9441d7ab20048460ba4dda", async() => {
                BeginContext(743, 7, true);
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
#line 15 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
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
            BeginContext(754, 42, true);
            WriteLiteral("\r\n            <hr width=\"100%\" size=\"3\">\r\n");
            EndContext();
#line 17 "D:\Joyplux\SVN\branches\Nonameblog\Nonameblog\Pages\Nomeblog\category\food.cshtml"
        }
    }


#line default
#line hidden
            BeginContext(819, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nonameblog.Pages.Nomeblog.category.foodModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nonameblog.Pages.Nomeblog.category.foodModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nonameblog.Pages.Nomeblog.category.foodModel>)PageContext?.ViewData;
        public Nonameblog.Pages.Nomeblog.category.foodModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
