#pragma checksum "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbd6b889e5a9b676d5b807f2e638de3075794575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
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
#line 1 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/_ViewImports.cshtml"
using PeopleViewer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/_ViewImports.cshtml"
using PeopleViewer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
using Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbd6b889e5a9b676d5b807f2e638de3075794575", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e3f61237cc01d7a1456badc3e932772c432fce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Commanders - ");
#nullable restore
#line 4 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<section>\r\n\r\n");
#nullable restore
#line 8 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
     foreach (Person person in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("data", " data=\"", 160, "\"", 203, 1);
#nullable restore
#line 10 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
WriteAttributeValue("", 167, person.StartDate.Year.ToString()[2], 167, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span class=\"name\">");
#nullable restore
#line 11 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
                          Write(person.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"year\">");
#nullable restore
#line 12 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
                          Write(person.StartDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"rating\">");
#nullable restore
#line 13 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
                            Write(person.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("/10 stars</span>\r\n        </div>\r\n");
#nullable restore
#line 15 "/Users/coppe/Interfaces/FutureProofing/PeopleViewer/Views/People/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591