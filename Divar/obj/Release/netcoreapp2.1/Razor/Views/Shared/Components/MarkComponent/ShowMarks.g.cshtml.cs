#pragma checksum "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6527ddf901118819bcd8e7e7046363c575d32d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MarkComponent_ShowMarks), @"mvc.1.0.view", @"/Views/Shared/Components/MarkComponent/ShowMarks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MarkComponent/ShowMarks.cshtml", typeof(AspNetCore.Views_Shared_Components_MarkComponent_ShowMarks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6527ddf901118819bcd8e7e7046363c575d32d01", @"/Views/Shared/Components/MarkComponent/ShowMarks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MarkComponent_ShowMarks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Divar.DataAccessLayer.Entities.Mark>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-light col-lg-6 text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(86, 60, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
            BeginContext(191, 327, true);
            WriteLiteral(@"            <div class=""col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1"">

                <div class=""alert alert-danger text-center"">
                    <h5 class=""text-center"">در حال حاضر هیچ آگهی را نشان نکرده اید</h5>
                </div>

            </div>
");
            EndContext();
#line 20 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
        }
        else
        {
            foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(610, 141, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-3 col-sm-2 col-xs-12\">\r\n\r\n                    <div class=\"thumbnail\">\r\n\r\n                        ");
            EndContext();
            BeginContext(753, 66, false);
#line 29 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
                    Write(await Component.InvokeAsync("FirstImageComponent", item.Advert.Id));

#line default
#line hidden
            EndContext();
            BeginContext(820, 105, true);
            WriteLiteral("\r\n\r\n                        <div class=\"caption\">\r\n\r\n                            <h3 class=\"text-center\">");
            EndContext();
            BeginContext(926, 16, false);
#line 33 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
                                               Write(item.Advert.Name);

#line default
#line hidden
            EndContext();
            BeginContext(942, 59, true);
            WriteLiteral("</h3>\r\n                            <h5 class=\"text-center\">");
            EndContext();
            BeginContext(1002, 16, false);
#line 34 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
                                               Write(item.Advert.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 73, true);
            WriteLiteral("</h5>\r\n                            <br />\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1180, 4);
            WriteAttributeValue("", 1098, "/Home/Adverts/", 1098, 14, true);
#line 36 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
WriteAttributeValue("", 1112, item.Advert.Id, 1112, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1127, "?title=", 1127, 7, true);
#line 36 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
WriteAttributeValue("", 1134, item.Advert.Name.Replace(" ", "-").ToString(), 1134, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1181, 84, true);
            WriteLiteral(" class=\"btn-red col-lg-6 text-center\">نمایش جزئیات</a>\r\n                            ");
            EndContext();
            BeginContext(1265, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c18b5485816644c8a33937c7eb780c6d", async() => {
                BeginContext(1379, 3, true);
                WriteLiteral("حذف");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1386, 90, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 43 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\MarkComponent\ShowMarks.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1502, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Divar.DataAccessLayer.Entities.Mark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
