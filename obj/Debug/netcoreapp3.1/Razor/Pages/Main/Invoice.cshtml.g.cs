#pragma checksum "C:\Users\Anjar\Documents\My Appl\MiniInvoice\MiniInvoice\Pages\Main\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cedd260c4be3101ed46725cd0a593c5a733fa0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MiniInvoice.Pages.Main.Pages_Main_Invoice), @"mvc.1.0.razor-page", @"/Pages/Main/Invoice.cshtml")]
namespace MiniInvoice.Pages.Main
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
#line 1 "C:\Users\Anjar\Documents\My Appl\MiniInvoice\MiniInvoice\Pages\_ViewImports.cshtml"
using MiniInvoice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cedd260c4be3101ed46725cd0a593c5a733fa0f", @"/Pages/Main/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32285722b84d0301e309cfd701e66bd1f06a502", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Main_Invoice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ui-1.12.1/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ckeditor5-build-classic/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-3.6.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ui-1.12.1/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""row"">    <div class=""col-md-8"">        <span class=""badge badge-success"" style=""width: fit-content; height: fit-content;"">PAID</span>        <label><h3>Bill</h3></label>        <div class=""row"">            <div class=""col-md-10"">                ");
#nullable restore
#line 12 "C:\Users\Anjar\Documents\My Appl\MiniInvoice\MiniInvoice\Pages\Main\Invoice.cshtml"
           Write(Html.TextBox("staticText", "", new { @id = "staticText", @autocomplete = "off", @class = "form-control col-md-10", placeholder = "Please find attached your invoice. Thank you for timely payment" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r            </div>\r        </div>\r    </div>\r    <div class=\"col-md-4\">\r        <img");
            BeginWriteAttribute("src", " src=\"", 579, "\"", 627, 1);
#nullable restore
#line 17 "C:\Users\Anjar\Documents\My Appl\MiniInvoice\MiniInvoice\Pages\Main\Invoice.cshtml"
WriteAttributeValue("", 585, Url.Content("~/images/bukalapakLogo.png"), 585, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""tbd"" style=""width: 170px; height: 100px"" />    </div></div><div class=""row"">    <div class=""col-4"">        Invoice. No        <div class=""col-auto"">            <label class=""sr-only"" for=""inlineFormInputGroup"">Username</label>            <div class=""input-group mb-2"">                <div class=""input-group-prepend"">                    <div class=""input-group-text"">#</div>                </div>                <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""Invoice"">            </div>        </div>    </div>    <div class=""col-4"">        Language        <div class=""dropdown"">            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">                Dropdown button            </button>            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">                <a class=""dropdown-item"" href=""#"">Action</a>                <a class=""d");
            WriteLiteral(@"ropdown-item"" href=""#"">Another action</a>                <a class=""dropdown-item"" href=""#"">Something else here</a>            </div>        </div>    </div>    <div class=""col-4"">        Currency        <div class=""dropdown"">            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">                Dropdown button            </button>            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">                <a class=""dropdown-item"" href=""#"">Action</a>                <a class=""dropdown-item"" href=""#"">Another action</a>                <a class=""dropdown-item"" href=""#"">Something else here</a>            </div>        </div>    </div></div><hr /><div class=""row"">    <div class=""col-4 themed-grid-col"">        From        <div class=""btn-group"">            <input id=""searchinput"" type=""search"" class=""form-control"">            <span id=""searchclear"" class=""glyphico");
            WriteLiteral(@"n glyphicon-remove-circle""></span>        </div>    </div>    <div class=""col-4""></div>    <div class=""col-4 themed-grid-col"">        Date        <div class=""form-group input-group-sm"">            <input type=""text"" id=""txtSelectedDate"" name=""SelectedDate"" class=""form-control""/>        </div>        Invoice Due        <div class=""form-group input-group-sm"">            ");
#nullable restore
#line 84 "C:\Users\Anjar\Documents\My Appl\MiniInvoice\MiniInvoice\Pages\Main\Invoice.cshtml"
       Write(Html.DropDownList("item", new SelectList(new[] {""}),                new {@class = "btn btn-secondary dropdown-toggle form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>    </div></div><div class=""row"">    <div class=""col-4 themed-grid-col"">        To        <div class=""btn-group"">            <input id=""searchinput"" type=""search"" class=""form-control"">            <span id=""searchclear"" class=""glyphicon glyphicon-remove-circle""></span>        </div>    </div>    <div class=""col-4""></div>    <div class=""col-4 themed-grid-col"">        Purchase Order Number        <div class=""form-group input-group-sm"">            <input type=""text"" id=""txtInvoicePopUP"" name=""invPopUp"" class=""form-control"" />        </div>    </div></div><hr/><fieldset>    <table id=""submissionTable"" class=""table "">        <thead>            <tr>                <td>Sample ID</td>                <td>Additional Comments</td>                <td>Acid-stable amino acids</td>            </tr>        </thead>        <tr id=""tablerow0"">            <td>                <div class=""editor-field"">                    <div id=""editor""></div>                </div>            ");
            WriteLiteral("</td>\r            <td>\r                <div class=\"editor-field\">\r                    <input class=\"text-box single-line\" name=\"AdditionalComments[0]\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4379, "\"", 4387, 0);
            EndWriteAttribute();
            WriteLiteral(" required=\"required\" />\r                </div>\r            </td>\r            <td>\r                <div class=\"editor-field\">\r                    <input class=\"text-box single-line\" name=\"AcidStables[0]\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4602, "\"", 4610, 0);
            EndWriteAttribute();
            WriteLiteral(@" />                </div>            </td>        </tr>    </table>    <p>        <button id=""add"" type=""button"" class=""btn btn-primary"">Add</button>    </p>    <hr />    <p>        <input type=""submit"" value=""Create"" class=""btn btn-default"" />    </p></fieldset>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cedd260c4be3101ed46725cd0a593c5a733fa0f10997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\r");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cedd260c4be3101ed46725cd0a593c5a733fa0f12112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cedd260c4be3101ed46725cd0a593c5a733fa0f13150", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cedd260c4be3101ed46725cd0a593c5a733fa0f14188", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<script>    ClassicEditor        .create( document.querySelector( '#editor' ) )        .catch( error => {            console.error( error );        } );</script><script type=""text/javascript"">    //Data Load from back    function langLoad(parameters) {        $.ajax({            type: 'POST',            url: ""urlnya"",            data: $(""#locid"").serialize(), //token here            success: function (data) {                $($.parseJSON(data.msg)).map(function () {                    return $('<option>').val(this.value).text(this.label);                }).appendTo('#combobox');            },            error: function (XMLHttpRequest, textStatus, errorThrown) {                alert(textStatus);            },            dataType: ""json""        });    }    function currencyLoad(parameters) {        $.ajax({            type: 'POST',            url: ""urlnya"",            data: $(""#locid"").serialize(), //token here            success: function (data) {                $($.pa");
            WriteLiteral(@"rseJSON(data.msg)).map(function () {                    return $('<option>').val(this.value).text(this.label);                }).appendTo('#combobox');            },            error: function (XMLHttpRequest, textStatus, errorThrown) {                alert(textStatus);            },            dataType: ""json""        });    }    //    $(document).ready(function () {        var numbers = [1, 2, 3, 4, 5];        var option = '';        for (var i = 0; i < numbers.length; i++) {            option += '<option value=""' + numbers[i] + '"">' + numbers[i] + '</option>';        }        $('#items').append(option);    });    $('#txtSelectedDate').datepicker({        dateFormat: 'yy-mm-dd'    });    var counter = 1;    $(function () {        $('#add').click(function () {            $('<tr id=""tablerow' + counter + '""><td>' +                '<input type=""text"" class=""text-box single-line"" name=""ClientSampleID[' + counter + ']"" value="""" required=""required"" />' +                '</t");
            WriteLiteral(@"d>' +                '<td>' +                '<input type=""text"" class=""text-box single-line"" name=""AdditionalComments[' + counter + ']"" value="""" required=""required"" />' +                '</td>' +                '<td>' +                '<input type=""text"" class=""text-box single-line"" name=""AcidStables[' + counter + ']"" value="""" required=""required"" />' +                '</td>' +                '<td>' +                '<button type=""button"" class=""btn btn-primary"" onclick=""removeTr(' + counter + ');"">Delete</button>' +                '</td>' +                '</tr>').appendTo('#submissionTable');            counter++;            return false;        });    });    function removeTr(index) {        if (counter > 1) {            $('#tablerow' + index).remove();            counter--;        }        return false;    }    $(""#searchclear"").click(function () {        $(""#searchinput"").val('');    });</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InvoiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InvoiceModel>)PageContext?.ViewData;
        public InvoiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
