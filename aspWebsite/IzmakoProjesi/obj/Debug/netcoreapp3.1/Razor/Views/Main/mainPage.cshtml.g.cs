#pragma checksum "C:\Users\Abdullah\OneDrive\Desktop\Izmako\IzmakoProjesi\IzmakoProjesi\Views\Main\mainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da0e33dbd6a78e28d1e02ba08864539dcdd04e5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_mainPage), @"mvc.1.0.view", @"/Views/Main/mainPage.cshtml")]
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
#line 1 "C:\Users\Abdullah\OneDrive\Desktop\Izmako\IzmakoProjesi\IzmakoProjesi\Views\_ViewImports.cshtml"
using IzmakoProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\OneDrive\Desktop\Izmako\IzmakoProjesi\IzmakoProjesi\Views\_ViewImports.cshtml"
using IzmakoProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0e33dbd6a78e28d1e02ba08864539dcdd04e5e", @"/Views/Main/mainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af6018bad860b751a972c193827725d30cb7f86", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_mainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Abdullah\OneDrive\Desktop\Izmako\IzmakoProjesi\IzmakoProjesi\Views\Main\mainPage.cshtml"
  
    ViewData["Title"] = "mainPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<header class=""slider-main"">
    <div id=""carouselExampleIndicators"" class=""carousel slide carousel-fade"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <!-- Slide One - Set the background image for this slide in the line below -->
            
            <div class=""carousel-item active"">
                <img src=""/images/slider-01.jpg"" />
                <div class=""carousel-caption d-none d-md-block"">
                    <h3>Sağlınız için temiz hava içeren bölgelerde kalın</h3>
                </div>
            </div>
            <!-- Slide Two - Set the background image for this slide in the line below -->
            <div class=""carou");
            WriteLiteral(@"sel-item"">
                <img src=""/images/slider-02.jpg"" />
                <div class=""carousel-caption d-none d-md-block"">
                    <h3>Yeşili Koruyalım</h3>
                </div>
            </div>
            <!-- Slide Three - Set the background image for this slide in the line below -->
            <div class=""carousel-item"">
                <img src=""/images/slider-03.jpg"" />
                <div class=""carousel-caption d-none d-md-block"">
                    <h3>Kirli havadan uzak duralım</h3>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""t");
            WriteLiteral(@"rue""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</header>




<div class=""container"">
    <div class=""services-bar"">
        <h1 class=""my-4"">Hizmetlerimiz...</h1>
    </div>
    <!-- About Section -->
    <div class=""about-main"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <h2>İZMAKO takımı olarak</h2>
                <p>Sağlığınızı korumak, güvenli ve temiz bölgelerde yerleşebilmeniz için </p> <br>
                <h5>Sonduğumuz hizmetler</h5> <br>
                <ul>
                    <li>Büyük oranda kirli hava içeren bölgeleri gösteren haritamız  </li>
                    <li>kirlilik grafiğikler ile birlikte belli zaman aralıklarla hava kirliğin değişimi görebilirsiniz</li>
                </ul> <br>
                <h5>Bu projeyi şimdilik sadece İstanbul ili ve ilçeleri kapsıyor.<br>En yakın zamanda tüm dünyayı kapsamış olacaktır.</h5>
            </div>
            <div class=""col-lg-6"">
                <");
            WriteLiteral("img class=\"img-fluid rounded\" src=\"/images/about-img.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3222, "\"", 3228, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
        </div>
    </div>
    <hr>
    <!-- Hemen bize ulaşın Section -->
    <div class=""col-md-4"">
        <a class=""btn btn-lg btn-secondary btn-block"" href=""bizeUlasin.html"">Hemen bize ulaşın</a>
    </div>
</div>
<br>
<!-- /.container -->
");
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
