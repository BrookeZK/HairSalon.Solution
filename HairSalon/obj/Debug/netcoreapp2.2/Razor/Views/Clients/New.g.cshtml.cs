#pragma checksum "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b3f964434c545adaca9710b91d80ee35d687a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_New), @"mvc.1.0.view", @"/Views/Clients/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/New.cshtml", typeof(AspNetCore.Views_Clients_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3f964434c545adaca9710b91d80ee35d687a8e", @"/Views/Clients/New.cshtml")]
    public class Views_Clients_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 59, true);
            WriteLiteral("<h1>Stylists</h1>\n<h2><em>Add a new Client</em></h2>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 86, "\'", 126, 3);
            WriteAttributeValue("", 95, "/stylists/", 95, 10, true);
#line 7 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/New.cshtml"
WriteAttributeValue("", 105, Model.Id, 105, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 114, "/clients/new", 114, 12, true);
            EndWriteAttribute();
            BeginContext(127, 448, true);
            WriteLiteral(@" method='post'>
    <label for=""clientName"">Client name:</label>
    <input id=""clientName"" name=""clientName"" type=""text"">
    <label for=""serviceReq"">Requested service:</label>
    <input id=""serviceReq"" name=""serviceReq"" type=""text"">
    <label for=""appointment"">Appointment time and date:</label>
    <input id=""appointment"" name=""appointment"" type=""datetime-local"">
    <button type='submit' class=""btn btn-dark"">Add Client</button>
</form>

<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 575, "\"", 601, 2);
            WriteAttributeValue("", 582, "/stylists/", 582, 10, true);
#line 17 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Clients/New.cshtml"
WriteAttributeValue("", 592, Model.Id, 592, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(602, 195, true);
            WriteLiteral(" class=\"btn btn-dark\">Return to stylist info page</a>\n<a href=\"/stylists\" class=\"btn btn-dark\">Return to list of Stylists</a>\n<a href=\"/login\" class=\"btn btn-dark\">Return to homepage</a><br><br>\n");
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
