#pragma checksum "C:\Users\Ilkin\Desktop\PassStrongChecker\PassStrongChecker\Views\Password\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d532d4201a3e2e813415071b7cf133ecb2e1996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Password_Check), @"mvc.1.0.view", @"/Views/Password/Check.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d532d4201a3e2e813415071b7cf133ecb2e1996", @"/Views/Password/Check.cshtml")]
    public class Views_Password_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ilkin\Desktop\PassStrongChecker\PassStrongChecker\Views\Password\Check.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d532d4201a3e2e813415071b7cf133ecb2e19962964", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Check</title>
    <style>
        .visibility{
            display:block !important;
        }
        .formgroup .indicators {
            width: 250px;
            display: flex;
            justify-content: space-between;
            margin-top: 5px;
        }

        .formgroup .indicators .low, .medium, .strong {
            height: 10px;
            border-radius: 5px;
            width: 80px;
            display:none;
        }

        .formgroup .indicators .low {
            background-color: #FF0000;
            border: thin solid #fff;
        }

        .formgroup .indicators .medium {
            background-color: #E5FF00;
            border: thin solid #ffffff;
        }

        .formgroup .indicators .strong {
            background-color: rgb(81, 255, 0);
            border: thin solid #51FF00;
        }

        .formgroup .inputgroup {
            width: 250px;
        }

        ");
                WriteLiteral(".formgroup .inputgroup input {\r\n            padding: 5px;\r\n            width: 100%;\r\n            border: thin solid silver;\r\n            border-radius: 5px;\r\n            outline: none;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d532d4201a3e2e813415071b7cf133ecb2e19965217", async() => {
                WriteLiteral(@"
    <div class=""formgroup"">
        <div class=""inputgroup"">
            <input type=""text"" id=""pass"">
        </div>
        <div class=""indicators"">
            <div class=""low""></div>
            <div class=""medium""></div>
            <div class=""strong""></div>
        </div>
    </div>

    <script>
        let input = document.querySelector(""#pass"");

        input.addEventListener('keyup', function () {
            let strong = document.querySelector('.strong');
            let medium = document.querySelector('.medium');
            let low = document.querySelector('.low');
            let password = this.value;
            const req = new XMLHttpRequest();
            req.open(""Post"", ""/Password/CheckPasswordStrong?password="" + password, true);
            req.send(JSON.stringify(password));
            req.onreadystatechange = function () {
                if (req.readyState == 4 && req.status == 200) {
                    var resObj = JSON.parse(this.responseText);
        ");
                WriteLiteral(@"            console.log(resObj);

                    if (resObj.count == 0) {
                        let allVisibility = document.querySelectorAll('.visibility');

                        for (var i = 0; i < allVisibility.length; i++) {
                            allVisibility[i].classList.remove('visibility');
                        }
                    }

                    if (resObj.count == 4) {
                        strong.classList.add('visibility');
                    }

                    if (resObj.count < 4) {
                        strong.classList.remove('visibility');
                    }

                    if (resObj.count == 2) {
                        low.classList.add('visibility');
                    }

                    if (resObj.count < 2) {
                        low.classList.remove('visibility');
                    }

                    if (resObj.count == 3) {
                        medium.classList.add('visibility');
                ");
                WriteLiteral("    }\r\n\r\n                    if (resObj.count < 3) {\r\n                        medium.classList.remove(\'visibility\');\r\n                    }\r\n                   \r\n                }\r\n            }\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
