#pragma checksum "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3a860ed2381e3a8577bae9eb0bcd9cde7252e9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_ListarPosts), @"mvc.1.0.view", @"/Views/Post/ListarPosts.cshtml")]
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
#line 1 "E:\ProjetoMobile\Killar_guild\Views\_ViewImports.cshtml"
using Killar_Guild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ProjetoMobile\Killar_guild\Views\_ViewImports.cshtml"
using Killar_Guild.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3a860ed2381e3a8577bae9eb0bcd9cde7252e9f", @"/Views/Post/ListarPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70e61cb0fcf66800c6ab1068782274159a4171a", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_ListarPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
  
    ViewData["Title"] = "Cadastro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3a860ed2381e3a8577bae9eb0bcd9cde7252e9f3608", async() => {
                WriteLiteral("\r\n\r\n    <main role=\"main\">\r\n\r\n        <div class=\"container-fluid\">\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-md-12 col-sm-4 lista-user\">\r\n\r\n                    <h2 class=\"text-center\">Listagem de Posts</h2>\r\n\r\n");
#nullable restore
#line 19 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table id=""tblPosts"" class=""table col-md-6 offset-md-3 table-striped table-responsive table-dark text-justify"">
                            <thead>
                                <tr>
                                    <th>Título</th>
                                    <th>Data</th>
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 30 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
                                 foreach (Post item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 33 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
                                       Write(item.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
                                       Write(item.DataPost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td><a class=\"mt-2 btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 1241, "\"", 1270, 2);
                WriteAttributeValue("", 1248, "UpdatePost?id=", 1248, 14, true);
#nullable restore
#line 35 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
WriteAttributeValue("", 1262, item.Id, 1262, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Editar</a>\r\n                                        <a class=\"mt-2 btn btn-sm btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 1370, "\"", 1396, 2);
                WriteAttributeValue("", 1377, "DelPost?id=", 1377, 11, true);
#nullable restore
#line 36 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
WriteAttributeValue("", 1388, item.Id, 1388, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Excluir</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 38 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
                                    
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 42 "E:\ProjetoMobile\Killar_guild\Views\Post\ListarPosts.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
