#pragma checksum "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd6ac7f38cfef6cd07fdd3ea850524fe95f9d7c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.razor-page", @"/Views/Contato/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6ac7f38cfef6cd07fdd3ea850524fe95f9d7c0", @"/Views/Contato/Index.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
#nullable restore
#line 2 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!DOCTYPE html>

<html>
<header>
    <meta name=""viewport"" content=""width=device-width""/>
    <title>Index</title>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"" integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
</header>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6ac7f38cfef6cd07fdd3ea850524fe95f9d7c03016", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <form method=\"post\" action=\"/contato/recebercontato\">\n            <div class=\"form-group\">\n                <label for=\"nome\">Nome</label>\n                <input type=\"text\" name=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 599, "\"", 628, 1);
#nullable restore
#line 20 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
WriteAttributeValue("", 607, ViewBag.Contato.Nome, 607, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o seu nome\">\n                ");
#nullable restore
#line 21 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
           Write(Html.ValidationMessage("nome"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                <label for=\"email\">E-mail</label>\n                <input type=\"text\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 895, "\"", 925, 1);
#nullable restore
#line 25 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
WriteAttributeValue("", 903, ViewBag.Contato.Email, 903, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"email\" placeholder=\"Digite o seu e-mail\">\n                ");
#nullable restore
#line 26 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
           Write(Html.ValidationMessage("email"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                <label for=\"assunto\">Assunto</label>\n                <input type=\"text\" name=\"assunto\"");
                BeginWriteAttribute("value", " value=\"", 1201, "\"", 1233, 1);
#nullable restore
#line 30 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
WriteAttributeValue("", 1209, ViewBag.Contato.Assunto, 1209, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"assunto\" placeholder=\"Digite o assunto\">\n                ");
#nullable restore
#line 31 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
           Write(Html.ValidationMessage("assunto"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                <label for=\"mensagem\">Mesagem</label>\n                <textarea type=\"text\" name=\"mensagem\" class=\"form-control\" id=\"mensagem\" placeholder=\"Digite a mensagem\">");
#nullable restore
#line 35 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
                                                                                                                    Write(ViewBag.Contato.Mensagem);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                ");
#nullable restore
#line 36 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
           Write(Html.ValidationMessage("mensagem"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\n        </form>\n        \n        ");
#nullable restore
#line 41 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Contato/Index.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Contato_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Contato_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Contato_Index>)PageContext?.ViewData;
        public Views_Contato_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
