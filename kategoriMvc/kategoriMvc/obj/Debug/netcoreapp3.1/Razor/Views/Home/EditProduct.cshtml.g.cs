#pragma checksum "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3eee9f7ef0da0a4ffa8de81a94073059b5465bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditProduct), @"mvc.1.0.view", @"/Views/Home/EditProduct.cshtml")]
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
#line 1 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\_ViewImports.cshtml"
using kategoriMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\_ViewImports.cshtml"
using kategoriMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3eee9f7ef0da0a4ffa8de81a94073059b5465bf", @"/Views/Home/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7ca1419919659a758f06128499d587bd727b08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kategoriMvc.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
  
    ViewData["Title"] = "EditProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit ");
#nullable restore
#line 7 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
    Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<br />\r\n\r\n<h3>L??tfen sectiginiz ??r??n??n sadece ismini degistirin</h3>\r\n\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n");
#nullable restore
#line 16 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--html begin form sunu yap??yor asl??nda: -->\r\n            <!--<form method=\"Post\" action=\"~/admin/edit/1\"</form>-->\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"ProductId\" class=\"form-label\">Product Id</label>\r\n                <input type=\"text\" class=\"form-control\" required");
            BeginWriteAttribute("value", " value=\"", 649, "\"", 673, 1);
#nullable restore
#line 23 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
WriteAttributeValue("", 657, Model.ProductId, 657, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""ProductId"" id=""ProductId"" readonly=""readonly""/>
            </div>
            <div class=""form-group"">
                <label for=""CategoryId"" class=""form-label"">Category Id</label>
                <input type=""text"" class=""form-control"" required");
            BeginWriteAttribute("value", " value=\"", 932, "\"", 957, 1);
#nullable restore
#line 27 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
WriteAttributeValue("", 940, Model.CategoryId, 940, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CategoryId\" id=\"CategoryId\" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"ProductName\" class=\"form-label\">Product Name</label>\r\n                <input type=\"text\" class=\"form-control\" required");
            BeginWriteAttribute("value", " value=\"", 1201, "\"", 1227, 1);
#nullable restore
#line 31 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
WriteAttributeValue("", 1209, Model.ProductName, 1209, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"ProductName\" id=\"ProductName\" />\r\n            </div>\r\n");
            WriteLiteral("            <input type=\"hidden\" name=\"Id\" id=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 1341, "\"", 1367, 1);
#nullable restore
#line 34 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
WriteAttributeValue("", 1349, Model.ProductName, 1349, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"submit\" class=\"btn btn-success float-right\" value=\"Edit Product\" />\r\n            <!--float-right cal??smazsa style da float:rigth-->\r\n");
#nullable restore
#line 37 "C:\Users\SYM DMR\source\repos\kategoriMvc\kategoriMvc\Views\Home\EditProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kategoriMvc.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
