#pragma checksum "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c718c4ea813d44bca0f1c29fb71f47ff6c898a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrine_ProdutoDetalhe), @"mvc.1.0.view", @"/Views/Vitrine/ProdutoDetalhe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vitrine/ProdutoDetalhe.cshtml", typeof(AspNetCore.Views_Vitrine_ProdutoDetalhe))]
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
#line 1 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#line 2 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c718c4ea813d44bca0f1c29fb71f47ff6c898a", @"/Views/Vitrine/ProdutoDetalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Vitrine_ProdutoDetalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel>
    {
        private global::AspNetCore.Views_Vitrine_ProdutoDetalhe.__Generated__SummaryViewComponentTagHelper __SummaryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
  
    ViewData["Title"] = "Produto Detalhe";

#line default
#line hidden
            BeginContext(118, 2221, true);
            WriteLiteral(@"
<style>
    ul > li {
        margin-right: 25px;
        font-weight: lighter;
        cursor: pointer
    }

    li.active {
        border-bottom: 3px solid silver;
    }

    .item-photo {
        display: flex;
        justify-content: center;
        align-items: center;
        border-right: 1px solid #f6f6f6;
    }

    .menu-items {
        list-style-type: none;
        font-size: 11px;
        display: inline-flex;
        margin-bottom: 0;
        margin-top: 20px
    }

    .btn-success {
        width: 100%;
        border-radius: 0;
    }

    .section {
        width: 100%;
        margin-left: -15px;
        padding: 2px;
        padding-left: 15px;
        padding-right: 15px;
        background: #f8f9f9
    }

    .title-price {
        margin-top: 30px;
        margin-bottom: 0;
        color: black
    }

    .title-attr {
        margin-top: 0;
        margin-bottom: 0;
        color: black;
    }

    .btn-minus {
        cursor: po");
            WriteLiteral(@"inter;
        font-size: 7px;
        display: flex;
        align-items: center;
        padding: 5px;
        padding-left: 10px;
        padding-right: 10px;
        border: 1px solid gray;
        border-radius: 2px;
        border-right: 0;
    }

    .btn-plus {
        cursor: pointer;
        font-size: 7px;
        display: flex;
        align-items: center;
        padding: 5px;
        padding-left: 10px;
        padding-right: 10px;
        border: 1px solid gray;
        border-radius: 2px;
        border-left: 0;
    }

    div.section > div {
        width: 100%;
        display: inline-flex;
    }

        div.section > div > input {
            margin: 0;
            padding-left: 5px;
            font-size: 10px;
            padding-right: 5px;
            max-width: 18%;
            text-align: center;
        }

    .attr, .attr2 {
        cursor: pointer;
        margin-right: 5px;
        height: 20px;
        font-size: 10px;
        padding:");
            WriteLiteral(" 2px;\r\n        border: 1px solid gray;\r\n        border-radius: 2px;\r\n    }\r\n\r\n        .attr.active, .attr2.active {\r\n            border: 1px solid orange;\r\n        }\r\n\r\n    ");
            EndContext();
            BeginContext(2340, 821, true);
            WriteLiteral(@"@media (max-width: 426px) {
        .container {
            margin-top: 0px !important;
        }

            .container > .row {
                padding: 0 !important;
            }

                .container > .row > .col-xs-12.col-sm-5 {
                    padding-right: 0;
                }

                .container > .row > .col-xs-12.col-sm-9 > div > p {
                    padding-left: 0 !important;
                    padding-right: 0 !important;
                }

                .container > .row > .col-xs-12.col-sm-9 > div > ul {
                    padding-left: 10px !important;
                }

        .section {
            width: 104%;
        }

        .menu-items {
            padding-left: 0;
        }
    }
</style>
<div class=""container"">
    
    ");
            EndContext();
            BeginContext(3161, 14, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72c718c4ea813d44bca0f1c29fb71f47ff6c898a8922", async() => {
            }
            );
            __SummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Vitrine_ProdutoDetalhe.__Generated__SummaryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SummaryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3175, 84, true);
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-4 item-photo\">\r\n\r\n            ");
            EndContext();
            BeginContext(3259, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72c718c4ea813d44bca0f1c29fb71f47ff6c898a10059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3294, "~/Images/", 3294, 9, true);
#line 150 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
AddHtmlAttributeValue("", 3303, Model.Imagem, 3303, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3319, 99, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-xs-5\" style=\"border: 20px solid white\">\r\n            <h3>");
            EndContext();
            BeginContext(3419, 10, false);
#line 153 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
           Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3429, 114, true);
            WriteLiteral("</h3>\r\n\r\n            <h6 class=\"title-price\"><small>OFERTA</small></h6>\r\n            <h3 style=\"margin-top: 0px;\">");
            EndContext();
            BeginContext(3544, 25, false);
