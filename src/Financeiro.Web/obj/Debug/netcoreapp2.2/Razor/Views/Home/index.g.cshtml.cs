#pragma checksum "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a4d2f7866c4ba5fe151f764e63034196e376b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a4d2f7866c4ba5fe151f764e63034196e376b9", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"656126f67854ebeef3be04f955f0f1c3bf7891a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link js-scroll-trigger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Repositorio_Projetos\Financeiro\src\financeiro.web\Views\Home\index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(33, 1173, true);
            WriteLiteral(@"    <nav class=""navbar navbar-expand-lg navbar-light fixed-top"" id=""mainNav"">
      <div class=""container"">
        <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Gestão Financeira</a>
        <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
          <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
          <ul class=""navbar-nav ml-auto"">
            <li class=""nav-item"">
              <a class=""nav-link js-scroll-trigger"" href=""#about"">Sobre</a>
            </li>
            <li class=""nav-item"">
              <a class=""nav-link js-scroll-trigger"" href=""#services"">Serviços</a>
            </li>
            <li class=""nav-item"">
              <a class=""nav-link js-scroll-trigger"" href=""#portfolio"">Portifolio</a>
            </li>
            <li class=""nav-item");
            WriteLiteral("\">\n              <a class=\"nav-link js-scroll-trigger\" href=\"#contact\">Contato</a>\n            </li>\n            <li class=\"nav-item\">\n              ");
            EndContext();
            BeginContext(1206, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a4d2f7866c4ba5fe151f764e63034196e376b95561", async() => {
                BeginContext(1288, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 8402, true);
            WriteLiteral(@"
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <header class=""masthead text-center text-white d-flex"">
      <div class=""container my-auto"">
        <div class=""row"">
          <div class=""col-lg-10 mx-auto"">
            <h1 class=""text-uppercase"">
              <strong>Seu Sistema de Gestão de Contas e Controle Financeiro</strong>
            </h1>
            <hr>
          </div>
          <div class=""col-lg-8 mx-auto"">
            <p class=""text-faded mb-5"">Start Bootstrap can help you build better websites using the Bootstrap CSS framework! Just download your template and start going, no strings attached!</p>
            <a class=""btn btn-primary btn-xl js-scroll-trigger"" href=""#about"">Find Out More</a>
          </div>
        </div>
      </div>
    </header>

    <section class=""bg-primary"" id=""about"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-lg-8 mx-auto text-center"">
            <h2 class=""section-heading text-white"">We've got ");
            WriteLiteral(@"what you need!</h2>
            <hr class=""light my-4"">
            <p class=""text-faded mb-4"">Start Bootstrap has everything you need to get your new website up and running in no time! All of the templates and themes on Start Bootstrap are open source, free to download, and easy to use. No strings attached!</p>
            <a class=""btn btn-light btn-xl js-scroll-trigger"" href=""#services"">Get Started!</a>
          </div>
        </div>
      </div>
    </section>

    <section id=""services"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-lg-12 text-center"">
            <h2 class=""section-heading"">At Your Service</h2>
            <hr class=""my-4"">
          </div>
        </div>
      </div>
      <div class=""container"">
        <div class=""row"">
          <div class=""col-lg-3 col-md-6 text-center"">
            <div class=""service-box mt-5 mx-auto"">
              <i class=""fas fa-4x fa-gem text-primary mb-3 sr-icon-1""></i>
              <h3 class=""mb-3"">Sturdy Templates</h3");
            WriteLiteral(@">
              <p class=""text-muted mb-0"">Our templates are updated regularly so they don't break.</p>
            </div>
          </div>
          <div class=""col-lg-3 col-md-6 text-center"">
            <div class=""service-box mt-5 mx-auto"">
              <i class=""fas fa-4x fa-paper-plane text-primary mb-3 sr-icon-2""></i>
              <h3 class=""mb-3"">Ready to Ship</h3>
              <p class=""text-muted mb-0"">You can use this theme as is, or you can make changes!</p>
            </div>
          </div>
          <div class=""col-lg-3 col-md-6 text-center"">
            <div class=""service-box mt-5 mx-auto"">
              <i class=""fas fa-4x fa-code text-primary mb-3 sr-icon-3""></i>
              <h3 class=""mb-3"">Up to Date</h3>
              <p class=""text-muted mb-0"">We update dependencies to keep things fresh.</p>
            </div>
          </div>
          <div class=""col-lg-3 col-md-6 text-center"">
            <div class=""service-box mt-5 mx-auto"">
              <i class=""fas fa-4x fa-heart text-pri");
            WriteLiteral(@"mary mb-3 sr-icon-4""></i>
              <h3 class=""mb-3"">Made with Love</h3>
              <p class=""text-muted mb-0"">You have to make your websites with love these days!</p>
            </div>
          </div>
        </div>
      </div>
    </section>

    <section class=""p-0"" id=""portfolio"">
      <div class=""container-fluid p-0"">
        <div class=""row no-gutters popup-gallery"">
          <div class=""col-lg-4 col-sm-6"">
            <a class=""portfolio-box"" href=""images/portfolio/fullsize/1.jpg"">
              <img class=""img-fluid"" src=""images/portfolio/thumbnails/1.jpg"" alt="""">
              <div class=""portfolio-box-caption"">
                <div class=""portfolio-box-caption-content"">
                  <div class=""project-category text-faded"">
                    Category
                  </div>
                  <div class=""project-name"">
                    Project Name
                  </div>
                </div>
              </div>
            </a>
          </div>
          <div class=""col-lg");
            WriteLiteral(@"-4 col-sm-6"">
            <a class=""portfolio-box"" href=""images/portfolio/fullsize/2.jpg"">
              <img class=""img-fluid"" src=""images/portfolio/thumbnails/2.jpg"" alt="""">
              <div class=""portfolio-box-caption"">
                <div class=""portfolio-box-caption-content"">
                  <div class=""project-category text-faded"">
                    Category
                  </div>
                  <div class=""project-name"">
                    Project Name
                  </div>
                </div>
              </div>
            </a>
          </div>
          <div class=""col-lg-4 col-sm-6"">
            <a class=""portfolio-box"" href=""images/portfolio/fullsize/3.jpg"">
              <img class=""img-fluid"" src=""images/portfolio/thumbnails/3.jpg"" alt="""">
              <div class=""portfolio-box-caption"">
                <div class=""portfolio-box-caption-content"">
                  <div class=""project-category text-faded"">
                    Category
                  </div>
               ");
            WriteLiteral(@"   <div class=""project-name"">
                    Project Name
                  </div>
                </div>
              </div>
            </a>
          </div>
          <div class=""col-lg-4 col-sm-6"">
            <a class=""portfolio-box"" href=""images/portfolio/fullsize/4.jpg"">
              <img class=""img-fluid"" src=""images/portfolio/thumbnails/4.jpg"" alt="""">
              <div class=""portfolio-box-caption"">
                <div class=""portfolio-box-caption-content"">
                  <div class=""project-category text-faded"">
                    Category
                  </div>
                  <div class=""project-name"">
                    Project Name
                  </div>
                </div>
              </div>
            </a>
          </div>
          <div class=""col-lg-4 col-sm-6"">
            <a class=""portfolio-box"" href=""images/portfolio/fullsize/5.jpg"">
              <img class=""img-fluid"" src=""images/portfolio/thumbnails/5.jpg"" alt="""">
              <div class=""portfolio-box-capti");
            WriteLiteral(@"on"">
                <div class=""portfolio-box-caption-content"">
                  <div class=""project-category text-faded"">
                    Category
                  </div>
                  <div class=""project-name"">
                    Project Name
                  </div>
                </div>
              </div>
            </a>
          </div>
          <div class=""col-lg-4 col-sm-6"">
            <a class=""portfolio-box"" href=""images/portfolio/fullsize/6.jpg"">
              <img class=""img-fluid"" src=""images/portfolio/thumbnails/6.jpg"" alt="""">
              <div class=""portfolio-box-caption"">
                <div class=""portfolio-box-caption-content"">
                  <div class=""project-category text-faded"">
                    Category
                  </div>
                  <div class=""project-name"">
                    Project Name
                  </div>
                </div>
              </div>
            </a>
          </div>
        </div>
      </div>
    </section>

    <sectio");
            WriteLiteral(@"n class=""bg-dark text-white"">
      <div class=""container text-center"">
        <h2 class=""mb-4"">Free Download at Start Bootstrap!</h2>
        <a class=""btn btn-light btn-xl sr-button"" href=""http://startbootstrap.com/template-overviews/creative/"">Download Now!</a>
      </div>
    </section>

    <section id=""contact"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-lg-8 mx-auto text-center"">
            <h2 class=""section-heading"">Let's Get In Touch!</h2>
            <hr class=""my-4"">
            <p class=""mb-5"">Ready to start your next project with us? That's great! Give us a call or send us an email and we will get back to you as soon as possible!</p>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-lg-4 ml-auto text-center"">
            <i class=""fas fa-phone fa-3x mb-3 sr-contact-1""></i>
            <p>+55 (19)99353-9469</p>
          </div>
          <div class=""col-lg-4 mr-auto text-center"">
            <i class=""fas fa-envelope fa-3");
            WriteLiteral("x mb-3 sr-contact-2\"></i>\n            <p>\n              <a href=\"mailto:luisgustavoguerra@gmail.com\">luisgustavoguerra@gmail.com</a>\n            </p>\n          </div>\n        </div>\n      </div>\n    </section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
