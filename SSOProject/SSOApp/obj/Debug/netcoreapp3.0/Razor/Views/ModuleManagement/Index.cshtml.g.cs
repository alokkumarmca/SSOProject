#pragma checksum "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d4159ff22ade5625597d95e194bcfd5bc2b30f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ModuleManagement_Index), @"mvc.1.0.view", @"/Views/ModuleManagement/Index.cshtml")]
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
#line 1 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\_ViewImports.cshtml"
using SSOApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d4159ff22ade5625597d95e194bcfd5bc2b30f", @"/Views/ModuleManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e2f8da519da6990308c8d8fd425631ca3abf1b7", @"/Views/_ViewImports.cshtml")]
    public class Views_ModuleManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SSOApp.Proxy.Response<List<SSOApp.API.ViewModels.ModuleViewModel>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
  
    ViewData["Title"] = Model.PageTitle;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"card-header\">\r\n        <h1>Claim Management</h1>\r\n    </div>\r\n    <br />\r\n    <div>\r\n        <b>");
#nullable restore
#line 15 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
      Write(Model.PageSubheading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n    <p>\r\n");
#nullable restore
#line 18 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
         if (Model.ActionResponseCode == "Success")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label class=\"bg-success\">");
#nullable restore
#line 20 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
                                 Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 21 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
        }
        else if (!string.IsNullOrEmpty(Model.ActionResponseCode))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label class=\"bg-danger\">");
#nullable restore
#line 24 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
                                Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 25 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n    <div style=\"float:right;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 749, 1);
#nullable restore
#line 28 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
WriteAttributeValue("", 708, Url.Content("~/ModuleManagement/Create"), 708, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><input type=""button"" name=""btnCreate"" value=""Add Module"" /></a>
    </div>
    
    <table width=""80%"" class=""table table-hover"">
        <thead class=""thead-dark"">
            <tr>
                <th>
                    Module
                </th>
                <th>
                    Fields
                </th>
                <th>
                    Roles
                </th>

                <th>
                    View
                </th>
                <th>
                </th>
            </tr>
        </thead>
");
#nullable restore
#line 51 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
         if (Model.Body.Count > 0)
        {
            foreach (var item in Model.Body)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 56 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
                   Write(item.ModuleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1541, "\"", 1653, 1);
#nullable restore
#line 58 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
WriteAttributeValue("", 1548, Url.Content("~/ModuleManagement/FieldsList?cid="+item.ID+"&tcode="+item.Tenant.Id +"&moduleId="+item.ID), 1548, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Field List</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1750, "\"", 1855, 1);
#nullable restore
#line 61 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
WriteAttributeValue("", 1757, Url.Content("~/ModuleManagement/AddRoleToModule?moduleid="+item.ID+"&tenantcode="+item.Tenant.Id), 1757, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Roles List</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1952, "\"", 2036, 1);
#nullable restore
#line 64 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
WriteAttributeValue("", 1959, Url.Content("~/ModuleManagement/Edit?cid="+item.ID+"&tcode="+item.Tenant.Id), 1959, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2129, "\"", 2213, 1);
#nullable restore
#line 68 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
WriteAttributeValue("", 2136, Url.Content("~/ModuleManagement/Edit?cid="+item.ID+"&tcode="+item.Tenant.Id), 2136, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2251, "\"", 2308, 1);
#nullable restore
#line 69 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
WriteAttributeValue("", 2258, Url.Content("~/ModuleManagement/Delete/"+item.ID), 2258, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you sure want to delete this module?\')\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"6\">\r\n                    No Modules Available\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 81 "C:\My Files\Freelancer Projects\SSOProject\SSOProject\SSOApp\Views\ModuleManagement\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SSOApp.Proxy.Response<List<SSOApp.API.ViewModels.ModuleViewModel>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
