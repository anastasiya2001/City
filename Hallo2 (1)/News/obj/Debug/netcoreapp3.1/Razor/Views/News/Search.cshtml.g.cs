#pragma checksum "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92d0d1c60f4964ea8ddc51eed13b6e569fd9046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Search), @"mvc.1.0.view", @"/Views/News/Search.cshtml")]
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
#line 1 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
using News.EF;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92d0d1c60f4964ea8ddc51eed13b6e569fd9046", @"/Views/News/Search.cshtml")]
    #nullable restore
    public class Views_News_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
  
    Layout = "Master.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<span>Найденные публикации по запросу:</span>\r\n");
#nullable restore
#line 7 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
 foreach (Publication p in ViewBag.Publications)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"trand-right-single d-flex\">\r\n                            <div class=\"trand-right-img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 363, 3);
            WriteAttributeValue("", 347, "/img/", 347, 5, true);
#nullable restore
#line 11 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
WriteAttributeValue("", 352, p.Id, 352, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 359, ".jpg", 359, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 364, "\"", 378, 1);
#nullable restore
#line 11 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
WriteAttributeValue("", 370, p.Title, 370, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"444\" height=\"350\">\r\n                            </div>\r\n                            <div class=\"trand-right-cap\">\r\n                                <span class=\"color1\">\r\n                                     <p>");
#nullable restore
#line 15 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
                                   Write(p.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 699, 2);
            WriteAttributeValue("", 678, "/News/NewShow/", 678, 14, true);
#nullable restore
#line 16 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
WriteAttributeValue("", 692, p.Path, 692, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 17 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
                                   Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </span>\r\n\r\n                                <h4>");
#nullable restore
#line 21 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
                               Write(p.Announce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>                        \r\n");
#nullable restore
#line 24 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
