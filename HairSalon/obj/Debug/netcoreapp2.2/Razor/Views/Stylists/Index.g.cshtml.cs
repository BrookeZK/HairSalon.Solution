#pragma checksum "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33c7aaf44939eafdbcba8180fee8038a1ad51265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Index.cshtml", typeof(AspNetCore.Views_Stylists_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c7aaf44939eafdbcba8180fee8038a1ad51265", @"/Views/Stylists/Index.cshtml")]
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 71, true);
            WriteLiteral("<h1>Stylists</h1>\n<h2><em>Select a Stylist for details</em></h2>\n\n<ul>\n");
            EndContext();
#line 8 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(131, 48, true);
            WriteLiteral("        <p>No Stylists have been added yet!</p>\n");
            EndContext();
#line 11 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(185, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 12 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
     if(Model.Count != 0)
    {
        

#line default
#line hidden
#line 14 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
         foreach (var stylist in Model)
        {

#line default
#line hidden
            BeginContext(267, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 281, "\"", 309, 2);
            WriteAttributeValue("", 288, "/stylists/", 288, 10, true);
#line 16 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
WriteAttributeValue("", 298, stylist.Id, 298, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(310, 22, true);
            WriteLiteral(" class=\"btn btn-dark\">");
            EndContext();
            BeginContext(333, 12, false);
#line 16 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
                                                            Write(stylist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(345, 9, true);
            WriteLiteral("</a><br>\n");
            EndContext();
#line 17 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
        }

#line default
#line hidden
#line 17 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(370, 282, true);
            WriteLiteral(@"</ul>

<form action=""/stylists/delete-stylists"" method=""post"">
    <button type=""submit"" class=""btn btn-dark"">Delete ALL stylists</button>
</form>
<h1><a href=""/stylists/new"" class=""btn btn-dark"">Add a new stylist</a></h1>
<a href=""/login"" class=""btn btn-dark"">Back to homepage</a>
");
            EndContext();
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
