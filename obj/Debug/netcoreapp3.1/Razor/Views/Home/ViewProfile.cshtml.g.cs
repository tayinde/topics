#pragma checksum "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664fbb2706d84d573fb1f8279d35f861b3e5c42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewProfile), @"mvc.1.0.view", @"/Views/Home/ViewProfile.cshtml")]
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
#line 1 "/home/ta334/Codes/C#/Topics/Views/_ViewImports.cshtml"
using Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ta334/Codes/C#/Topics/Views/_ViewImports.cshtml"
using Topics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
using Topics.Database;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664fbb2706d84d573fb1f8279d35f861b3e5c42e", @"/Views/Home/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694614a74030070705749d16b2d12efe32185fe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
  
	ViewData["Title"] = Model.Username + "'s Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
 if (await Account.GetProperty(Model.Username, "user") != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\'text-center\'>\n\t\t<div id=\"pfp\" class=\"circular-landscape\"");
            BeginWriteAttribute("style", " style=\"", 242, "\"", 296, 4);
            WriteAttributeValue("", 250, "background-image:", 250, 17, true);
            WriteAttributeValue(" ", 267, "url(\'", 268, 6, true);
#nullable restore
#line 10 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
WriteAttributeValue("", 273, Model.ProfilePicture, 273, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 294, "\')", 294, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n\t\t<h1 class=\'quicksand\'>");
#nullable restore
#line 11 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
                         Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s profile</h1>\n\t</div>\n");
#nullable restore
#line 13 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<h1>The user \"");
#nullable restore
#line 16 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
             Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" was not found.</h1>\n");
#nullable restore
#line 17 "/home/ta334/Codes/C#/Topics/Views/Home/ViewProfile.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591