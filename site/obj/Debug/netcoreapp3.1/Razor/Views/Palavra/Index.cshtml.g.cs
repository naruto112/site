#pragma checksum "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d750b2c58f0e344143b24fa520ee1d94dbe7a943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d750b2c58f0e344143b24fa520ee1d94dbe7a943", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<site.Models.Palavra>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d750b2c58f0e344143b24fa520ee1d94dbe7a9432682", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Palavra - Listagem</title>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"" integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d750b2c58f0e344143b24fa520ee1d94dbe7a9433953", async() => {
                WriteLiteral("\n\n    \n    <div class=\"container\">\n        <a href=\"/palavra/cadastrar\" class=\"btn btn-primary\">Cadastrar</a>\n        <span>Total de registros: <b>");
#nullable restore
#line 15 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
                                Write(Model.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></span>
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Palavra</th>
                    <th scope=""col"">Nível</th>
                    <th scope=""col"">Ação</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
                 foreach (var palavra in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line 29 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
                                   Write(palavra.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                        <td>");
#nullable restore
#line 30 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
                       Write(palavra.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
                       Write(palavra.Nivel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1200, "\"", 1237, 2);
                WriteAttributeValue("", 1207, "/palavra/atualizar/", 1207, 19, true);
#nullable restore
#line 33 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
WriteAttributeValue("", 1226, palavra.Id, 1226, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\">Editar</a>\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1292, "\"", 1327, 2);
                WriteAttributeValue("", 1299, "/palavra/excluir/", 1299, 17, true);
#nullable restore
#line 34 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
WriteAttributeValue("", 1316, palavra.Id, 1316, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn\">Excluir</a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 37 "/Volumes/Dev2/Estudo/dotnet.core/site/site/Views/Palavra/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<site.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
