#pragma checksum "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\NiveldeEnsino\Atualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee99d7d7fb3528c5810a0e0e1c99e211bbee0f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NiveldeEnsino_Atualizar), @"mvc.1.0.view", @"/Views/NiveldeEnsino/Atualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee99d7d7fb3528c5810a0e0e1c99e211bbee0f6", @"/Views/NiveldeEnsino/Atualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae1ddf8be7e0d2dec5678ca8cf2cb3874a4ca19", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_NiveldeEnsino_Atualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Atualizar NiveldeEnsino</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee99d7d7fb3528c5810a0e0e1c99e211bbee0f64038", async() => {
                WriteLiteral("\r\n  \r\n    <div class=\"form-group\">\r\n        <label for=\"codigo\">Código</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"codigo\"");
                BeginWriteAttribute("value", " value=\"", 343, "\"", 389, 1);
#nullable restore
#line 12 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\NiveldeEnsino\Atualizar.cshtml"
WriteAttributeValue("", 351, ViewBag.NiveldeEnsinoAtualizar.NIENID, 351, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"codigo\" readonly>\r\n\r\n         <div class=\"form-group\">\r\n        <label for=\"nome\">nome</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 550, "\"", 597, 1);
#nullable restore
#line 16 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\NiveldeEnsino\Atualizar.cshtml"
WriteAttributeValue("", 558, ViewBag.NiveldeEnsinoAtualizar.NIENOME, 558, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nome\">\r\n    </div>\r\n\r\n  \r\n     <div class=\"form-group\">\r\n        <label for=\"nome\">descricao</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"descricao\"");
                BeginWriteAttribute("value", " value=\"", 769, "\"", 822, 1);
#nullable restore
#line 22 "C:\Users\android.LABFIES\Documents\GitHub\SQLJURIDICO\SLNListaDB1\Views\NiveldeEnsino\Atualizar.cshtml"
WriteAttributeValue("", 777, ViewBag.NiveldeEnsinoAtualizar.NIENDESCRICAO, 777, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"descricao\">\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
