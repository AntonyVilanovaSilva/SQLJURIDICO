#pragma checksum "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac95291d29863e517ca687616eca733a600f00a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Index), @"mvc.1.0.view", @"/Views/Aluno/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac95291d29863e517ca687616eca733a600f00a6", @"/Views/Aluno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae1ddf8be7e0d2dec5678ca8cf2cb3874a4ca19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Aluno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Lista de Aluno</h1>
</div>

<div id=""divAluno"">
    <table class=""table table-striped"">

        <thead>
            <tr>
                
                <th scope=""col"">Codigo</th>
                 <th scope=""col"">Nome</th>
                  <th scope=""col"">Sobrenome</th>
                  
                
            </tr>
        </thead>
        <tbody>
    

");
#nullable restore
#line 25 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
             foreach (var item in @ViewBag.listaAluno)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
                   Write(item.ALUID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
                   Write(item.ALUNOME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
                   Write(item.ALUSOBRENOME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 833, 2);
            WriteAttributeValue("", 805, "/aluno/atualizar/", 805, 17, true);
#nullable restore
#line 31 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 822, item.ALUID, 822, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                   <td> <a class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("href", " href=\"", 909, "\"", 941, 2);
            WriteAttributeValue("", 916, "/aluno/Apagar/", 916, 14, true);
#nullable restore
#line 32 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 930, item.ALUID, 930, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a></td> \r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Aluno\Index.cshtml"
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
