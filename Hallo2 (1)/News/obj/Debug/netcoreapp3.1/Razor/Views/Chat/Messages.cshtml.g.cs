#pragma checksum "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\Chat\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85724027606276af6c21b529f92ecde2b04e807e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Messages), @"mvc.1.0.view", @"/Views/Chat/Messages.cshtml")]
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
#line 1 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\Chat\Messages.cshtml"
using News.EF;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85724027606276af6c21b529f92ecde2b04e807e", @"/Views/Chat/Messages.cshtml")]
    #nullable restore
    public class Views_Chat_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\Chat\Messages.cshtml"
 foreach (ChatMessage message in ViewBag.Messages) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 3 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\Chat\Messages.cshtml"
  Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 4 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\Chat\Messages.cshtml"
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
