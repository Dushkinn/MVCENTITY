#pragma checksum "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494409855162fcdc5ff2bbb90e7e231554e086e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Result), @"mvc.1.0.view", @"/Views/Calculator/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Result.cshtml", typeof(AspNetCore.Views_Calculator_Result))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494409855162fcdc5ff2bbb90e7e231554e086e4", @"/Views/Calculator/Result.cshtml")]
    public class Views_Calculator_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
     ViewData["Title"] = "Sum";

#line default
#line hidden
            BeginContext(89, 25, true);
            WriteLiteral("\r\n<h1 class=\"title is-1\">");
            EndContext();
            BeginContext(115, 18, false);
#line 7 "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml"
                  Write(ViewData["action"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 33, true);
            WriteLiteral("</h1>\r\n<h2 class=\"subtitle is-2\">");
            EndContext();
            BeginContext(167, 23, false);
#line 8 "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml"
                     Write(ViewData["firstNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(190, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(192, 16, false);
#line 8 "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml"
                                              Write(ViewData["mark"]);

#line default
#line hidden
            EndContext();
            BeginContext(208, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(210, 24, false);
#line 8 "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml"
                                                                Write(ViewData["secondNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(234, 4, true);
            WriteLiteral("  = ");
            EndContext();
            BeginContext(239, 18, false);
#line 8 "C:\Users\Damir\Desktop\178-SWD6-Microsoft-.NET-Framework--master\WebApplication1\Views\Calculator\Result.cshtml"
                                                                                             Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(257, 7, true);
            WriteLiteral("</h2>\r\n");
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