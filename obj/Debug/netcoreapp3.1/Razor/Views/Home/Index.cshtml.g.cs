#pragma checksum "/Users/yusifnazarbayov/Desktop/EduHome-BE/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ee1fe7b8e3ac76a3c52918dc72a2cab616eea87"
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
#line 2 "/Users/yusifnazarbayov/Desktop/EduHome-BE/Views/_ViewImports.cshtml"
using EduHome_BE.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/yusifnazarbayov/Desktop/EduHome-BE/Views/Home/Index.cshtml"
using EduHome_BE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ee1fe7b8e3ac76a3c52918dc72a2cab616eea87", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ba78dbb5bb6a6c44af824ddbebbfa956ad7462", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slider>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- Background Area Start -->\n<section id=\"slider-container\" class=\"slider-area\">\n    <div class=\"slider-owl owl-theme owl-carousel\">\n        <!-- Start Slingle Slider -->\n");
#nullable restore
#line 7 "/Users/yusifnazarbayov/Desktop/EduHome-BE/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 315, "\"", 371, 4);
            WriteAttributeValue("", 323, "background-image:", 323, 17, true);
            WriteAttributeValue(" ", 340, "url(img/slider/", 341, 16, true);
#nullable restore
#line 9 "/Users/yusifnazarbayov/Desktop/EduHome-BE/Views/Home/Index.cshtml"
WriteAttributeValue("", 356, item.ImageUrl, 356, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 370, ")", 370, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-7 col-md-offset-left-5"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content"">
                                        <h3>EDUCATION MAKES</h3>
                                        <h2>PROPER HUMANITY </h2>
                                        <p>I must explain to you how all this mistaken idea of denouncing pleasure and prsing pain was born and I will give you a complete account of the system  </p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            ");
            WriteLiteral("    <!-- End Slider Content -->\n            </div>\n");
#nullable restore
#line 29 "/Users/yusifnazarbayov/Desktop/EduHome-BE/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- End Slingle Slider -->
    </div>
</section>
<!-- Background Area End -->
<!-- Notice Start -->
<section class=""notice-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left"">
                    <h3>notice board</h3>
                    <div class=""single-notice-left mb-25 pb-25"">
                        <h4>5, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left mb-25 pb-25"">
                        <h4>4, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left pb-75"">
                      ");
            WriteLiteral(@"  <h4>3, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left mb-25 pb-25"">
                        <h4>5, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left mb-25 pb-25"">
                        <h4>4, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left pb-70"">
                        <h4>3, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praisin");
            WriteLiteral(@"g pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left mb-25 pb-25"">
                        <h4>5, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left mb-25 pb-25"">
                        <h4>4, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                    <div class=""single-notice-left pb-70"">
                        <h4>3, June 2017</h4>
                        <p>I must explain to you how all this mistaken idea of denouncing plasure and praising pain was born and I will give you a complete </p>
                    </div>
                </div>
            </div>
            ");
            WriteLiteral(@"<div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right"">
                    <div class=""single-notice-right mb-25 pb-25"">
                        <h3>PROFESSIONAL TEACHER</h3>
                        <p>I must explain to you how all this mistaken idea of denouncing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings </p>
                    </div>
                    <div class=""single-notice-right mb-25 pb-25"">
                        <h3>Online courses</h3>
                        <p>I must explain to you how all this mistaken idea of denouncing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings </p>
                    </div>
                    <div class=""single-notice-right"">
                        <h3>easy to addmission</h3>
                        <p>I must explain to you how all this mistaken idea of denouncing pleure and praising pai");
            WriteLiteral(@"n was born and I will give you a complete account of the system, and expound the actual teachings </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- Choose Start -->
<section class=""choose-area pb-85 pt-77"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4"">
                <div class=""choose-content text-left"">
                    <h2>WHY YOU CHOOSE EDUHOME ?</h2>
                    <p>I must explain to you how all this mistaken idea of denouncing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because. </p>
                    <p class=""choose-option"">I must explain to you how all this mistaken idea of denouncing pleure and praising pain was b");
            WriteLiteral(@"orn and I will give you a complete account of the system, and expound the actual teachings  the master-builder. </p>
                    <a class=""default-btn"" href=""course-details.html"">view courses</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Choose Area End -->
<!-- Courses Area Start -->
<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>COURSES WE OFFER</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course1.jpg"" alt=""course"">
                            <div");
            WriteLiteral(@" class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
                    </div>
                    <div class=""course-content"">
                        <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                        <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course2.jpg"" alt=""course"">
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                     ");
            WriteLiteral(@"       </div>
                        </a>
                    </div>
                    <div class=""course-content"">
                        <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                        <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 hidden-sm col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course3.jpg"" alt=""course"">
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
                    </div>
                    <div class=""");
            WriteLiteral(@"course-content"">
                        <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                        <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Event Area Start -->
<div class=""event-area one text-center pt-140 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-sm-12 col-xs-12"">
                <div class=""single-event mb-35"">
                    <div class=""ev");
            WriteLiteral(@"ent-date"">
                        <h3><a href=""event-details.html"">20 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">MICRO BIOLOGICAL WORKSHOP</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event mb-35"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">18 <span>June</span></a></h3>
    ");
            WriteLiteral(@"                </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">ADVANCE PHP WORKSHOP</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event mb-35"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">16 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <d");
            WriteLiteral(@"iv class=""event-content-left"">
                            <h4><a href=""event-details.html"">LEARN ENGLISH HISTORY</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">14 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">GLOBAL ECONOMIC CONF");
            WriteLiteral(@"ERENCE</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 hidden-sm hidden-xs"">
                <div class=""single-event mb-35"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">12 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">MATHEMATICAL WORKSHOP</a></h4>
                ");
            WriteLiteral(@"            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event mb-35"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">10 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">WORDPRESS AUTHOR MEET UP</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li");
            WriteLiteral(@">
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event mb-35"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">08 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">DIGITAL MARKETING ANALYSIS</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
           ");
            WriteLiteral(@"                 </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
                <div class=""single-event"">
                    <div class=""event-date"">
                        <h3><a href=""event-details.html"">06 <span>June</span></a></h3>
                    </div>
                    <div class=""event-content text-left"">
                        <div class=""event-content-left"">
                            <h4><a href=""event-details.html"">WROKSHOP ON UI &amp; UX</a></h4>
                            <ul>
                                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                            </ul>
                        </div>
                        <div class=""event-content-right""");
            WriteLiteral(@">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                <img src=""img/testimonial/testimonial.jpg"" alt=""testimonial"">
                            </div>
                            <div class=""testimonial-content"">
                                <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give ");
            WriteLiteral(@"you a coete account of the system, and expound the actual</p>
                                <h4>David Morgan</h4>
                                <h5>Student, CSE</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>LATEST FROM BLOG</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-blog"">
                    <div class=""blog-img"">
                        <a href=""blog-details.html""><img src=""img/blog/blog1.jpg"" alt=""blog""></a>
        ");
            WriteLiteral(@"                <div class=""blog-hover"">
                            <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                            <a href=""blog-details.html"">read more</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 col-sm-6 col-xs-12"">
                <div class=""single-blog"">
                    <div class=""blog-img"">
                        <a href=""blog-details.html""><img src=""img/blog/blog2.jpg"" alt=""blog""></a>
                        <div class=");
            WriteLiteral(@"""blog-hover"">
                            <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                            <a href=""blog-details.html"">read more</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 hidden-sm col-xs-12"">
                <div class=""single-blog"">
                    <div class=""blog-img"">
                        <a href=""blog-details.html""><img src=""img/blog/blog3.jpg"" alt=""blog""></a>
                        <div class=""blog-hover"">
            ");
            WriteLiteral(@"                <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                            <a href=""blog-details.html"">read more</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Blog Area End -->
<!-- Subscribe Start -->
<div class=""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>");
            WriteLiteral("subscribe our newsletter</h2>\n                    <p>I must explain to you how all this mistaken idea </p>\n                </div>\n                <div class=\"newsletter-form mc_embed_signup\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ee1fe7b8e3ac76a3c52918dc72a2cab616eea8730480", async() => {
                WriteLiteral("\n                        <div id=\"mc_embed_signup_scroll\" class=\"mc-form\">\n                            <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 23532, "\"", 23540, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                BeginWriteAttribute("value", " value=\"", 23921, "\"", 23929, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\n                            <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Subscribe End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slider>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
