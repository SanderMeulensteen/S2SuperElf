#pragma checksum "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14bad239d926658832ef73dc54879674745bb732"
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
#nullable restore
#line 1 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
using Logic_SuperElf;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bad239d926658832ef73dc54879674745bb732", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bad20ef1103984486b485fcc6c5ed6404b011f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlayersPipeline>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.1.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Players";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/v/dt/dt-1.11.3/datatables.min.css\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bad239d926658832ef73dc54879674745bb7326189", async() => {
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
            var dt = $('#player_table').DataTable({
                ""paging"": false
            });
            $('#all').click(function() {
                dt.column(1).search('').draw();
                dt.column(2).search('').draw();
            });
            $('#all_positions').click(function () {
                dt.column(1).search('').draw();
            });
            $('#all_clubs').click(function () {
                dt.column(2).search('').draw();
            });
            $('#goalkeeper').click(function () {
                dt.column(1).search('Goalkeeper').draw();
            });
            $('#defender').click(function () {
                dt.column(1).search('Defender').draw();
            });
            $('#midfielder').click(function () {
                dt.column(1).search('Midfielder').draw();
 ");
                WriteLiteral(@"           });
            $('#forward').click(function () {
                dt.column(1).search('Forward').draw();
            });
            $('#ajax').click(function () {
                dt.column(2).search('ajax').draw();
            });
            $('#az').click(function () {
                dt.column(2).search('az').draw();
            });
            $('#cambuur').click(function () {
                dt.column(2).search('cambuur').draw();
            });
            $('#feyenoord').click(function () {
                dt.column(2).search('feyenoord').draw();
            });
            $('#fortuna').click(function () {
                dt.column(2).search('fortuna').draw();
            });
            $('#eagles').click(function () {
                dt.column(2).search('eagles').draw();
            });
            $('#groningen').click(function () {
                dt.column(2).search('groningen').draw();
            });
            $('#heerenveen').click(function () {
        ");
                WriteLiteral(@"        dt.column(2).search('heerenveen').draw();
            });
            $('#heracles').click(function () {
                dt.column(2).search('heracles').draw();
            });
            $('#nec').click(function () {
                dt.column(2).search('nec').draw();
            });
            $('#pec').click(function () {
                dt.column(2).search('pec').draw();
            });
            $('#psv').click(function () {
                dt.column(2).search('psv').draw();
            });
            $('#rkc').click(function () {
                dt.column(2).search('rkc').draw();
            });
            $('#sparta').click(function () {
                dt.column(2).search('sparta').draw();
            });
            $('#twente').click(function () {
                dt.column(2).search('twente').draw();
            });
            $('#utrecht').click(function () {
                dt.column(2).search('utrecht').draw();
            });
            $('#vitesse').clic");
                WriteLiteral("k(function () {\r\n                dt.column(2).search(\'vitesse\').draw();\r\n            });\r\n            $(\'#willem\').click(function () {\r\n                dt.column(2).search(\'willem\').draw();\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<h1>Players</h1>

<div class=""container"">
    <br />
    <button id=""all_positions"" style=""background-color: white; border-color: rgb(0, 142, 68)"">All</button>
    <button id=""goalkeeper"" style=""background-color: white; border-color: rgb(0,142,68)"">Goalkeepers</button>
    <button id=""defender"" style=""background-color: white; border-color: rgb(0,142,68)"">Defenders</button>
    <button id=""midfielder"" style=""background-color: white; border-color: rgb(0,142,68)"">Midfielders</button>
    <button id=""forward"" style=""background-color: white; border-color: rgb(0,142,68)"">Forwards</button>
    <br />
    <br />
    <button id=""all_clubs"" style=""background-color: white; border-color: rgb(0, 142, 68)""><img src=""/logo/eredivisie/eredivisie.png"" style=""width: 25px"" /></button>
");
#nullable restore
#line 108 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
     foreach (var club in Model.Clubs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button");
            BeginWriteAttribute("id", " id=\"", 4444, "\"", 4463, 1);
#nullable restore
#line 110 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
WriteAttributeValue("", 4449, club.clubName, 4449, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: white; border-color: rgb(0,142,68)\"><img");
            BeginWriteAttribute("src", " src=\"", 4530, "\"", 4548, 1);
#nullable restore
#line 110 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
WriteAttributeValue("", 4536, club.clubId, 4536, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 25px\" /></button>\r\n");
#nullable restore
#line 111 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <button id=""ajax"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/ajax.png"" style=""width: 25px"" /></button>
    <button id=""az"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/az.png"" style=""width: 25px"" /></button>
    <button id=""cambuur"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/cambuur.png"" style=""width: 25px"" /></button>
    <button id=""feyenoord"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/feyenoord.png"" style=""width: 25px"" /></button>
    <button id=""fortuna"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/fortuna.png"" style=""width: 25px"" /></button>
    <button id=""eagles"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/eagles.png"" style=""width: 25px"" /></button>
    <button id=""groningen"" style=""background-color: white; border-color: rgb(0,142,6");
            WriteLiteral(@"8)""><img src=""/logo/eredivisie/groningen.png"" style=""width: 25px"" /></button>
    <button id=""heerenveen"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/heerenveen.png"" style=""width: 25px"" /></button>
    <button id=""heracles"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/heracles.png"" style=""width: 25px"" /></button>
    <button id=""nec"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/nec.png"" style=""width: 25px"" /></button>
    <button id=""pec"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/pec.png"" style=""width: 25px"" /></button>
    <button id=""psv"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/psv.png"" style=""width: 25px"" /></button>
    <button id=""rkc"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/rkc.png"" style=""width: 25px"" /></button>
    <button id=");
            WriteLiteral(@"""sparta"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/sparta.png"" style=""width: 25px"" /></button>
    <button id=""twente"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/twente.png"" style=""width: 25px"" /></button>
    <button id=""utrecht"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/utrecht.png"" style=""width: 25px"" /></button>
    <button id=""vitesse"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/vitesse.png"" style=""width: 25px"" /></button>
    <button id=""willem"" style=""background-color: white; border-color: rgb(0,142,68)""><img src=""/logo/eredivisie/willem.png"" style=""width: 25px"" /></button>
    <br />
    <br />
    <table id=""player_table"" class=""display"">
        <thead class=""table-borderless table-dark"" style=""background-color: rgb(0,142,68)"">
            <tr>
                <th>
                    Name
                </th");
            WriteLiteral(">\r\n                <th>\r\n                    Position\r\n                </th>\r\n                <th>\r\n                    Club\r\n                </th>\r\n                <th style=\"width: 20%\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bad239d926658832ef73dc54879674745bb73216521", async() => {
                WriteLiteral("Add player");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody class=\"table table-bordered\">\r\n");
#nullable restore
#line 150 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
             foreach (var player in Model.Players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 154 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => player.playerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 157 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => player.position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 160 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
                         foreach (var club in Model.Clubs)
                        {
                            if (player.club == club.clubId)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => club.clubName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
                                                                            
                                break;
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bad239d926658832ef73dc54879674745bb73220085", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bad239d926658832ef73dc54879674745bb73221349", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14bad239d926658832ef73dc54879674745bb73222612", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 175 "C:\Users\sande\OneDrive\Documenten\GitHub\S2SuperElf\SuperElf\UI_SuperElf\Views\Player\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayersPipeline> Html { get; private set; }
    }
}
#pragma warning restore 1591
