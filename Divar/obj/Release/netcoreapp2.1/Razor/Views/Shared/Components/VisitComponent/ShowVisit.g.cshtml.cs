#pragma checksum "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf95078525761696abf307bdf45426a293e52d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VisitComponent_ShowVisit), @"mvc.1.0.view", @"/Views/Shared/Components/VisitComponent/ShowVisit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/VisitComponent/ShowVisit.cshtml", typeof(AspNetCore.Views_Shared_Components_VisitComponent_ShowVisit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf95078525761696abf307bdf45426a293e52d5", @"/Views/Shared/Components/VisitComponent/ShowVisit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VisitComponent_ShowVisit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Divar.DataAccessLayer.Entities.Visit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(87, 62, true);
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
            BeginContext(194, 323, true);
            WriteLiteral(@"            <div class=""col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1"">

                <div class=""alert alert-danger text-center"">
                    <h5 class=""text-center"">هنوز بازدیدی از آگهی ها نداشته اید</h5>
                </div>

            </div>
");
            EndContext();
#line 21 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
        }
        else
        {
            foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(609, 137, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-3 col-sm-6 col-xs-12\">\r\n                    <div class=\"thumbnail\">\r\n                        ");
            EndContext();
            BeginContext(748, 66, false);
#line 28 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
                    Write(await Component.InvokeAsync("FirstImageComponent", item.Advert.Id));

#line default
#line hidden
            EndContext();
            BeginContext(815, 103, true);
            WriteLiteral("\r\n\r\n                        <div class=\"caption\">\r\n                            <h3 class=\"text-center\">");
            EndContext();
            BeginContext(919, 16, false);
#line 31 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
                                               Write(item.Advert.Name);

#line default
#line hidden
            EndContext();
            BeginContext(935, 59, true);
            WriteLiteral("</h3>\r\n                            <h5 class=\"text-center\">");
            EndContext();
            BeginContext(995, 16, false);
#line 32 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
                                               Write(item.Advert.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 37, true);
            WriteLiteral("</h5>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1108, 4);
            WriteAttributeValue("", 1055, "/Home/Adverts/", 1055, 14, true);
#line 33 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
WriteAttributeValue("", 1069, item.Advert.Id, 1069, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1084, "?title=", 1084, 7, true);
#line 33 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
WriteAttributeValue("", 1091, item.Advert.Name, 1091, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1109, 163, true);
            WriteLiteral(" class=\"btn-red btn-block text-center\">نمایش جزئیات</a>\r\n                        </div>\r\n                    </div>\r\n                    \r\n                </div>\r\n");
            EndContext();
#line 38 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1298, 22, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Divar.DataAccessLayer.Entities.Visit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
