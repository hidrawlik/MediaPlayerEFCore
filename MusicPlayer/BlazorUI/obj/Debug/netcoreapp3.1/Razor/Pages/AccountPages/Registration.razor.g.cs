#pragma checksum "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a8a04d1eb74553bbad503932296fa7d1fcf567"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUI.Pages.AccountPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
using BlazorUI.Models.AccountModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthenticationLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Register")]
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12 card p-5");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                          user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                                RegisterUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<div>\r\n                <h3 style=\"font-weight:bold; color: brown\">Music Player Register</h3>\r\n            </div>\r\n            ");
                __builder2.AddMarkupContent(11, "<div>\r\n                <br>\r\n            </div>\r\n            ");
                __Blazor.BlazorUI.Pages.AccountPages.Registration.TypeInference.CreateValidationMessage_0(__builder2, 12, 13, 
#nullable restore
#line 14 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                      () => user.userName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "card-columns row");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control col-12");
                __builder2.AddAttribute(20, "placeholder", "Username");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                                                    user.userName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.userName = __value, user.userName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.userName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            <br>\r\n            ");
                __Blazor.BlazorUI.Pages.AccountPages.Registration.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 19 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                      () => user.email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "card-columns row");
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control col-12");
                __builder2.AddAttribute(34, "placeholder", "Email address");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                                                    user.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.email = __value, user.email))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            <br>\r\n            ");
                __Blazor.BlazorUI.Pages.AccountPages.Registration.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 24 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                      () => user.password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "card-columns row");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "type", "password");
                __builder2.AddAttribute(48, "class", "form-control col-12");
                __builder2.AddAttribute(49, "placeholder", "Password");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                                                                    user.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.password = __value, user.password))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            <br>\r\n            ");
                __Blazor.BlazorUI.Pages.AccountPages.Registration.TypeInference.CreateValidationMessage_3(__builder2, 55, 56, 
#nullable restore
#line 29 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                      () => user.confirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "card-columns row");
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "type", "password");
                __builder2.AddAttribute(63, "class", "form-control col-12");
                __builder2.AddAttribute(64, "placeholder", "Confirm password");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
                                                                                    user.confirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.confirmPassword = __value, user.confirmPassword))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.confirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(70, "<div class=\"row flex-nowrap align-items-center\">\r\n                <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Sign up\">\r\n                <a href=\"Account/Login\" class=\"col-7\">Already an user?</a>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\AccountPages\Registration.razor"
           
        RegisterViewModel user = new RegisterViewModel();

        private void RegisterUser()
        {

        }
    

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorUI.Pages.AccountPages.Registration
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591