#pragma checksum "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gigs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5390925fd824eb8eb68605055b200463716c727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gigs_Details), @"mvc.1.0.view", @"/Views/Gigs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5390925fd824eb8eb68605055b200463716c727", @"/Views/Gigs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0c35bb5ca94e4c4cc4184917ba6ee85aefd7ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Gigs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sixerr.Models.Gig>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gigs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>  \r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-body\">\r\n                    <h3> ");
#nullable restore
#line 14 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gigs\Details.cshtml"
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
#line 24 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gigs\Details.cshtml"
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
        <");
            WriteLiteral("/div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-body\">\r\n                    <button class=\"btn btn-success btn-block\" type=\"button\"> Заказать услугу ($");
#nullable restore
#line 51 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gigs\Details.cshtml"
                                                                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(")  </button>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-body\">\r\n                    <img src=\"GIG.USER.AVATAR\"");
            BeginWriteAttribute("alt", " alt=\"", 2134, "\"", 2140, 0);
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
    </div>
</div>
<!--IF USER == GIG.CREATOR-->
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5390925fd824eb8eb68605055b200463716c7277282", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\kraso\Desktop\Study\IGI 2\Sixerr\Sixerr\Views\Gigs\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5390925fd824eb8eb68605055b200463716c7279419", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
