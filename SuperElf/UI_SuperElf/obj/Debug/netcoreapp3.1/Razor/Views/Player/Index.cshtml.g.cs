#pragma checksum "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f128d80cb49c103d65115228f35db1221d2351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
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
#line 1 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\_ViewImports.cshtml"
using UI_SuperElf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\_ViewImports.cshtml"
using UI_SuperElf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f128d80cb49c103d65115228f35db1221d2351", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bad20ef1103984486b485fcc6c5ed6404b011f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.1.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/v/dt/dt-1.11.3/datatables.min.css\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f128d80cb49c103d65115228f35db1221d23513961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.13/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#player_table').DataTable({
            });
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<h1>Players</h1>

<div class=""container"">
    <br />

    <table id=""player_table"" class=""display"" cellspacing=""0"" width=""100%"">
        <thead class=""table-borderless table-dark"" style=""background-color: rgb(0,142,68)"">
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Club
                </th>
                <th>
                    Position
                </th>
            </tr>
        </thead>
        <tbody class=""table table-bordered"">
            <tr>
                <td>
                    Joel Drommel
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Goalkeeper
                </td>
            </tr>
            <tr>
                <td>
                    Phillip Mwene
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Def");
            WriteLiteral(@"ender
                </td>
            </tr>
            <tr>
                <td>
                    André Ramalho
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Defender
                </td>
            </tr>
            <tr>
                <td>
                    Armando Obispo
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Defender
                </td>
            </tr>
            <tr>
                <td>
                    Olivier Boscagli
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Defender
                </td>
            </tr>
            <tr>
                <td>
                    Philip Max
                </td>
                <td>
                    PSV
                </td>
                <td>");
            WriteLiteral(@"
                    Defender
                </td>
            </tr>
            <tr>
                <td>
                    Ibrahim Sangaré
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Midfielder
                </td>
            </tr>
            <tr>
                <td>
                    Marco van Ginkel
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Midfielder
                </td>
            </tr>
            <tr>
                <td>
                    Davy Pröpper
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Midfielder
                </td>
            </tr>
            <tr>
                <td>
                    Mario Götze
                </td>
                <td>
                    PSV
           ");
            WriteLiteral(@"     </td>
                <td>
                    Midfielder
                </td>
            </tr>
            <tr>
                <td>
                    Ryan Thomas
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Midfielder
                </td>
            </tr>
            <tr>
                <td>
                    Eran Zahavi
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Attacker
                </td>
            </tr>
            <tr>
                <td>
                    Cody Gakpo
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Attacker
                </td>
            </tr>
            <tr>
                <td>
                    Noni Madueke
                </td>
                <td>
                ");
            WriteLiteral(@"    PSV
                </td>
                <td>
                    Attacker
                </td>
            </tr>
            <tr>
                <td>
                    Bruma
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Attacker
                </td>
            </tr>
            <tr>
                <td>
                    Yorbe Vertessen
                </td>
                <td>
                    PSV
                </td>
                <td>
                    Attacker
                </td>
            </tr>


        </tbody>
    </table>
</div>");
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
