#pragma checksum "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3ad9c6c3df2bc3de6bcea57272256f9fac8c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_ViewTopic), @"mvc.1.0.view", @"/Views/Topics/ViewTopic.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
using static Topics.Database.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3ad9c6c3df2bc3de6bcea57272256f9fac8c87", @"/Views/Topics/ViewTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694614a74030070705749d16b2d12efe32185fe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_ViewTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewTopicViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("verify"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("md-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
  
	try { ViewData["Title"] = Model.TopicData["title"]; }
	catch {}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
 if (Model.TopicData["result"] == "error")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<script>window.location.href = \'/Home/SignIn\';</script>\n");
#nullable restore
#line 13 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
} else
{
	var author = Model.TopicData["author"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"card bg-black-3 post rounded-corners\">\n\t\t<div class=\"bg-black-3 card-title text-light padding-md rounded-corners\">\n\t\t\t<div class=\"circular-landscape-md\"");
            BeginWriteAttribute("style", " style=\"", 494, "\"", 562, 4);
            WriteAttributeValue("", 502, "background-image:", 502, 17, true);
            WriteAttributeValue(" ", 519, "url(\'", 520, 6, true);
#nullable restore
#line 18 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 525, Model.TopicData["profile_picture"], 525, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 560, "\')", 560, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n\t\t\t<p><a class=\'text-light\'");
            BeginWriteAttribute("href", " href=\'", 598, "\'", 635, 2);
            WriteAttributeValue("", 605, "/Home/ViewProfile?user=", 605, 23, true);
#nullable restore
#line 19 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 628, author, 628, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                                                                      Write(author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n\t\t\t<b class=\"text-success\">");
#nullable restore
#line 20 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                               Write(Model.TopicData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br>\n\t\t\t<small class=\"text-secondary\">");
#nullable restore
#line 21 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                                     Write(Model.TopicData["date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n\t\t</div>\n\t\t<div class=\"card-body bg-black-2b rounded-corners\">\n\t\t\t<p id=\"0\" class=\"post-content\">\n\t\t\t\t");
#nullable restore
#line 25 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
           Write(Model.TopicData["content"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t</p>\n\t\t</div>\n\t</div>\n\t<br>\n\t<p>\n\t\t");
#nullable restore
#line 31 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
   Write(Model.Comments.LongCount());

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments\n");
#nullable restore
#line 32 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
         if (Model.Comments.LongCount() > 0)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<small class=\"text-secondary\"> • Last comment on ");
#nullable restore
#line 34 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                                                        Write(Model.Comments[0]["date"].AsString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n");
#nullable restore
#line 35 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</p>\n\t<br>\n");
#nullable restore
#line 38 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
	int i = 0;
	foreach (BsonDocument document in @Model.Comments)
	{
		i++;
		if (!(await GetProperty(document["author"].AsString, "user") == ""))
		{
			var comment_author = document["author"].AsString;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div");
            BeginWriteAttribute("id", " id=\"", 1349, "\"", 1382, 1);
#nullable restore
#line 45 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 1354, document["author"].AsString, 1354, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card post bg-black-3 rounded-borders\">\n\t\t\t\t<div>\n\t\t\t\t\t<div class=\"card-body bg-black-3 rounded-corners \">\n\t\t\t\t\t\t<div class=\"circular-landscape-sm\"");
            BeginWriteAttribute("style", " style=\"", 1537, "\"", 1636, 4);
            WriteAttributeValue("", 1545, "background-image:", 1545, 17, true);
            WriteAttributeValue(" ", 1562, "url(\'", 1563, 6, true);
#nullable restore
#line 48 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 1568, await GetProperty(document["author"].AsString, "profile_picture"), 1568, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1634, "\')", 1634, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n\t\t\t\t\t\t<p><a class=\'text-light\'");
            BeginWriteAttribute("href", " href=\'", 1675, "\'", 1720, 2);
            WriteAttributeValue("", 1682, "/Home/ViewProfile?user=", 1682, 23, true);
#nullable restore
#line 49 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 1705, comment_author, 1705, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                                                                                          Write(comment_author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><small class=\"text-secondary\"> • ");
#nullable restore
#line 49 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                                                                                                                                              Write(document["date"].AsString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n\t\t\t\t\t\t<p");
            BeginWriteAttribute("id", " id=\"", 1821, "\"", 1828, 1);
#nullable restore
#line 50 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 1826, i, 1826, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-content\">");
#nullable restore
#line 50 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
                                                   Write(document["content"].AsString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t\t<br>\n");
#nullable restore
#line 55 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
		}
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br>\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e3ad9c6c3df2bc3de6bcea57272256f9fac8c8712845", async() => {
                WriteLiteral("\n\t\t<textarea id=\"content\" name=\"comment\" placeholder=\"Type a comment\" class=\"form-control bg-black-3 border-none\"></textarea>\n\t\t<input name=\"user\" class=\"username\" hidden>\n\t\t<input name=\"token\" class=\"token\" hidden>\n\t\t<input name=\"topicId\"");
                BeginWriteAttribute("value", " value=\"", 2270, "\"", 2300, 1);
#nullable restore
#line 62 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
WriteAttributeValue("", 2278, Model.TopicData["id"], 2278, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden>
		<br>
		<button class=""btn btn-primary"">Comment</button>
		<button type=""button"" id=""preview-button"" class=""btn btn-primary"">Preview</button>
		<br><br>
		<div style=""display:none"" id=""preview-area"" class=""card post bg-black-3 rounded-borders"">
			<div>
				<div class=""card-body bg-black-3 rounded-corners "">
					<div id=""pfp"" class=""circular-landscape-sm""></div>
					<p id=""preview-author""><small class=""text-secondary"">• Just now</small></p>
					<p id=""preview-content"" class=""post-content""> </p>
				</div>
			</div>
		</div>
	");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 58 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e3ad9c6c3df2bc3de6bcea57272256f9fac8c8716251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t<script src=\"/js/view-topic.js\" type=\"module\"></script>\n");
#nullable restore
#line 79 "/home/ta334/Codes/C#/Topics/Views/Topics/ViewTopic.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewTopicViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
