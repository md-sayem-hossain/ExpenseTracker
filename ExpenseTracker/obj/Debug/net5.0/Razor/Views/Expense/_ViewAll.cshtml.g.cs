#pragma checksum "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7e564138791624f1cbf3139a9d88348bffe5a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense__ViewAll), @"mvc.1.0.view", @"/Views/Expense/_ViewAll.cshtml")]
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
#line 1 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\_ViewImports.cshtml"
using ExpenseTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\_ViewImports.cshtml"
using ExpenseTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e564138791624f1cbf3139a9d88348bffe5a93", @"/Views/Expense/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d2bc418d006ee1a17f8c977b1f7a33b7f0c16f", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExpenseTracker.Models.Expense>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.css"" rel=""stylesheet"" />



<p>
");
            WriteLiteral("    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 450, "\"", 550, 4);
            WriteAttributeValue("", 460, "showInPopup(\'", 460, 13, true);
#nullable restore
#line 11 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
WriteAttributeValue("", 473, Url.Action("AddOrEdit","Expense",null,Context.Request.Scheme), 473, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 535, "\',\'New", 535, 6, true);
            WriteAttributeValue(" ", 541, "Record\')", 542, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" style=\"color:white\">New Record</a>\r\n</p>\r\n\r\n\r\n<table class=\"table\" id=\"tableId\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpanceAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 23 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ExpenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpanceAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 40 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExpenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1655, "\"", 1780, 4);
            WriteAttributeValue("", 1665, "showInPopup(\'", 1665, 13, true);
#nullable restore
#line 47 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
WriteAttributeValue("", 1678, Url.Action("AddOrEdit","Expense",new { id = item.ExpenseId},Context.Request.Scheme), 1678, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1762, "\',\'Update", 1762, 9, true);
            WriteAttributeValue(" ", 1771, "Record\')", 1772, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"color:white\">Edit</a>|\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e564138791624f1cbf3139a9d88348bffe5a939310", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7e564138791624f1cbf3139a9d88348bffe5a939592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.ExpenseId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
                                                WriteLiteral(item.ExpenseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "G:\Projects\Expense Tracker\ExpenseTracker\ExpenseTracker\ExpenseTracker\Views\Expense\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>









<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap.min.js""></script>
<script src=""https://cdn.jsdelivr.net/momentjs/latest/moment.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js""></script>




<script>

    //fungsi untuk filtering data berdasarkan tanggal 
    var start_date;
    var end_date;
    var DateFilterFunction = (function (oSettings, aData, iDataIndex) {
        var dateStart = parseDateValue(start_date);
        var dateEnd = parseDateValue(end_date);
        //Kolom tanggal yang akan kita gunakan berada dalam urutan 2, karena dihitung mulai dari 0
        //nama depan = 0
        //nama belakang = 1
 ");
            WriteLiteral(@"       //tanggal terdaftar =2
        var evalDate = parseDateValue(aData[2]);
        if ((isNaN(dateStart) && isNaN(dateEnd)) ||
            (isNaN(dateStart) && evalDate <= dateEnd) ||
            (dateStart <= evalDate && isNaN(dateEnd)) ||
            (dateStart <= evalDate && evalDate <= dateEnd)) {
            return true;
        }
        return false;
    });

    // fungsi untuk converting format tanggal dd/mm/yyyy menjadi format tanggal javascript menggunakan zona aktubrowser
    function parseDateValue(rawDate) {
        var dateArray = rawDate.split(""/"");
        var parsedDate = new Date(dateArray[2], parseInt(dateArray[1]) - 1, dateArray[0]);  // -1 because months are from 0 to 11   
        return parsedDate;
    }

    $(document).ready(function () {
        //konfigurasi DataTable pada tabel dengan id example dan menambahkan  div class dateseacrhbox dengan dom untuk meletakkan inputan daterangepicker
        var $dTable = $('#tableId').DataTable({
            ""dom"": ""<'");
            WriteLiteral(@"row'<'col-sm-4'l><'col-sm-5' <'datesearchbox'>><'col-sm-3'f>>"" +
                ""<'row'<'col-sm-12'tr>>"" +
                ""<'row'<'col-sm-5'i><'col-sm-7'p>>""
        });

        //menambahkan daterangepicker di dalam datatables
        $(""div.datesearchbox"").html('<div class=""input-group""> <div class=""input-group-addon""> <i class=""glyphicon glyphicon-calendar""></i> </div><input type=""text"" class=""form-control pull-right"" id=""datesearch"" placeholder=""Search by date range..""> </div>');

        document.getElementsByClassName(""datesearchbox"")[0].style.textAlign = ""right"";

        //konfigurasi daterangepicker pada input dengan id datesearch
        $('#datesearch').daterangepicker({
            autoUpdateInput: false
        });

        //menangani proses saat apply date range
        $('#datesearch').on('apply.daterangepicker', function (ev, picker) {
            $(this).val(picker.startDate.format('MM/DD/YYYY') + ' - ' + picker.endDate.format('MM/DD/YYYY'));
            start_date = pic");
            WriteLiteral(@"ker.startDate.format('MM/DD/YYYY');
            end_date = picker.endDate.format('MM/DD/YYYY');
            $.fn.dataTableExt.afnFiltering.push(DateFilterFunction);
            $dTable.draw();
        });

        $('#datesearch').on('cancel.daterangepicker', function (ev, picker) {
            $(this).val('');
            start_date = '';
            end_date = '';
            $.fn.dataTable.ext.search.splice($.fn.dataTable.ext.search.indexOf(DateFilterFunction, 1));
            $dTable.draw();
        });
    });


</script>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExpenseTracker.Models.Expense>> Html { get; private set; }
    }
}
#pragma warning restore 1591
