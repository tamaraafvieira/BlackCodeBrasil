#pragma checksum "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9b703ca7748f25e99685f8c2eeec6866ab2933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratar_Index), @"mvc.1.0.view", @"/Views/Contratar/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9b703ca7748f25e99685f8c2eeec6866ab2933", @"/Views/Contratar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0c9d640be634173df9fcea737cdae6910dcdad", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light titulo-principal my-5 px-5 py-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml"
  
    ViewData["Title"] = "Contratar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
     <div id=""contratar"">
         <div class=""row d-flex justify-content-center contratar"">
              <div class=""col-sm-9 col-md-8 col-lg-7 text-center my-5"">
                  <h2 class=""titulo-principal cor-terciaria"">
                      <strong>// PORQUE CONTRATAR PESSOAS NEGRAS PARA SUA EMPRESA?</strong>
                  </h2>
              </div>
         </div>
         <div class=""container"">
");
#nullable restore
#line 15 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml"
               foreach (Contratar info in ViewBag.info)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  <div class=""card-contratar row cor-secundaria d-flex justify-content-center my-5"">
                      <div class=""col-12 col-sm-12 col-md-6 col-lg-4 d-flex justify-content-center"">
                          <img id=""img-hexagono"" class=""img-contratar align-self-center""");
            BeginWriteAttribute("src", " src=", 866, "", 883, 1);
#nullable restore
#line 19 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml"
WriteAttributeValue("", 871, info.Imagem, 871, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                      </div>\r\n                      <div class=\"card-body col-12 col-sm-12 col-md-6 col-lg-6\">\r\n                          <h5 class=\"texto-principal text-left mt-5 mx-4 mb-3\">");
#nullable restore
#line 22 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml"
                                                                          Write(info.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                          <p class=\"texto-terciario-contratar text-justify mx-4\">");
#nullable restore
#line 23 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml"
                                                                            Write(info.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      </div>\r\n                  </div>\r\n");
#nullable restore
#line 26 "C:\Users\izaqu\OneDrive\Área de Trabalho\BlackCode\ProjetoFinal\projetofinal\Views\Contratar\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </div>\r\n          <div class=\"row\">\r\n              <div class=\"col-12 d-flex justify-content-center footer-contratar py-4\">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d9b703ca7748f25e99685f8c2eeec6866ab29337527", async() => {
                WriteLiteral("Quero contratar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              </div>\r\n          </div>\r\n     </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