#line 156 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
                                    Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3569, 31, true);
            WriteLiteral("</h3>\r\n\r\n            <p>Apenas ");
            EndContext();
            BeginContext(3601, 23, false);
#line 158 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
                 Write(Model.QuantidadeEstoque);

#line default
#line hidden
            EndContext();
            BeginContext(3624, 33, true);
            WriteLiteral(" em estoque!</p>\r\n            <p>");
            EndContext();
            BeginContext(3658, 15, false);
#line 159 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
          Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(3673, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(3691, 985, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72c718c4ea813d44bca0f1c29fb71f47ff6c898a13638", async() => {
                BeginContext(3764, 58, true);
                WriteLiteral("\r\n\r\n                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3822, "\"", 3839, 1);
#line 162 "C:\Users\ti\Documents\GitHub\NerdStore - CQRS\src\NerdStore.WebApp.MVC\Views\Vitrine\ProdutoDetalhe.cshtml"
WriteAttributeValue("", 3830, Model.Id, 3830, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3840, 829, true);
                WriteLiteral(@"/>

                <div class=""section"" style=""padding-bottom: 20px;"">
                    <h6 class=""title-attr""><small>QUANTIDADE</small></h6>
                    <div>
                        <div class=""btn-minus""><span style=""font-size: 15px"">-</span></div>
                        <input id=""quantidade"" name=""quantidade"" style=""font-size: 15px"" type=""text"" value=""1""/>
                        <div class=""btn-plus""><span style=""font-size: 15px"">+</span></div>
                    </div>
                </div>

                <!-- Botoes de compra -->
                <div class=""section"" style=""padding-bottom: 20px;"">
                    <button type=""submit"" class=""btn btn-success""><span style=""margin-right: 20px"" aria-hidden=""true""></span> Comprar agora!</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4676, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4737, 1294, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function(){
            //-- Click on detail
            $(""ul.menu-items > li"").on(""click"",function(){
                $(""ul.menu-items > li"").removeClass(""active"");
                $(this).addClass(""active"");
            })

            $("".attr,.attr2"").on(""click"",function(){
                var clase = $(this).attr(""class"");

                $(""."" + clase).removeClass(""active"");
                $(this).addClass(""active"");
            })

            //-- Click on QUANTITY
            $("".btn-minus"").on(""click"",function(){
                var now = $("".section > div > input"").val();
                if ($.isNumeric(now)){
                    if (parseInt(now) -1 > 0){ now--;}
                    $("".section > div > input"").val(now);
                }else{
                    $("".section > div > input"").val(""1"");
                }
            })
            $("".btn-plus"").on(""click"",function(){
                var now = $("".section > div > in");
                WriteLiteral(@"put"").val();
                if ($.isNumeric(now)){
                    $("".section > div > input"").val(parseInt(now)+1);
                }else{
                    $("".section > div > input"").val(""1"");
                }
            })
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(6034, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:summary")]
        public class __Generated__SummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__SummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Summary", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
