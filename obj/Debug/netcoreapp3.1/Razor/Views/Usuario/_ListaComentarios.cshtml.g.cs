#pragma checksum "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\_ListaComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efa04b2bd4588a532df542fc6a97a7b58b73ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario__ListaComentarios), @"mvc.1.0.view", @"/Views/Usuario/_ListaComentarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efa04b2bd4588a532df542fc6a97a7b58b73ab9", @"/Views/Usuario/_ListaComentarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70e61cb0fcf66800c6ab1068782274159a4171a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario__ListaComentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Comentario>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\_ListaComentarios.cshtml"
 foreach (Comentario comment in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>");
#nullable restore
#line 5 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\_ListaComentarios.cshtml"
   Write(comment.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\_ListaComentarios.cshtml"
                    Write(comment.DataComent.ToString("dd/MM/yy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\_ListaComentarios.cshtml"
  Write(comment.Conteudo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\gianL\OneDrive\Área de Trabalho\Killar_Guild\Views\Usuario\_ListaComentarios.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Comentario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591