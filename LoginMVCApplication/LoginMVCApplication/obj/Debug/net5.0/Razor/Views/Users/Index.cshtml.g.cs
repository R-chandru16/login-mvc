#pragma checksum "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d59997ec19b7b972ea20eedae91b68c9d2ead78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\_ViewImports.cshtml"
using LoginMVCApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\_ViewImports.cshtml"
using LoginMVCApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d59997ec19b7b972ea20eedae91b68c9d2ead78f", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784427786193ef94c56eb99612b04129a388f52b", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginMVCApplication.Models.Users>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59997ec19b7b972ea20eedae91b68c9d2ead78f3599", async() => {
                WriteLiteral(@"
    <title>Login</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet""
          href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <style>
        .row {
            width: 300px;
            margin: 70px auto;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59997ec19b7b972ea20eedae91b68c9d2ead78f5133", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <h1>LOGIN FORM</h1>\r\n");
#nullable restore
#line 30 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
                 using (Html.BeginForm("Index", "Users", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
               Write(Html.LabelFor(e => e.EmailID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
               Write(Html.EditorFor(e => e.EmailID, new
                    {
                        htmlAttributes =
                    new { @class = "form-control", @type = "email", @placeholder = "Email" }
                    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
               Write(Html.LabelFor(e => e.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
               Write(Html.EditorFor(e => e.Password, new
                    {
                        htmlAttributes =
                    new
                    {
                        @class = "form-control",
                        @type = "password",
                        @placeholder =
                    "Password"
                    }
                    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\" style=\"margin-top:10px;\">\r\n                        <input type=\"submit\" value=\"Login\" class=\"btn btn-primary\" />\r\n                        <p>");
#nullable restore
#line 52 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
                      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 54 "D:\LoginMVCApplication\LoginMVCApplication\LoginMVCApplication\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginMVCApplication.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
