#pragma checksum "/home/ta334/Codes/C#/Topics/Views/Topics/CreateTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a6722664f5d14d52158f718947e145ea459e300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_CreateTopic), @"mvc.1.0.view", @"/Views/Topics/CreateTopic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a6722664f5d14d52158f718947e145ea459e300", @"/Views/Topics/CreateTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694614a74030070705749d16b2d12efe32185fe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_CreateTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateTopicViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTopic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ta334/Codes/C#/Topics/Views/Topics/CreateTopic.cshtml"
  
	ViewData["Title"] = "Create a topic";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "/home/ta334/Codes/C#/Topics/Views/Topics/CreateTopic.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 6 "/home/ta334/Codes/C#/Topics/Views/Topics/CreateTopic.cshtml"
 if (!string.IsNullOrEmpty(Model.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<small class=\"text-danger\">");
#nullable restore
#line 8 "/home/ta334/Codes/C#/Topics/Views/Topics/CreateTopic.cshtml"
                          Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n");
#nullable restore
#line 9 "/home/ta334/Codes/C#/Topics/Views/Topics/CreateTopic.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a6722664f5d14d52158f718947e145ea459e3004953", async() => {
                WriteLiteral(@"
	<!-- authentication -->
	<input type=""hidden"" name=""user"" class=""username"" hidden>
	<input type=""hidden"" name=""token"" class=""token"" hidden>
	<!---->
	<input id=""title"" name=""title"" placeholder=""Type a title here"" class=""text-light form-control border-none bg-black-3""><br>
	<textarea id=""content"" placeholder=""Type the content of your topic here"" name=""content"" class=""text-light form-control border-none bg-black-3""></textarea>
	<br>
	<input name=""pwd"" type=""password"" placeholder=""Type password"" class=""text-light fit padding-sm border-none bg-black-3"">
	<br>
	<button class=""btn btn-primary"">Create</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br>
<button id=""preview-button"" class=""btn btn-primary"">Preview</button>
<br><br>
<div id=""preview"" style=""display:none"">
	<div class=""card bg-black-3 post rounded-corners"">
		<div class=""bg-black-3 card-title text-light padding-md rounded-corners"">
			<div class=""circular-landscape-md"" id=""pfp""></div>
			<p id=""preview-author"">the author</p>
			<b id=""preview-title"" class=""text-success"">the title</b><br>
			<small id=""date"" class=""text-secondary"">Just now</small>
		</div>
		<div class=""card-body bg-black-2b rounded-corners"">
			<p id=""preview-content"" class=""post-content"">
				
			</p>
		</div>
	</div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a6722664f5d14d52158f718947e145ea459e3007663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script src=\"/js/create-topic.js\" type=\"module\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateTopicViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
