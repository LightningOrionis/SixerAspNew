#pragma checksum "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gig\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b6549805cfab333550f880a949dded9c936c58e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gig_Detail), @"mvc.1.0.view", @"/Views/Gig/Detail.cshtml")]
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
#line 1 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\_ViewImports.cshtml"
using Sixerr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\_ViewImports.cshtml"
using Sixerr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6549805cfab333550f880a949dded9c936c58e", @"/Views/Gig/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0c35bb5ca94e4c4cc4184917ba6ee85aefd7ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Gig_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sixerr.Models.Gig>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gig\Detail.cshtml"
  
    ViewData["Title"] = "Sixerr";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                <h3> ");
#nullable restore
#line 11 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gig\Detail.cshtml"
                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
                <hr>
                <img src=""GIG:PHOTO"" class=""img-responsive center-block"">
            </div>
        </div>
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h4> Об услуге </h4>
            </div>
            <div class=""panel-body"">
                <p> ");
#nullable restore
#line 21 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gig\Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
            </div>
        </div>
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h4> Отзывы: </h4>
                <ul class=""list-group"">
                    {% for i in '123' %}
                    <li class=""list-group-item"">
                        <div class=""row"">
                            <div class=""col-md-2"">
                                <img src=""{% static 'img/avatar.png'%}"" class=""img-circle center-block"" height=""60"" width=""60"">
                            </div>
                            <div class=""col-md-10"">
                                <h5> Какой-то покупатель </h5>
                                <p> Какой-то отзыв об услуге</p>
                            </div>
                        </div>
                    </li>
                    {% endfor %}
                </ul>
            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""panel panel-default"">
            <d");
            WriteLiteral("iv class=\"panel-body\">\r\n                <button class=\"btn btn-success btn-block\" type=\"button\"> Заказать услугу ($");
#nullable restore
#line 48 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gig\Detail.cshtml"
                                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(")  </button>\r\n            </div>\r\n        </div>\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                <img src=\"GIG.USER.AVATAR\"");
            BeginWriteAttribute("alt", " alt=\"", 1916, "\"", 1922, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle center-block"">
                <h4 class=""text-center"">
                    MODEL:USER:USER:USERNAME
                </h4>
                <hr>
                <p> MODEL:USER:ABOUT </p>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sixerr.Models.Gig> Html { get; private set; }
    }
}
#pragma warning restore 1591
