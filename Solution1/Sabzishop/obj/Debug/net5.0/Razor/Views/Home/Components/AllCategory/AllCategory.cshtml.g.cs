#pragma checksum "D:\asp\project\Solution1\Sabzishop\Views\Home\Components\AllCategory\AllCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77049e4154d138002fb2d08d112b3453cc9df88a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_AllCategory_AllCategory), @"mvc.1.0.view", @"/Views/Home/Components/AllCategory/AllCategory.cshtml")]
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
#line 1 "D:\asp\project\Solution1\Sabzishop\Views\_ViewImports.cshtml"
using Sabzishop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp\project\Solution1\Sabzishop\Views\_ViewImports.cshtml"
using Sabzishop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77049e4154d138002fb2d08d112b3453cc9df88a", @"/Views/Home/Components/AllCategory/AllCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ee79912df66b11de8b28e6444956c4499a3620", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Components_AllCategory_AllCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sabzishop.Models.Category.Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	<!--top- category area start-->
	<section class=""top_category_product mb-70"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-2 col-md-3"">
					<div class=""top_category_header"">
						<h3>محبوب ترین دسته های این هفته</h3>
						<p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم</p>
						<a href=""shop.html"">نمایش همه دسته ها</a>
					</div>
				</div>
    <div class=""col-lg-10 col-md-9"">
        <div class=""top_category_container category_column5 owl-carousel"">
");
#nullable restore
#line 15 "D:\asp\project\Solution1\Sabzishop\Views\Home\Components\AllCategory\AllCategory.cshtml"
 foreach (var item in  Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-2\">\r\n        <article class=\"single_category\">\r\n            <figure>\r\n                <div class=\"category_thumb\">\r\n                    <a href=\"shop.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "77049e4154d138002fb2d08d112b3453cc9df88a4532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 772, "~/assets/img/s-product/", 772, 23, true);
#nullable restore
#line 21 "D:\asp\project\Solution1\Sabzishop\Views\Home\Components\AllCategory\AllCategory.cshtml"
AddHtmlAttributeValue("", 795, $"category{item.id}.jpg", 795, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div>\r\n                <figcaption class=\"category_name\">\r\n                    <h3><a href=\"shop.html\">");
#nullable restore
#line 24 "D:\asp\project\Solution1\Sabzishop\Views\Home\Components\AllCategory\AllCategory.cshtml"
                                       Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h3>\r\n                </figcaption>\r\n            </figure>\r\n        </article>\r\n    </div>\r\n");
#nullable restore
#line 29 "D:\asp\project\Solution1\Sabzishop\Views\Home\Components\AllCategory\AllCategory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sabzishop.Models.Category.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
