#pragma checksum "/home/pi/myApp/MyApp/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b551af30e94b09f5198b0353d24a8963e3a62f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 2 "/home/pi/myApp/MyApp/Views/_ViewImports.cshtml"
using MyApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/pi/myApp/MyApp/Views/_ViewImports.cshtml"
using MyApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b551af30e94b09f5198b0353d24a8963e3a62f0b", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"503c43722728a9220d296701c09042f131b914c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/pi/myApp/MyApp/Views/Home/Detail.cshtml"
   
    ViewBag.Title = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>학생정보</h2>\n<hr />\n<h3>아이디: ");
#nullable restore
#line 9 "/home/pi/myApp/MyApp/Views/Home/Detail.cshtml"
    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>이름: ");
#nullable restore
#line 10 "/home/pi/myApp/MyApp/Views/Home/Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>나이: ");
#nullable restore
#line 11 "/home/pi/myApp/MyApp/Views/Home/Detail.cshtml"
   Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>국적: ");
#nullable restore
#line 12 "/home/pi/myApp/MyApp/Views/Home/Detail.cshtml"
   Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
