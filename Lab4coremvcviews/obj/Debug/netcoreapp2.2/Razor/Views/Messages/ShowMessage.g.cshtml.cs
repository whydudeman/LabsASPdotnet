#pragma checksum "/home/nurbol/dotNetCoreFirstProject/Lab4coremvcviews/Views/Messages/ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2624bdd8ff3ea378ed81d93dcf56f11478e131b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_ShowMessage), @"mvc.1.0.view", @"/Views/Messages/ShowMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/ShowMessage.cshtml", typeof(AspNetCore.Views_Messages_ShowMessage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2624bdd8ff3ea378ed81d93dcf56f11478e131b", @"/Views/Messages/ShowMessage.cshtml")]
    public class Views_Messages_ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/nurbol/dotNetCoreFirstProject/Lab4coremvcviews/Views/Messages/ShowMessage.cshtml"
  
    ViewData["Title"] = "ShowMessage";

#line default
#line hidden
            BeginContext(44, 24, true);
            WriteLiteral("\n<h1 class=\"title is-1\">");
            EndContext();
            BeginContext(69, 19, false);
#line 5 "/home/nurbol/dotNetCoreFirstProject/Lab4coremvcviews/Views/Messages/ShowMessage.cshtml"
                  Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 5, true);
            WriteLiteral("</h1>");
            EndContext();
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
