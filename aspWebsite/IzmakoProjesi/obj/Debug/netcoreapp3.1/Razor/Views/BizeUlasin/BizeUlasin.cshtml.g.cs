#pragma checksum "C:\Users\berkc\Desktop\IzmakoWebsite\aspWebsite\IzmakoProjesi\Views\BizeUlasin\BizeUlasin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3a6f7126baea7904d7e7f31369c94d5b58584f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BizeUlasin_BizeUlasin), @"mvc.1.0.view", @"/Views/BizeUlasin/BizeUlasin.cshtml")]
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
#line 1 "C:\Users\berkc\Desktop\IzmakoWebsite\aspWebsite\IzmakoProjesi\Views\_ViewImports.cshtml"
using IzmakoProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\berkc\Desktop\IzmakoWebsite\aspWebsite\IzmakoProjesi\Views\_ViewImports.cshtml"
using IzmakoProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3a6f7126baea7904d7e7f31369c94d5b58584f", @"/Views/BizeUlasin/BizeUlasin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af6018bad860b751a972c193827725d30cb7f86", @"/Views/_ViewImports.cshtml")]
    public class Views_BizeUlasin_BizeUlasin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<div class=""container"" style=""font-size: 14px;"">
    <div class=""row p-5"">
        <div class=""col-6"">
            <h4 style=""color:rgb(0, 167, 0) ; ""><ins>Hakkımızda</ins></h4>
            <p>Berkcan BİLÇER 192802008 (1.Öğretim)</p>
            <p>Abdullah OBAİD 182803001 (2.Öğretim)</p>
            <p>Mahmud Elseyyid ÖMER 192802066 (1.Öğretim)</p>
            <p>Serkan KURT 192803016 (2.Öğretim)</p>

            <h3 style=""color:rgb(0, 167, 0)"">  <ins>Bize Ulaşın</ins></h3>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa3a6f7126baea7904d7e7f31369c94d5b58584f4111", async() => {
                WriteLiteral(@"
                <input class=""form-group"" type=""text"" name=""name"" placeholder=""İsim "" />
                <input class=""form-group"" type=""text"" name=""name"" placeholder=""Soyisim"" /><br>
                <input class=""form-group"" type=""text"" name=""email"" placeholder=""E-Posta"" /><br><br>
                <textarea class=""form-group"" type=""text"" name=""message"" placeholder=""Mesaj"" rows=""5"" style=""width: 158px;""></textarea><br>
                <button id=""submit"" type=""submit"" class=""btn btn-success"">Gönder</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




        </div>

        <div class=""col-6"">
            <h4 class=""second-text text-center"">Our Address</h4>
            <div id=""mapid"" style=""height: 342px; border:2px solid #ff8d2c"">
                <script>
                    var mymap = L.map('mapid').setView([38.491774, 27.706417], 13);
                    L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token=pk.eyJ1IjoiYWJkdWxsYWhvYiIsImEiOiJja2pqdnpleTY1bjlzMnlsZ3Q4cms2c3F4In0.ZpEx65D0Js2seKqJ6wPurA', {
                        attribution: 'Map data &copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
                        maxZoom: 18,
                        id: 'mapbox/streets-v11',
                        tileSize: 512,
                        zoomOffset: -1,
                        accessToken: 'your.mapbox.access.token'
                    }).addTo(mymap);
                    var marker = L.marker([3");
            WriteLiteral(@"8.491774, 27.706417]).addTo(mymap);
                    marker.bindPopup(""<b>Bizim Adresimiz Bu</b><br>Açık 9AM-10AM -Except Cumartesi & Pazar."").openPopup();

                </script>



            </div>

        </div>

        <script type=""text/javascript"" charset=""utf-8"">
            (function (w, d, t, f) {
                w[f] = w[f] || function (c, k, n) {
                    s = w[f], k = s['k'] = (s['k'] || (k ? ('&k=' + k) : '')); s['c'] =
                        c = (c instanceof Array) ? c : [c]; s['n'] = n = n || 0; L = d.createElement(t), e = d.getElementsByTagName(t)[0];
                    L.async = 1; L.src = '//feed.aqicn.org/feed/' + (c[n].city) + '/' + (c[n].lang || '') + '/feed.v1.js?n=' + n + k;
                    e.parentNode.insertBefore(L, e);
                };
            })(window, document, 'script', '_aqiFeed');
        </script>
        <span id=""city-aqi-container""></span>

        <script type=""text/javascript"" charset=""utf-8"">
            _aqiFeed");
            WriteLiteral("({ container: \"city-aqi-container\", city: \"Istanbul\" });\r\n        </script>\r\n    </div>\r\n    \r\n</div>");
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
