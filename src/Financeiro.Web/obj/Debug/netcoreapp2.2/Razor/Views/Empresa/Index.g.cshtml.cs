#pragma checksum "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "530a16ce4358dd8dc0e8d80d789c0e60d086a7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresa/Index.cshtml", typeof(AspNetCore.Views_Empresa_Index))]
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
#line 1 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\_ViewImports.cshtml"
using Financeiro.Web;

#line default
#line hidden
#line 2 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\_ViewImports.cshtml"
using Financeiro.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530a16ce4358dd8dc0e8d80d789c0e60d086a7ab", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"656126f67854ebeef3be04f955f0f1c3bf7891a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Financeiro.Web.Models.EmpresaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Empresa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-fw"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
  
Layout = "_Dashboard";

#line default
#line hidden
            BeginContext(94, 1233, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
<!-- <link rel=""stylesheet"" type=""text/css"" href=""~/datatables/datatables.min.css""/> -->

<script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<!-- <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script> -->
<!-- <script type=""text/javascript"" src=""~/datatables/datatables.min.js""></script> -->

<div class=""content-wrapper"">
");
            WriteLiteral("  <div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n      <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Lista de Empresa</h4>\r\n        <p class=\"card-description\">\r\n          ");
            EndContext();
            BeginContext(1327, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "530a16ce4358dd8dc0e8d80d789c0e60d086a7ab5800", async() => {
                BeginContext(1420, 62, true);
                WriteLiteral("\r\n            <i class=\"mdi mdi-file-outline\"></i>Nova Empresa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1486, 560, true);
            WriteLiteral(@"
        </p>
        <div class=""table-responsive"">
          <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
            <thead>
              <tr>
                <th>ID</th>
                <th>Razão Social</th>  
                <th>Nome Fantasia</th>            
                <th>CNPJ</th>
                <th>Telefone</th>
                <th>Email</th>
                <th>Endereço</th>
                <th>Opções</th>
              </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 39 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
               foreach (var item in @Model)
              {

#line default
#line hidden
            BeginContext(2108, 64, true);
            WriteLiteral("                <tr class=\"even gradeC\">\r\n                  <td>");
            EndContext();
            BeginContext(2173, 7, false);
#line 42 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 46, true);
            WriteLiteral("</td>                 \r\n                  <td>");
            EndContext();
            BeginContext(2227, 16, false);
#line 43 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.RAZAOSOCIAL);

#line default
#line hidden
            EndContext();
            BeginContext(2243, 33, true);
            WriteLiteral("</td>    \r\n                  <td>");
            EndContext();
            BeginContext(2277, 17, false);
#line 44 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.NOMEFANTASIA);

#line default
#line hidden
            EndContext();
            BeginContext(2294, 42, true);
            WriteLiteral("</td>             \r\n                  <td>");
            EndContext();
            BeginContext(2337, 12, false);
#line 45 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.CPFCNPJ);

#line default
#line hidden
            EndContext();
            BeginContext(2349, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(2379, 13, false);
#line 46 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.TELEFONE);

#line default
#line hidden
            EndContext();
            BeginContext(2392, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(2422, 10, false);
#line 47 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.EMAIL);

#line default
#line hidden
            EndContext();
            BeginContext(2432, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(2462, 13, false);
#line 48 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
                 Write(item.ENDERECO);

#line default
#line hidden
            EndContext();
            BeginContext(2475, 31, true);
            WriteLiteral("</td>\r\n                  <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2506, "\"", 2543, 2);
            WriteAttributeValue("", 2513, "/Empresa/CreateOrEdit/", 2513, 22, true);
#line 49 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
WriteAttributeValue("", 2535, item.ID, 2535, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2544, 59, true);
            WriteLiteral(">Editar</a></td>\r\n                </tr>                  \r\n");
            EndContext();
#line 51 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Empresa\Index.cshtml"
              }          

#line default
#line hidden
            BeginContext(2630, 265, true);
            WriteLiteral(@"            </tbody>
          </table>
        </div>
      </div>
    </div>
  </div>
</div>

    <script>
    $(document).ready(function() {
        $('#dataTables-example').DataTable({
            responsive: true
        });
    });
    </script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Financeiro.Web.Models.EmpresaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
