#pragma checksum "C:\Users\CaT\Desktop\WebSite\WebSite\Views\SelectedAnnouncement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058e879438bb44938033fcbc88170e89deb3416d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SelectedAnnouncement_Index), @"mvc.1.0.view", @"/Views/SelectedAnnouncement/Index.cshtml")]
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
#line 1 "C:\Users\CaT\Desktop\WebSite\WebSite\Views\_ViewImports.cshtml"
using WebSite.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058e879438bb44938033fcbc88170e89deb3416d", @"/Views/SelectedAnnouncement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c382e581f6c20830de0aaa1d59ada0ca7b23eb3e", @"/Views/_ViewImports.cshtml")]
    public class Views_SelectedAnnouncement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Announcement>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Selected announcemest</h1>\r\n\r\n<form action=\"/\"><button class=\"btnHome\"><h2>All announcements</h2></button></form>\r\n\r\n<div class=\"Announcement mt-2\">\r\n    <div>\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\CaT\Desktop\WebSite\WebSite\Views\SelectedAnnouncement\Index.cshtml"
       Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 12 "C:\Users\CaT\Desktop\WebSite\WebSite\Views\SelectedAnnouncement\Index.cshtml"
   Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <div class=\"Label\">Date added: </div>\r\n        ");
#nullable restore
#line 16 "C:\Users\CaT\Desktop\WebSite\WebSite\Views\SelectedAnnouncement\Index.cshtml"
   Write(Model.dateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Announcement> Html { get; private set; }
    }
}
#pragma warning restore 1591
