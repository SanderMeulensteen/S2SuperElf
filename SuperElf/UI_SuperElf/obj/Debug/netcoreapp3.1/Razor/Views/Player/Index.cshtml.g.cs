#pragma checksum "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eacd5cbd3a34288b8738fab08cc42677278bb87"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eacd5cbd3a34288b8738fab08cc42677278bb87", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bad20ef1103984486b485fcc6c5ed6404b011f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral(@"
<h1>Players</h1>

<div class=""container"">
    <br />

    <table id=""player_table"" class=""table"">
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
                    Defender
                </td>
            </tr>
            <tr>
        ");
            WriteLiteral(@"        <td>
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
                <td>
                    Defender
                </td>
            </tr>
 ");
            WriteLiteral(@"           <tr>
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
                </td>
                <td>
                    Midfielder
         ");
            WriteLiteral(@"       </td>
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
                PSV
            </td>
            <td>
                Attacker
            </td>
        </tr>
        <tr>
            <td>
     ");
            WriteLiteral(@"           Bruma
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
</div>

<script>
    $(document).ready(function() {
        $(""#player_table"").DataTable({
            ""processing"": true,
            ""filter"": true,
            ""orderMulti"": false,
        });
    });
</script>");
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
