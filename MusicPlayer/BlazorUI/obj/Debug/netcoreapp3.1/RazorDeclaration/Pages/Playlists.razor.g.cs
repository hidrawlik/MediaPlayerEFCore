#pragma checksum "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\Playlists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8855510bacd593ee520df69b3ce434a9938e7843"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUI.Pages
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
#line 3 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\Playlists.razor"
using BlazorUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\Playlists.razor"
using BlazorUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/playlists")]
    public partial class Playlists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "F:\Саша навчання\2 Курс\4 семестр\ООП\AspDotNetCore\MusicPlayer\BlazorUI\Pages\Playlists.razor"
       
    private IEnumerable<PlaylistViewModel> playlists;

    protected override async Task OnInitializedAsync()
    {
        playlists = await playlistService.GetPlaylists();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PlaylistService playlistService { get; set; }
    }
}
#pragma warning restore 1591
