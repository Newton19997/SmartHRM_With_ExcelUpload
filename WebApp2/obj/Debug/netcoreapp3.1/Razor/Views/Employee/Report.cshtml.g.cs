#pragma checksum "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54cb748ec5aca18f10fff3e95c96a04b0bf970b0d32fddd1be74c9aace661fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Report), @"mvc.1.0.view", @"/Views/Employee/Report.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\_ViewImports.cshtml"
using WebApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\_ViewImports.cshtml"
using WebApp2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"54cb748ec5aca18f10fff3e95c96a04b0bf970b0d32fddd1be74c9aace661fb8", @"/Views/Employee/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0448330cac9709971f8c6dfe97485e9c53b60b88dd4599aabef0ed53d83e15e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Modelss.ViewModels.SpEmployeeInfo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Report</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"container\">\r\n        <div class=\"form-group col-md-4\">\r\n            <label for=\"UnitPrice\" class=\"control-label\">Employee ID</label>\r\n");
            WriteLiteral(@"            <input type=""text"" name=""number"" id=""EmployeeID""  class=""form-control"" />

        </div>
        <div class=""form-group"">
            <button type=""button"" class=""btn btn-primary"" onclick=""ShowSalarywithBonus()""> Show Salary with Bonus</button>
            <button type=""button"" class=""btn btn-info"" onclick=""HighlightSalary()""> Highlight Salary</button>
            <button type=""button"" class=""btn btn-info"" onclick=""HighlightName()""> Highlight Name</button>
        </div>
    </div>
</div>
<div class=""row"">
    <table class=""table"" id=""highlightColumn"">
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 28 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayNameFor(model => model.Salarywithbonus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayNameFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayNameFor(model => model.IsBonusAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 49 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Salarywithbonus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsBonusAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 72 "D:\Newton\20240101 NEW Year\FinalRoyex\Newton_Royex\WebApp2\Views\Employee\Report.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            WriteLiteral("<div class=\"modal fade\" id=\"MyModel\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
            WriteLiteral("            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54cb748ec5aca18f10fff3e95c96a04b0bf970b0d32fddd1be74c9aace661fb89915", async() => {
                WriteLiteral("\r\n                    <fieldset id=\"Submitform\">\r\n\r\n");
                WriteLiteral(@"                        <label for=""UnitPrice"" class=""control-label"">Please provide valid employee id.</label>
                    </fieldset>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
");
                WriteLiteral("                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("<div class=\"modal fade\" id=\"MyModelv\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <label for=\"sd\" class=\"control-label\">Employee Show</label>\r\n\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54cb748ec5aca18f10fff3e95c96a04b0bf970b0d32fddd1be74c9aace661fb812107", async() => {
                WriteLiteral("\r\n                    <fieldset id=\"Submitform\">\r\n");
                WriteLiteral(@"                        <div class=""form-group"">
                            <label for=""Name"" class=""control-label"">Name</label>
                            <input type=""text"" name=""Name"" id=""Name"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""Position"" class=""control-label"">Position</label>
                            <input type=""text"" name=""Position"" id=""Position"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""Salarywithbonus"" class=""control-label"">Salarywithbonus</label>
                            <input type=""text"" name=""Salarywithbonus"" id=""Salarywithbonus"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""JoinDate"" class=""control-label"">JoinDate</label>
                            <input type=""text"" nam");
                WriteLiteral(@"e=""JoinDate"" id=""JoinDate"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""IsBonusAdded"" class=""control-label"">IsBonusAdded</label>
                            <input type=""text"" name=""IsBonusAdded"" id=""IsBonusAdded"" class=""form-control"" />
                        </div>

                    </fieldset>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
       
        //$(document).ready(function () {
        //    var ids = $('#EmployeeID').val();           
        //    $(""#EmployeeID"").focus(function () {
        //        $(this).css(""background-color"", ""yellow"");
        //    });          

        //});


        $(document).ready(function () {
            $(""#EmployeeID"").keyup(function () {
                var command = $(this).val();
                console.log(command);
               // alert(command);
                if (command) {
                    var ch = isNumeric(command);
                    // alert(ch)
                    console.log(ch, typeof ch);
                    if (ch==false){
                        $(""#EmployeeID"").val = '';
                        $(""#form"")[0].reset();
                        $(""#MyModel"").modal();
                    }
                }
           
            });
        });

        function isNumeric(value) {
            return /^-?\d+$/.test(value);
    ");
                WriteLiteral(@"    }
      
        function Vcheck(df) {

            var ch = isNumber(command);
            alert(ch);
            if (ch == true) {
            } else {
                $(""#EmployeeID"").val = ' ';
                $(""#form"")[0].reset();
                $(""#MyModel"").modal();
            }
        }

        function EditOrderDetails(ordetailsID) {
          //  alert('ordetailsID', ordetailsID);           
            $(""#MyModelv"").modal();           
            $.ajax(
                {
                    url: ""/api/Employee/EmployeeDetails?Id="" + ordetailsID,
                    success: function (data) {
                        var oDs = data;
                        console.log(oDs);
                       // $(""#OrdetailsID"").val(oDs[0].id);
                        $(""#Name"").val(oDs[0].name);
                        $(""#Position"").val(oDs[0].position);
                        $(""#Salarywithbonus"").val(oDs[0].salarywithbonus);
                        $(""#JoinDate"").val(o");
                WriteLiteral(@"Ds[0].joinDate);
                        $(""#IsBonusAdded"").val(oDs[0].isBonusAdded);
                    },
                    error: function (response) {
                        alert(response);
                    }
                });
        }
        function ShowSalarywithBonus() {
            var ids = $('#EmployeeID').val();
            console.log('newton', ids);

            if (ids == '') {
                $(""#form"")[0].reset();                
                $(""#MyModel"").modal();
            }
            if (ids) {
                var ch = isNumeric(ids);
                // alert(ch)
                console.log(ch, typeof ch);
                if (ch == false) {
                    $(""#EmployeeID"").val = '';
                    $(""#form"")[0].reset();
                    $(""#MyModel"").modal();
                }
                else {
                    this.EditOrderDetails(ids)
                }
            }

           

        }

        function highlig");
                WriteLiteral(@"htColumn(columnIndex) {
            var table = document.getElementById(""highlightColumn"");
            var rows = table.getElementsByTagName(""tr"");

            for (var i = 0; i < rows.length; i++) {
                var cells = rows[i].getElementsByTagName(""td"");
                if (cells.length > columnIndex) {
                    cells[columnIndex].style.backgroundColor = ""#008000"";
                }
            }
        }

        function HighlightSalary() {
            this.highlightColumn(3); // Replace 2 with the index of the column you want to highlight
            // });
        }


        function highlightColumn1(Index) {
            var table1 = document.getElementById(""highlightColumn"");
            var rows1 = table1.getElementsByTagName(""tr"");

            for (var i = 0; i < rows1.length; i++) {
                var cells1 = rows1[i].getElementsByTagName(""td"");
                if (cells1.length > Index) {
                    cells1[Index].style.backgroundColor = ""#0");
                WriteLiteral("000FF\";\r\n                }\r\n            }\r\n        }\r\n\r\n        function HighlightName() {          \r\n            this.highlightColumn1(1); // Replace 2 with the index of the column you want to highlight\r\n            // });\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Modelss.ViewModels.SpEmployeeInfo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
