#pragma checksum "D:\Work\Me\zhtv\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59f1ba76cc9a33845b6002611d8c8ba96682093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Work\Me\zhtv\Views\_ViewImports.cshtml"
using zhtv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Me\zhtv\Views\_ViewImports.cshtml"
using zhtv.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59f1ba76cc9a33845b6002611d8c8ba96682093", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22bddddc7db18293b74562c8442f25b917960f26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<zhtv.Models.OrderInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var songData = ViewData["SongData"] as List<Song>;
    var playing = ViewData["Playing"] as Song;
    var nextSongs = ViewData["NextSongs"] as List<Song>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <p><b>Danh sách bài hát:</b></p>\r\n");
#nullable restore
#line 11 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
     foreach (var song in songData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"margin-bottom: 4px;\">");
#nullable restore
#line 13 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                                  Write(song.SongId);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 13 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                                                Write(song.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                                                             Write(song.Singer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><b>Bài Đang phát:</b> ");
#nullable restore
#line 15 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                              if (playing.SongId != 0)
        {
            string.Format("$0: $1 - $2", playing.SongId, playing.Name, playing.Singer);
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n    <p><b>Danh sách chờ:</b></p>\r\n");
#nullable restore
#line 21 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
     foreach (var song in nextSongs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 23 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
      Write(song.SongId);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 23 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                    Write(song.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                                 Write(song.Singer);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 23 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                                               Write(song.UserOrders.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vote (");
#nullable restore
#line 23 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                                                                            Write(string.Join(", ", song.UserOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n");
#nullable restore
#line 24 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br />\r\n<hr />\r\n<br />\r\n<div>\r\n");
#nullable restore
#line 30 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
     using (Html.BeginForm("AddOrder", "Home"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><label>User</label>：");
#nullable restore
#line 32 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                            Write(Html.TextBoxFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 33 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><label>SongId</label>：");
#nullable restore
#line 34 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
                              Write(Html.TextBoxFor(model => model.SongId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 35 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(model => model.SongId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <button type=\"submit\">Order</button>\r\n");
#nullable restore
#line 38 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"button\" value=\"Play next song\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1292, "\"", 1353, 3);
            WriteAttributeValue("", 1302, "location.href=\'", 1302, 15, true);
#nullable restore
#line 39 "D:\Work\Me\zhtv\Views\Home\Index.cshtml"
WriteAttributeValue("", 1317, Url.Action("PlayNextSong", "Home"), 1317, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1352, "\'", 1352, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<zhtv.Models.OrderInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
