#pragma checksum "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13a26d0530c95f2ac33d05118843353141ed5db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_MyGigs), @"mvc.1.0.view", @"/Views/Profiles/MyGigs.cshtml")]
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
#line 1 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\_ViewImports.cshtml"
using Sixerr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\_ViewImports.cshtml"
using Sixerr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b13a26d0530c95f2ac33d05118843353141ed5db", @"/Views/Profiles/MyGigs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0c35bb5ca94e4c4cc4184917ba6ee85aefd7ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_MyGigs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sixerr.Models.Gig>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
  
    ViewData["Title"] = "Sixerr";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 style=""margin: 30px, 0px;""> Мои услуги </h3>
<div class=""panel panel-default"">
    <table class=""table table-bordered table-striped"">
        <thead class=""bg-success"">
            <tr>
                <th> № </th>
                <th> Название </th>
                <th> Цена </th>
                <th> Статус </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
             foreach (var gig in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th> ");
#nullable restore
#line 22 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
                Write(gig.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 23 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
                Write(Html.ActionLink(gig.Title, "Details", "Gigs", new { id = gig.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> $");
#nullable restore
#line 24 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
                 Write(gig.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 25 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
                 if (gig.Status)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>Активен</th>\r\n");
#nullable restore
#line 28 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
                }
                else 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <th>Не активен</th> \r\n");
#nullable restore
#line 32 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\kraso\Desktop\Study\(11 of 13) IGI 2\Sixerr\Sixerr\Views\Profiles\MyGigs.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sixerr.Models.Gig>> Html { get; private set; }
    }
}
#pragma warning restore 1591
