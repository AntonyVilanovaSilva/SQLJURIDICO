#pragma checksum "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcf97c7d8b2848317413b67aa11970fcc9033879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Index), @"mvc.1.0.view", @"/Views/Funcionario/Index.cshtml")]
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
#line 1 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\_ViewImports.cshtml"
using SLNListaDB1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\_ViewImports.cshtml"
using SLNListaDB1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcf97c7d8b2848317413b67aa11970fcc9033879", @"/Views/Funcionario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae1ddf8be7e0d2dec5678ca8cf2cb3874a4ca19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Lista de Funcionario</h1>
</div>
<div id=""divFuncionario"">
    <table class=""table table-striped"">

        <thead>
            <tr>
                
                <th scope=""col"">Codigo</th>
                  <th scope=""col"">Nome</th>
                   <th scope=""col"">Data de Entrada</th>
                    <th scope=""col"">CodigoDepartamento</th>
                  
                  
                
            </tr>
        </thead>
        <tbody>
    

");
#nullable restore
#line 26 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
             foreach (var item in @ViewBag.listaFuncionario)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
                   Write(item.FUNID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
                   Write(item.FUNOME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
                   Write(item.FUNDATADEENTRADA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                     <td>");
#nullable restore
#line 32 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
                    Write(item.FUNCODIGODEPARTAMENTO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                     <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 1008, 2);
            WriteAttributeValue("", 974, "/funcionario/atualizar/", 974, 23, true);
#nullable restore
#line 33 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
WriteAttributeValue("", 997, item.FUNID, 997, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                    <td> <a class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1123, 2);
            WriteAttributeValue("", 1092, "/funcionario/Apagar/", 1092, 20, true);
#nullable restore
#line 34 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
WriteAttributeValue("", 1112, item.FUNID, 1112, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a></td>      \r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Funcionario\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n\r\n\r\n</>\r\n");
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
