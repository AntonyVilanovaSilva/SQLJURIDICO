#pragma checksum "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\Sala\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a69c96444c131e7aa5be48799e861402038543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sala_Index), @"mvc.1.0.view", @"/Views/Sala/Index.cshtml")]
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
#line 1 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\_ViewImports.cshtml"
using GestaoSala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\_ViewImports.cshtml"
using GestaoSala.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a69c96444c131e7aa5be48799e861402038543", @"/Views/Sala/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a049bb74e0ddd186b82ef3bc070c558509023d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sala_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  <h1>Lista de Salas</h1>\r\n</div>\r\n<div id=\"divSala\">\r\n    <table class=\"table table-striped\">\r\n\r\n        <thead>\r\n            <tr>\r\n\r\n                \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n    \r\n\r\n");
#nullable restore
#line 20 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\Sala\Index.cshtml"
             foreach (var item in @ViewBag.listaSalas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\Sala\Index.cshtml"
                   Write(item.SALID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\Sala\Index.cshtml"
                   Write(item.SALDESCRICAO);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    \r\n                   \r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\GestaoSala\GestaoSala\Views\Sala\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n\r\n</>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591