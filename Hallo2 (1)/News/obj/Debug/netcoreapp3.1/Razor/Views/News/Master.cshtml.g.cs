#pragma checksum "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e43c97b13b49f20625afb7472874fc96f873afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Master), @"mvc.1.0.view", @"/Views/News/Master.cshtml")]
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
#line 1 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
using News.EF;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e43c97b13b49f20625afb7472874fc96f873afb", @"/Views/News/Master.cshtml")]
    #nullable restore
    public class Views_News_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e43c97b13b49f20625afb7472874fc96f873afb2925", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

	<title>WebMag HTML Template</title>

	<!-- Google font -->
	<!--<link href=""https://fonts.googleapis.com/css?family=Nunito+Sans:700%7CNunito:300,600"" rel=""stylesheet"">-->
	<!-- Bootstrap -->
	<link type=""text/css"" rel=""stylesheet"" href=""/css/bootstrap.min.css"" />

	<!-- Font Awesome Icon -->
	<link rel=""stylesheet"" href=""/css/font-awesome.min.css"">

	<!-- Custom stlylesheet -->
	<link type=""text/css"" rel=""stylesheet"" href=""/css/style.css"" />

	<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
	<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
	<!--[if lt IE 9]>
	  <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
	  <script src=""https");
                WriteLiteral(@"://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
	<![endif]-->


	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;}

/* Кнопка, используемая для открытия формы чата - закреплена в нижней части страницы */
.open-button {
  color: black;
  padding: 16px 20px;
  border-width: 1px;
  cursor: pointer;
  opacity: 0.8;
  position: fixed;
  bottom: 23px;
  right: 28px;
  width: 280px;
}

/* Всплывающий чат - скрыт по умолчанию */
.chat-popup {
  display: none;
  position: fixed;
  bottom: 0;
  right: 15px;
  border: 3px solid #f1f1f1;
  z-index: 9;
}

/* Добавление стилей в контейнер формы */
.form-container {
  max-width: 300px;
  padding: 10px;
  background-color: white;
}

