#pragma checksum "C:\Users\joshy\Source\Repos\harrisonhess\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f207ce4f1efcdc89fbbc842a958493ec8c3c38c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\joshy\Source\Repos\harrisonhess\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\_ViewImports.cshtml"
using Project_0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshy\Source\Repos\harrisonhess\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\_ViewImports.cshtml"
using Project_0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f207ce4f1efcdc89fbbc842a958493ec8c3c38c", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72415dbea9dd8d7ecf1b032512324e67eb29ecf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Administrator Management</h1>\r\n    <hr />\r\n    <h3>Volunteers</h3>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 127, "\"", 165, 1);
#nullable restore
#line 5 "C:\Users\joshy\Source\Repos\harrisonhess\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Admin\Index.cshtml"
WriteAttributeValue("", 134, Url.Action("ManageVolunteers"), 134, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"elements\"><span>View and manage volunteers</span></a>\r\n    <hr />\r\n    <h3>Opportunities</h3>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 275, "\"", 316, 1);
#nullable restore
#line 8 "C:\Users\joshy\Source\Repos\harrisonhess\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Admin\Index.cshtml"
WriteAttributeValue("", 282, Url.Action("ManageOpportunities"), 282, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"elements\"><span>View and manage opportunities</span></a>\r\n</div>\r\n");
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
