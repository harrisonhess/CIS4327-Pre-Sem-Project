#pragma checksum "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Home\VolunteerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35f3212cecc3b7505aca5c48998b6d443247d039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VolunteerList), @"mvc.1.0.view", @"/Views/Home/VolunteerList.cshtml")]
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
#line 1 "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\_ViewImports.cshtml"
using Project_0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\_ViewImports.cshtml"
using Project_0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35f3212cecc3b7505aca5c48998b6d443247d039", @"/Views/Home/VolunteerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72415dbea9dd8d7ecf1b032512324e67eb29ecf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VolunteerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_0.Models.ViewModels.VolunteerListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Home\VolunteerList.cshtml"
 foreach (var p in Model.Volunteers)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Home\VolunteerList.cshtml"
Write(Html.Partial("VolunteerSummary", p));

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Home\VolunteerList.cshtml"
                                        
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("page-model", " page-model=\"", 151, "\"", 181, 1);
#nullable restore
#line 7 "C:\Users\Lan pc rx480\Source\Repos\CIS4327-Pre-Sem-Project\Project 0\Project 0\Views\Home\VolunteerList.cshtml"
WriteAttributeValue("", 164, Model.PagingInfo, 164, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" page-action=\"List\" page-classes-enabled=\"true\"\r\n    page-class=\"btn\" page-class-normal=\"btn-default\"\r\n    page-class-selected=\"btn-primary\" class=\"btngroup float-right\">\r\n    <h1 class=\"display-4\">Volunteers</h1>\r\n    <hr />\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_0.Models.ViewModels.VolunteerListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
