#pragma checksum "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bfeb9c984660d3f000e7d40117f3c67318079d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Comunidade), @"mvc.1.0.view", @"/Views/Usuario/Comunidade.cshtml")]
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
#line 1 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\_ViewImports.cshtml"
using Killar_Guild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\_ViewImports.cshtml"
using Killar_Guild.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfeb9c984660d3f000e7d40117f3c67318079d6", @"/Views/Usuario/Comunidade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70e61cb0fcf66800c6ab1068782274159a4171a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario_Comunidade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FormComentarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-Justify col-xl-6 col-md-6 col-lg-6 col-sm-12 offset-md-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
  
    Layout = "_LayoutBlog";
    ViewData["Title"] = "Comunidade";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bfeb9c984660d3f000e7d40117f3c67318079d64250", async() => {
                WriteLiteral("\r\n    <div class=\"container mt-5\">\r\n");
#nullable restore
#line 10 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
         foreach (Post item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <article");
                BeginWriteAttribute("id", " id=\"", 286, "\"", 304, 2);
                WriteAttributeValue("", 291, "post-", 291, 5, true);
#nullable restore
#line 12 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
WriteAttributeValue("", 296, item.Id, 296, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"post artigo text-justify\">\r\n                <h2 class=\"post-title\">");
#nullable restore
#line 13 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
                                  Write(item.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <span class=\"post-date\">");
#nullable restore
#line 14 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
                                   Write(item.DataPost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                <div class=\"post-content mb-3\">\r\n                    <p>");
#nullable restore
#line 16 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
                  Write(item.Texto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n                <section");
                BeginWriteAttribute("id", " id=\"", 599, "\"", 621, 2);
                WriteAttributeValue("", 604, "comments-", 604, 9, true);
#nullable restore
#line 18 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
WriteAttributeValue("", 613, item.Id, 613, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"comments\">\r\n                    <h4 class=\"ml-3 comente\">Comente nesta publicação:</h4>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bfeb9c984660d3f000e7d40117f3c67318079d66857", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </section>\r\n            </article>\r\n            <hr class=\"mt-5 mb-5\">\r\n");
#nullable restore
#line 24 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\Comunidade.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591