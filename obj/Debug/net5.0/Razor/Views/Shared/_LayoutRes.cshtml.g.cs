#pragma checksum "C:\MSSA\projects\MVCProject\Views\Shared\_LayoutRes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807a128ded285da09b8c28f82027daeaa2d3b347"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutRes), @"mvc.1.0.view", @"/Views/Shared/_LayoutRes.cshtml")]
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
#line 1 "C:\MSSA\projects\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MSSA\projects\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807a128ded285da09b8c28f82027daeaa2d3b347", @"/Views/Shared/_LayoutRes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f87f51910e1016d2b81c8d4107669623c21b1e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LayoutRes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807a128ded285da09b8c28f82027daeaa2d3b3473251", async() => {
                WriteLiteral("\r\n\r\n\t\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t    <title>");
#nullable restore
#line 6 "C:\MSSA\projects\MVCProject\Views\Shared\_LayoutRes.cshtml"
          Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

		<meta charset=""utf-8"">
		<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
		<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
		 <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

		<title>Restaurant HTML Template</title>

		<!-- Google font -->
		<link href=""https://fonts.googleapis.com/css?family=Quicksand:400,700%7CCabin:400%7CDancing+Script"" rel=""stylesheet"">

		<!-- Bootstrap -->
		<link type=""text/css"" rel=""stylesheet"" href=""css/bootstrap.min.css""/>

		<!-- Owl Carousel -->
		<link type=""text/css"" rel=""stylesheet"" href=""css/owl.carousel.css"" />
		<link type=""text/css"" rel=""stylesheet"" href=""css/owl.theme.default.css"" />

		<!-- Font Awesome Icon -->
		<link rel=""stylesheet"" href=""css/font-awesome.min.css"">

		<!-- Custom stlylesheet -->
		<link type=""text/css"" rel=""stylesheet"" href=""css/style.css""/>

		<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media quer");
                WriteLiteral(@"ies -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
		  <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
		  <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
		<![endif]-->

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807a128ded285da09b8c28f82027daeaa2d3b3475911", async() => {
                WriteLiteral(@"

		<!-- Header -->
		<header id=""header"">

			<!-- Top nav -->
			<div id=""top-nav"">
				<div class=""container"">

				<!-- logo -->
				<div class=""logo"">
					<a href=""index.html""><img src=""./img/logo.png"" alt=""logo""></a>
				</div>
				<!-- logo -->

				<!-- Mobile toggle -->
				<button class=""navbar-toggle"">
					<span></span>
				</button>
				<!-- Mobile toggle -->

				<!-- social links -->
				<ul class=""social-nav"">
					<li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
					<li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
					<li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
				</ul>
				<!-- /social links -->

				</div>
			</div>
			<!-- /Top nav -->

			<!-- Bottom nav -->
			<div id=""bottom-nav"">
				<div class=""container"">
				<nav id=""nav"">

					<!-- nav -->
					<ul class=""main-nav nav navbar-nav"">
						<li><a href=""index.html"">Home</a></li>
						<li><a href=""Reservation.html"">Reservation</a></li>
						<li><a href=""About.h");
                WriteLiteral(@"tml"">About</a></li>
						<!--<li><a href=""index.html#menu"">Menu</a></li>-->
						<!-- <li><a href=""index.html#gallery"">Gallery</a></li> -->
						<!--<li><a href=""index.html#events"">Events</a></li>-->
						<li><a href=""index.html#contact"">Contact</a></li>
					</ul>
					<!-- /nav -->

					<!-- button nav -->
					<ul class=""cta-nav"">
						<li><a href=""index.html#reservation"" class=""main-button"">Reserve</a></li>
					</ul>
					<!-- button nav -->

					<!-- contact nav -->
					<ul class=""contact-nav nav navbar-nav"">
						<li><a href=""tel:0455481497""><i class=""fa fa-phone""></i> 045-548-14-97</a></li>
						<li><a href=""#""><i class=""fa fa-map-marker""></i> 3685 Granville Lane</a></li>
					</ul>
					<!-- contact nav -->

				</nav>
				</div>
			</div>
			<!-- /Bottom nav -->


		</header>
		<!-- /Header -->
		 <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 112 "C:\MSSA\projects\MVCProject\Views\Shared\_LayoutRes.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

		<!-- Footer -->
		<footer id=""footer"">

			<!-- container -->
			<div class=""container"">

				<!-- row -->
				<div class=""row"">

					<!-- copyright -->
					<div class=""col-md-6"">
						<!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
						<span class=""copyright"">Copyright 2018 All rights reserved | This template is made with <i class=""fa fa-heart-o"" aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a></span>
						<!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
					</div>
					<!-- /copyright -->

					<!-- footer nav -->
					<div class=""col-md-6"">
						<nav class=""footer-nav"">
							<a href=""index.html"">Home</a>
							<a href=""index.html#about"">About</a>
							<a href=""index.html#menu"">Menu</a>
							<a href=""index.html#reservation"">Reservation</a>
							<a href=""index.html#events"">Events</a>
							<a href=""index.html#contact"">");
                WriteLiteral(@"Contact</a>
						</nav>
					</div>
					<!-- /footer nav -->

				</div>
				<!-- /row -->

			</div>
			<!-- /container -->

		</footer>
		<!-- /Footer -->

		<!-- Preloader -->
		<div id=""preloader"">
			<div class=""preloader"">
				<span></span>
				<span></span>
				<span></span>
			</div>
		</div>
		<!-- /Preloader -->

		<!-- jQuery Plugins -->
		<script type=""text/javascript"" src=""js/jquery.min.js""></script>
		<script type=""text/javascript"" src=""js/bootstrap.min.js""></script>
		<script type=""text/javascript"" src=""js/owl.carousel.min.js""></script>
		<script src=""https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false""></script>
		<script type=""text/javascript"" src=""js/google-map.js""></script>
		<script type=""text/javascript"" src=""js/main.js""></script>
		 ");
#nullable restore
#line 172 "C:\MSSA\projects\MVCProject\Views\Shared\_LayoutRes.cshtml"
    Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
