#pragma checksum "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da13e2b0e7121a3d6f26368b17886489495723de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamento_Index), @"mvc.1.0.view", @"/Views/Departamento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da13e2b0e7121a3d6f26368b17886489495723de", @"/Views/Departamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae1ddf8be7e0d2dec5678ca8cf2cb3874a4ca19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Departamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Lista de Departamento</h1>
</div>
<div id=""divDepartamento"">
    <table class=""table table-striped"">

        <thead>
            <tr>
                
                <th scope=""col"">Codigo</th>
                 <th scope=""col"">NomeDepartamento</th>
                  <th scope=""col"">NumeroFuncionario</th>
                  
                
            </tr>
        </thead>
        <tbody>
    

");
#nullable restore
#line 24 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
             foreach (var item in @ViewBag.listaDepartamento)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
                   Write(item.DEPID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
                   Write(item.DEPNOME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
                   Write(item.DEPNUMEROFUNCIONARIO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 842, "\"", 884, 2);
            WriteAttributeValue("", 849, "/departamento/atualizar/", 849, 24, true);
#nullable restore
#line 30 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
WriteAttributeValue("", 873, item.DEPID, 873, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                <td> <a class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 996, 2);
            WriteAttributeValue("", 964, "/departamento/Apagar/", 964, 21, true);
#nullable restore
#line 31 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
WriteAttributeValue("", 985, item.DEPID, 985, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a></td>      \r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\Departamento\Index.cshtml"
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
