#pragma checksum "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24b6030b00b1229cb20e8476d6bf30770101f40ad1c5a71a0650136db0a88a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Details), @"mvc.1.0.view", @"/Views/Pedidos/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\_ViewImports.cshtml"
using ARJOU_V001

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\_ViewImports.cshtml"
using ARJOU_V001.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
 using ARJOU_V001.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"24b6030b00b1229cb20e8476d6bf30770101f40ad1c5a71a0650136db0a88a42", @"/Views/Pedidos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a550942f0de3323d3d86f40382288c5bf810bad8619e5d3f5fab9b428c036fad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pedidos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ARJOU_V001.Models.Pedido>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagen de Referencia"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 150px; border-radius: 8px; border: 1px solid #333;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 8px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
  
    ViewData["Title"] = "Detalles del Pedido";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h1 class=""text-center font-weight-bold"" style=""color: #000;"">Detalles del Pedido</h1>

<div class=""container mt-4 p-4"" style=""background-color: #fff; border-radius: 8px; box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.1);"">
    <h4 class=""text-uppercase"" style=""color: #000;"">Pedido</h4>
    <hr />

    <dl class=""row"">
        <dt class=""col-sm-3 text-right font-weight-bold"" style=""color: #333;"">
            ");
            Write(
#nullable restore
#line 16 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 19 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 23 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.EstiloDeseado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 26 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.EstiloDeseado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 30 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.ColorDeseado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 33 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.ColorDeseado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 37 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.LongitudDeseada)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 40 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.LongitudDeseada)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 44 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.DescripcionAdicional)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 47 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.DescripcionAdicional)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 51 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.ImagenReferencia)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n");
#nullable restore
#line 54 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             if (!string.IsNullOrEmpty(Model.ImagenReferencia))
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"mb-3\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24b6030b00b1229cb20e8476d6bf30770101f40ad1c5a71a0650136db0a88a4212571", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2216, "~/images/", 2216, 9, true);
            AddHtmlAttributeValue("", 2225, 
#nullable restore
#line 57 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
                                        Model.ImagenReferencia

#line default
#line hidden
#nullable disable
            , 2225, 23, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 59 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <p style=\"color: #999;\">No hay imagen de referencia</p>\r\n");
#nullable restore
#line 63 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 67 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.PrecioEstimado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 70 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.PrecioEstimado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 74 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.FechaSolicitud)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 77 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.FechaSolicitud)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-3 text-right font-weight-bold\" style=\"color: #333;\">\r\n            ");
            Write(
#nullable restore
#line 81 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayNameFor(model => model.Estado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-9\" style=\"color: #666;\">\r\n            ");
            Write(
#nullable restore
#line 84 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
             Html.DisplayFor(model => model.Estado)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
#nullable restore
#line 88 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
     if (Model.PrecioEstimado > 0 && !Model.ConfirmadoPorUsuario)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b6030b00b1229cb20e8476d6bf30770101f40ad1c5a71a0650136db0a88a4217547", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-outline-dark\" style=\"border-radius: 8px;\">Confirmar Pedido</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 90 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
                                                          Model.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n\r\n<div class=\"text-center mt-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b6030b00b1229cb20e8476d6bf30770101f40ad1c5a71a0650136db0a88a4220707", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 97 "C:\Users\DELL\Desktop\ARJOU\ARJOU_V001\ARJOU_V001\Views\Pedidos\Details.cshtml"
                                        Model.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24b6030b00b1229cb20e8476d6bf30770101f40ad1c5a71a0650136db0a88a4223080", async() => {
                WriteLiteral("Volver a la Lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ARJOU_V001.Models.Pedido> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
