#pragma checksum "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a17dc35cf0d80e0372c071f366afc929714038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Talentos_Details), @"mvc.1.0.view", @"/Views/Talentos/Details.cshtml")]
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
#line 1 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\_ViewImports.cshtml"
using ProjetoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\_ViewImports.cshtml"
using ProjetoFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a17dc35cf0d80e0372c071f366afc929714038", @"/Views/Talentos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0c9d640be634173df9fcea737cdae6910dcdad", @"/Views/_ViewImports.cshtml")]
    public class Views_Talentos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoFinal.Models.Talento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagem de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"talento-info\">\r\n    <div class=\"row info-header\">\r\n        <div class=\"col-12 col-sm-12 col-md-4 col-lg-5\">\r\n            <div class=\"container dados img my-4 ml-md-4 d-flex justify-content-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a17dc35cf0d80e0372c071f366afc9297140384066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 317, "~/img/userImage/", 317, 16, true);
#nullable restore
#line 11 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
AddHtmlAttributeValue("", 333, Model.ImagemNome, 333, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""col-12 col-sm-12 col-md-8 col-lg-6"">
            <div class=""container my-4 d-flex flex-column justify-content-center align-items-center
            d-lg-flex flex-lg-column justify-content-lg-center align-items-lg-start
            d-md-flex flex-md-column justify-content-md-center align-items-md-start ml-md-5"">
                <h2 class=""titulo-info cor-secundaria mt-lg-5 mt-md-5"">");
#nullable restore
#line 18 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                  Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <div class=\" cor-secundaria  \">\r\n                    <span class=\"destaque-info\">Profissão:</span><span class=\"texto-info \"> ");
#nullable restore
#line 20 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Profissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                    <span class=\"destaque-info\">Local:</span><span class=\"texto-info\">&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 21 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.Localidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                    <span class=\"destaque-info\">Telefone:</span><span class=\"texto-info\">&nbsp ");
#nullable restore
#line 22 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                    <span class=\"destaque-info\">E-mail:</span><span class=\"texto-info\">&nbsp&nbsp&nbsp ");
#nullable restore
#line 23 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                    <span class=\"destaque-info\">Formação:</span><span class=\"texto-info\">&nbsp ");
#nullable restore
#line 24 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.Formacao));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>
        </div>
    </div>

    <div class=""row cor-principal contratar"">
        <div class=""container my-5"">
            <div class=""col-12"">
                <h1 class=""titulo-principal"">SOBRE</h1>
            </div>
            <div class=""col-12"">
                <p class=""text-terciario text-justify"">
                    ");
#nullable restore
#line 37 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
               Write(Html.DisplayFor(model => model.Sobre));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </div>

    <div class=""row experiencia"">
        <div class=""container mt-5"">
            <div class=""col-12"">
                <h1 class=""titulo-principal"">EXPERIÊNCIAS</h1><br>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col-12 pb-5 "" style=""margin-left: 3%;"">
                    <span class=""texto-secundario"">LOCAL:</span><span class=""text-terciario "">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 50 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                                             Write(Html.DisplayFor(model => model.Local1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br><br>\r\n                    <span class=\"texto-secundario\">FUNÇÃO:</span><span class=\"text-terciario \">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 51 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                                         Write(Html.DisplayFor(model => model.Funcao1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br><br>\r\n                    <span class=\"texto-secundario\">ATIVIDADES:</span><span class=\"text-terciario \">&nbsp&nbsp&nbsp ");
#nullable restore
#line 52 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                              Write(Html.DisplayFor(model => model.Atividade1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span><br>
                    <p style=""color: #FFD79C;"" class=""borda pb-5"">.</p>
                </div>

                <div class=""col-12 text-terciario pb-5 "" style=""margin-left: 3%;"">
                    <span class=""texto-secundario"">LOCAL:</span><span class=""text-terciario "">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 57 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                                             Write(Html.DisplayFor(model => model.Local2));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span><br><br>\r\n                    <span class=\"texto-secundario\">FUNÇÃO:</span><span class=\"text-terciario \">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 58 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                                         Write(Html.DisplayFor(model => model.Funcao2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br><br>\r\n                    <span class=\"texto-secundario\">ATIVIDADES:</span><span class=\"text-terciario \">&nbsp&nbsp&nbsp ");
#nullable restore
#line 59 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                              Write(Html.DisplayFor(model => model.Atividade2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span><br>
                    <p style=""color: #FFD79C;"" class=""borda pb-5"">.</p>
                </div>
            </div>
        </div>
    </div>

    <div class=""row curso"">
        <div class=""container mt-5"">
            <div class=""col-12"">
                <h1 class=""titulo-principal"">CURSOS</h1><br>
            </div>
            <div class=""row justify-content-center"">
                <div class=""col-12 pb-5 "" style=""margin-left: 3%;"">
                    <span class=""texto-secundario"">INSTITUIÇÃO:</span><span class=""text-terciario "">&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 73 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                                    Write(Html.DisplayFor(model => model.Instituicao1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br><br>\r\n                    <span class=\"texto-secundario\">CARGA HORÁRIA:</span><span class=\"text-terciario \">&nbsp&nbsp  ");
#nullable restore
#line 74 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                             Write(Html.DisplayFor(model => model.CargaHoraria1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" h</span><br><br>\r\n                    <span class=\"texto-secundario\">O QUE APRENDEU:</span><span class=\"text-terciario text-justify\">\r\n                        &nbsp ");
#nullable restore
#line 76 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Aprendeu1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </span><br>
                    <p style=""color: rgba(174, 241, 255, 1);"" class=""borda pb-5"">.</p>
                </div>

                <div class=""col-12 text-terciario pb-5 "" style=""margin-left: 3%;"">
                    <span class=""texto-secundario"">INSTITUIÇÃO:</span><span class=""text-terciario "">&nbsp&nbsp&nbsp&nbsp ");
#nullable restore
#line 82 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                                    Write(Html.DisplayFor(model => model.Instituicao2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br><br>\r\n                    <span class=\"texto-secundario\">CARGA HORÁRIA:</span><span class=\"text-terciario \">&nbsp&nbsp ");
#nullable restore
#line 83 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                                                                                                            Write(Html.DisplayFor(model => model.CargaHoraria2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" h</span><br><br>\r\n                    <span class=\"texto-secundario\">O QUE APRENDEU:</span><span class=\"text-terciario text-justify\">\r\n                        &nbsp ");
#nullable restore
#line 85 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Aprendeu2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </P>
                    </span><br>
                    <p style=""color: rgba(174, 241, 255, 1);"" class=""borda pb-5"">.</p>

                </div>
            </div>
        </div>
    </div>


    <div class=""row cor-principal contratar"">
        <div class=""container my-5"">
            <div class=""col-12"">
                <h1 class=""titulo-principal"">HABILIDADES</h1>
            </div>
            <div class=""col-12"">
                <ul class=""text-terciario ml-4 "">
");
#nullable restore
#line 102 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                      string[] listaHabilidade = Model.Habilidades.Split(";");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 104 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                     foreach (var habilidade in listaHabilidade)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 106 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                       Write(habilidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 107 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Talentos\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!--<li>Comunicação</li>
    <li>Proatividade</li>
    <li> Organização</li>
    <li> Computação</li>
    <li>Foco em resultados</li>
    <li>Liderança</li>
    <li>Entusiasmo</li>
    <li>Flexibilidade e capacidade de se adaptar a mudanças</li>
    <li>Criatividade</li>
    <li>Capacidade de trabalhar remotamente</li>
    <li>Capacidade de inovação</li>-->
                </ul>
            </div>
        </div>
    </div>

    <style type=""text/css"">
        body {
            overflow-x: hidden;
        }
    </style>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoFinal.Models.Talento> Html { get; private set; }
    }
}
#pragma warning restore 1591
