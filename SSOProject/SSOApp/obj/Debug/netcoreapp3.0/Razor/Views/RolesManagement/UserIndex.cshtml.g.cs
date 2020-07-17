#pragma checksum "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f0d09017adb37a16e05adab30807c87f7db42c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RolesManagement_UserIndex), @"mvc.1.0.view", @"/Views/RolesManagement/UserIndex.cshtml")]
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
#line 1 "F:\James\SSOProject\SSOProject\SSOApp\Views\_ViewImports.cshtml"
using SSOApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
using SSOApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f0d09017adb37a16e05adab30807c87f7db42c", @"/Views/RolesManagement/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e2f8da519da6990308c8d8fd425631ca3abf1b7", @"/Views/_ViewImports.cshtml")]
    public class Views_RolesManagement_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("(max-width: 767px)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.less"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
  
    ViewData["Title"] = "UserRoles";

    ViewData["Title"] = "UsersByRole";
    List<RoleViewModel> roles = ViewBag.Roles as List<RoleViewModel>;
    List<RoleViewModel> userselectedroles = ViewBag.UserRoles as List<RoleViewModel>;
    string tenant = ViewBag.TenantName;
    string tenantcode = ViewBag.TenantCode;
    string username = ViewBag.UserRoles[0].UserFullName;
    string userid = ViewBag.UserID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62f0d09017adb37a16e05adab30807c87f7db42c4866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>User Roles</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 18 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label class=\"bg-success\">");
#nullable restore
#line 20 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                             Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 21 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
        TempData["Success"] = null;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
     if (TempData["Failed"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label class=\"bg-danger\">");
#nullable restore
#line 25 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                            Write(TempData["Failed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 26 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
        TempData["Failed"] = null;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div>\r\n    Tenant : ");
#nullable restore
#line 31 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
        Write(tenant);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (CODE : ");
#nullable restore
#line 31 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                        Write(tenantcode);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n    User :  ");
#nullable restore
#line 32 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
       Write(username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"card-columns\">\r\n");
            WriteLiteral(@"
    <!--
      Blog entry: https://esausilva.com/2016/01/29/move-items-between-two-listbox-using-jquery-html-select-tag/

      I recommend using my plug in instead: https://esausilva.com/2016/02/28/jquery-selectlistactions-js-plugin-to-move-items-between-two-select-lists-remove-select-list-items-and-move-up-and-down-select-list-items/
    -->
    <div class=""subject-info-box-1"">
        <select multiple=""multiple"" id='lstBox1' class=""form-control"">
");
#nullable restore
#line 115 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
             foreach (var i in userselectedroles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f0d09017adb37a16e05adab30807c87f7db42c9130", async() => {
#nullable restore
#line 117 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                  WriteLiteral(i.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 118 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>

    <div class=""subject-info-arrows text-center"">
        <input type='button' id='btnAllRight' value='>>' class=""btn btn-default"" /><br />
        <input type='button' id='btnRight' value='>' class=""btn btn-default"" /><br />
        <input type='button' id='btnLeft' value='<' class=""btn btn-default"" /><br />
        <input type='button' id='btnAllLeft' value='<<' class=""btn btn-default"" />
    </div>

    <div class=""subject-info-box-2"">
        <select multiple=""multiple"" id='lstBox2' class=""form-control"">
");
#nullable restore
#line 131 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
             foreach (var i in userselectedroles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f0d09017adb37a16e05adab30807c87f7db42c11947", async() => {
#nullable restore
#line 133 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                                 Write(i.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 133 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
                  WriteLiteral(i.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 134 "F:\James\SSOProject\SSOProject\SSOApp\Views\RolesManagement\UserIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
    </div>

    <div class=""clearfix""></div>

    <input type=""submit"" name=""btnSubmit"" id=""btn-submit"" value=""Finished"" />

</div>


<script type=""text/javascript"">
    $(function () {
        $(""#btn-submit"").click(function () {
            // let's show a loading image\
            debugger;

            var selectedValues = $('#lstBox2 option');
            let a = [];

            for (var i = 0; i < selectedValues.length; i++) {
                if (selectedValues[i].value != """") {
                    a.push(selectedValues[i].value);

                }
            }
            alert(selectedValues);
            var input = $(""<input>"")
                .attr(""type"", ""hidden"")
                .attr(""name"", ""mydata"").val(a);

            $('#form1').append(input);


            return true;
        });
        $('#btnRight').click(function (e) {
            var selectedOpts = $('#lstBox1 option:selected');
            if (selectedOpts.length == 0) {
 ");
            WriteLiteral(@"               alert(""Nothing to move."");
                e.preventDefault();
            }
            $('#lstBox2').append($(selectedOpts).clone());
            $(selectedOpts).remove();
            e.preventDefault();
        });
        $('#btnAllRight').click(function (e) {
            var selectedOpts = $('#lstBox1 option');
            if (selectedOpts.length == 0) {
                alert(""Nothing to move."");
                e.preventDefault();
            }
            $('#lstBox2').append($(selectedOpts).clone());
            $(selectedOpts).remove();
            e.preventDefault();
        });
        $('#btnLeft').click(function (e) {
            var selectedOpts = $('#lstBox2 option:selected');
            if (selectedOpts.length == 0) {
                alert(""Nothing to move."");
                e.preventDefault();
            }
            $('#lstBox1').append($(selectedOpts).clone());
            $(selectedOpts).remove();
            e.preventDefault();
        });
   ");
            WriteLiteral(@"     $('#btnAllLeft').click(function (e) {
            var selectedOpts = $('#lstBox2 option');
            if (selectedOpts.length == 0) {
                alert(""Nothing to move."");
                e.preventDefault();
            }
            $('#lstBox1').append($(selectedOpts).clone());
            $(selectedOpts).remove();
            e.preventDefault();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
