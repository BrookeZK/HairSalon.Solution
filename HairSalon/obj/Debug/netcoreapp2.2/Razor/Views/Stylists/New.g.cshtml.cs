#pragma checksum "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac022bacd788ab31178b88989ab05c4afcc1eb9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_New), @"mvc.1.0.view", @"/Views/Stylists/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/New.cshtml", typeof(AspNetCore.Views_Stylists_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac022bacd788ab31178b88989ab05c4afcc1eb9c", @"/Views/Stylists/New.cshtml")]
    public class Views_Stylists_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Brooke/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 668, true);
            WriteLiteral(@"<h1>Stylists</h1>
<h2><em>Add a new Stylist</em></h2>

<form action='/stylists' method='post'>
    <label for=""stylistName"">Stylist name:</label>
    <input id=""stylistName"" name=""stylistName"" type=""text"">
    <label for=""yearsExperience"">Years of Experience:</label>
    <input id=""yearsExperience"" name=""yearsExperience"" type=""number"">
    <label for=""workDays"">Days available to work:</label>
    <input id=""workDays"" name=""workDays"" type=""text"">
    <button type='submit' class=""btn btn-dark"">Add Stylist</button>
</form>

<a href=""/stylists"" class=""btn btn-dark"">Return to list of Stylists</a>
<a href=""/login"" class=""btn btn-dark"">Return to homepage</a><br><br>
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
