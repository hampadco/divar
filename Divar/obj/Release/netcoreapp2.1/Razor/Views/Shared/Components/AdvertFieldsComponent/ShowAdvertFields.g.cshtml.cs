#pragma checksum "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\AdvertFieldsComponent\ShowAdvertFields.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d83788daa951d4b76d991d0861b1c174e45d74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdvertFieldsComponent_ShowAdvertFields), @"mvc.1.0.view", @"/Views/Shared/Components/AdvertFieldsComponent/ShowAdvertFields.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AdvertFieldsComponent/ShowAdvertFields.cshtml", typeof(AspNetCore.Views_Shared_Components_AdvertFieldsComponent_ShowAdvertFields))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d83788daa951d4b76d991d0861b1c174e45d74e", @"/Views/Shared/Components/AdvertFieldsComponent/ShowAdvertFields.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdvertFieldsComponent_ShowAdvertFields : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Divar.DataAccessLayer.Entities.AdvertField>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\AdvertFieldsComponent\ShowAdvertFields.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(93, 177, true);
            WriteLiteral("\r\n<div class=\"col-lg-8 col-lg-offset-2 col-md-8 col-md-offset-2 col-sm-12 col-sm-offset-0 col-xs-12 col-xs-offset-0\">\r\n\r\n    <table class=\"table table-hover\">\r\n        <tbody>\r\n");
            EndContext();
#line 11 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\AdvertFieldsComponent\ShowAdvertFields.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(327, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(374, 15, false);
#line 14 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\AdvertFieldsComponent\ShowAdvertFields.cshtml"
                   Write(item.Field.Name);

#line default
#line hidden
            EndContext();
            BeginContext(389, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(421, 15, false);
#line 15 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\AdvertFieldsComponent\ShowAdvertFields.cshtml"
                   Write(item.FieldValue);

#line default
#line hidden
            EndContext();
            BeginContext(436, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 17 "C:\Users\Rahim.Ghasemi\Desktop\Files\Divar\Views\Shared\Components\AdvertFieldsComponent\ShowAdvertFields.cshtml"
            }

#line default
#line hidden
            BeginContext(481, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Divar.DataAccessLayer.Entities.AdvertField>> Html { get; private set; }
    }
}
#pragma warning restore 1591