/* Полноразмерная текстовая область */
.form-container textarea {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  border: none;
  background: #f1f1f1;
  resize: none;
  min-hei");
                WriteLiteral(@"ght: 200px;
}

/* Когда текстовая область получит фокус, сделайте что-нибудь */
.form-container textarea:focus {
  background-color: #ddd;
  outline: none;
}

/* Установите стиль для кнопки отправить/кнопка */
.form-container .btn {
  color: black;
  padding: 16px 20px;
  border-width: 1px;
  border-color: black;
  cursor: pointer;
  width: 100%;
  margin-bottom:10px;
  opacity: 0.8;
}

/* Добавьте красный цвет фона к кнопке отмена */
.form-container .cancel {
}

/* Добавьте некоторые эффекты наведения на кнопки */
.form-container .btn:hover, .open-button:hover {
  opacity: 1;
}
</style>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e43c97b13b49f20625afb7472874fc96f873afb6675", async() => {
                WriteLiteral(@"

		<!-- Header -->
		<header id=""header"">
			<!-- Nav -->
			<div id=""nav"">
				<!-- Main Nav -->
				<div id=""nav-fixed"" class=""slide-down"">
					<div class=""container"">
						<!-- logo -->
						<div class=""nav-logo"">
							<a href=""/"" class=""logo""><img src=""/img/logo1.png""");
                BeginWriteAttribute("alt", " alt=\"", 3038, "\"", 3044, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<!-- /logo -->\r\n\t\t\t\t\t\t<nav>\r\n\t\t\t\t\t\t<ul class=\"nav-menu nav navbar-nav\">\r\n");
#nullable restore
#line 122 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                             foreach (Reblicator r in ViewBag.Rubrics)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 3220, "\"", 3248, 2);
                WriteAttributeValue("", 3227, "/News/NewShow/", 3227, 14, true);
#nullable restore
#line 124 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
WriteAttributeValue("", 3241, r.Path, 3241, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 124 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                                                               Write(r.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>                                                \r\n");
#nullable restore
#line 125 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
							}     

#line default
#line hidden
#nullable disable
                WriteLiteral(@"						</ul>
						</nav >
						<!-- search & aside toggle -->
							<div class=""nav-btns"">
								<button class=""aside-btn""><i class=""fa fa-bars""></i></button>
							<!----<button class=""aside-btn""><i class=""fa fa-bars""></i></button>--->
							<button class=""search-btn""><i class=""fa fa-search""></i></button>
							<div class=""search-form"">
								<form action=""/News/Search"">
									<input class=""search-input"" type=""text"" placeholder=""Введите свой запрос ..."" name=""text"">								
									<button class=""search-close""><i class=""fa fa-times""></i></button>
								</form>
							</div>
						</div>
						<!-- /search & aside toggle -->
					</div>
				</div>
				<!-- /Main Nav -->
				<!-- Aside Nav -->

					<!-- /nav -->
					<!-- widget posts -->
					
					<!-- /widget posts -->
					<!-- social links -->
					
					<!-- /social links -->
					<!-- aside nav close -->
					<div id=""nav-aside"" class=""active"">
					<!-- nav -->
					<div class=""section-row"">
						<ul clas");
                WriteLiteral("s=\"nav-aside-menu\">\r\n");
#nullable restore
#line 158 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                             foreach (Reblicator r in ViewBag.Rubrics)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<li><a");
                BeginWriteAttribute("href", " href=\"", 4451, "\"", 4479, 2);
                WriteAttributeValue("", 4458, "/News/NewShow/", 4458, 14, true);
#nullable restore
#line 160 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
WriteAttributeValue("", 4472, r.Path, 4472, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 160 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                                                               Write(r.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>                                                \r\n");
#nullable restore
#line 161 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
							} 

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<!-- /nav -->\r\n\r\n\t\t\t\t\t<!-- widget posts -->\r\n\t\t\t\t\t<div class=\"section-row\">\r\n\t\t\t\t\t\t<h3>Актуальное</h3>\r\n\t\t\t\t\t\t<div class=\"post post-widget\">\r\n\t\t\t\t\t\t\t<a class=\"post-img\" href=\"blog-post.html\"><img src=\"/img/3.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4801, "\"", 4807, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
							<div class=""post-body"">
								<h3 class=""post-title""><a href=""/News/NewShow/Politic"">Идеи губернаторов войдут в список...</a></h3>
							</div>
						</div>

						<div class=""post post-widget"">
							<a class=""post-img"" href=""blog-post.html""><img src=""/img/2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5096, "\"", 5102, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
							<div class=""post-body"">
								<h3 class=""post-title""><a href=""/News/NewShow/Fashion"">Gucci стал самым...</a></h3>
							</div>
						</div>

					</div>
					<!-- /widget posts -->

					<!-- social links -->
					 
					<!-- /social links -->

					<!-- aside nav close -->
					<button class=""nav-aside-close""><i class=""fa fa-times""></i></button>
					<!-- /aside nav close -->

				</div>
					<!-- /aside nav close -->

				</div>
				<!-- Aside Nav -->
			</div>
			<!-- /Nav -->
		</header>
		<!-- /Header -->
		<!-- section -->
		<div class=""section"">
			<!-- container -->
			<div class=""container"">
				<!-- row -->
				<div class=""row"">
					<!-- post -->
					<div class=""col-md-6"">
						<div class=""post post-thumb"">
							<a class=""post-img"" href=""/News/NewShow/Politic""><img src=""/img/3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5961, "\"", 5967, 0);
                EndWriteAttribute();
                WriteLiteral("width=\"200\" height=\"400\"></a>\r\n\t\t\t\t\t\t\t<div class=\"post-body\">\r\n\t\t\t\t\t\t\t\t<div class=\"post-meta\">\r\n\t\t\t\t\t\t\t\t\t<a class=\"post-category cat-3\" href=\"/News/NewShow/Politic\">Политика</a>\r\n\t\t\t\t\t\t\t\t\t<span class=\"post-date\">");
#nullable restore
#line 216 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                                                       Write(DateTime.Now.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
								</div>
								<h3 class=""post-title""><a href=""/News/NewShow/Politic"">Идеи губернаторов войдут в список поручений Путина по соцподдержке граждан</a></h3>
							</div>
						</div>
					</div>
					<!-- /post -->
					<!-- post -->
					<div class=""col-md-6"">
						<div class=""post post-thumb"">
								<a class=""post-img"" href=""/News/NewShow/Fashion""><img src=""/img/2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6616, "\"", 6622, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"200\" height=\"400\"></a>\r\n\t\t\t\t\t\t\t\t<div class=\"post-body\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"post-meta\">\r\n\t\t\t\t\t\t\t\t\t\t<a class=\"post-category cat-3\" href=\"/News/NewShow/Fashion\">Мода</a>\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"post-date\">");
#nullable restore
#line 230 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                                                           Write(DateTime.Now.AddDays(-1).ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
									</div>
									<h3 class=""post-title""><a href=""/News/NewShow/Fashion"">Gucci стал самым дорогим итальянским брендом</a></h3>
								</div>
						</div>
					</div>
					<!-- /post -->
					
				</div>
				<!-- /row -->
				<!-- row -->

				<!-- /row -->
				<!-- row -->
				<div class=""row"">
					<div class=""col-md-8"">
						<div class=""row"">
							<!-- post -->
							
							<!-- /post -->

							<div class=""clearfix visible-md visible-lg""></div>

							<!-- post -->
							<div class=""section"">
			<!-- container -->
			<div class=""container"">
				<!-- row -->
				<div class=""row"">
					<div class=""col-md-8"">
						<div class=""row"">
							<div class=""col-md-12"">
								<div class=""section-title"">
									<h2>Новости</h2>
								</div>
							</div>
							<div class=""col-8"">
							<!-- /post -->
							<!-- post -->
							");
#nullable restore
#line 269 "D:\Home\Downloads\Hallo2 (1)\Hallo2 (1)\News\Views\News\Master.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
							</div>
							
						</div>
						
					</div>
				</div>

			</div>
				<!-- /row -->
		</div>
							<!-- /post -->

							
						</div>
					</div>

					<div class=""col-md-4"">
						<!-- post widget -->
						<div class=""aside-widget"">
							<div class=""section-title"">
								<h3>Чат</h3>
							</div>

							<div class=""col-4"" id=""chat"">
                        <div id=""chatMessages"">
                        </div>


                    </div>
						</div>
						<!-- /post widget -->
						<button class=""open-button"" onclick=""openForm()"">Чат</button>

<div class=""chat-popup"" id=""myForm"">
  <form action=""../action_page.php"" class=""form-container"">
    <h1>Чат</h1>

    <label for=""msg""><b>Сообщение</b></label>
     <iframe id=""addMessageFrame"" style=""display: none""> </iframe>
	<input type=""text"" id=""message""/>
    <button type=""button"" class=""btn btn-outline-dark"" id=""addMessage"">Отправить</button>
    <button type=""button"" class=""btn cancel"" onclick=""");
                WriteLiteral(@"closeForm()"">Закрыть</button>
  </form>
</div>

<script>
function openForm() {
  document.getElementById(""myForm"").style.display = ""block"";
}

function closeForm() {
  document.getElementById(""myForm"").style.display = ""none"";
}
</script>

						<!-- post widget -->
						
						<!-- /post widget -->
						
						<!-- ad -->
						
						<!-- /ad -->
					</div>

				</div>
				<!-- /row -->
			
			</div>
			<!-- /container -->
		</div>
		<!-- /section -->
		<!-- section -->
		<!-- /section -->
		<!-- section -->
		
			<!-- /container -->
			
		<script>  
        const elChatMessages = document.getElementById('chatMessages');
        const elAddMessage = document.getElementById('addMessage');
        const elMessage = document.getElementById('message');
        const elAddMessageFrame = document.getElementById('addMessageFrame');

        elAddMessage.addEventListener(""click"", () => {
            elAddMessageFrame.src = ""/Chat/AddMessage?message="" + elMessage.value;
");
                WriteLiteral(@"        });

        setInterval(() => {
            fetch('/Chat/Messages').
                then(response => response.json())
                .then(data => {
                    elChatMessages.innerHTML = '';
                    for (msg of data) {
                        elChatMessages.insertAdjacentHTML('afterbegin', `<p>${msg.message}</p>`);            
                    }
                });            

        }, 2000);
		</script>

		<!-- /section -->
		<!-- Footer -->
		<!-- /Footer -->
		<!-- jQuery Plugins -->
		<script src=""/js/jquery.min.js""></script>
		<script src=""/js/bootstrap.min.js""></script>
		<script src=""/js/main.js""></script>




	");
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