#pragma checksum "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3db4f99162720ef3e3c4cb026e41f22322f6a00"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FlappyBird.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using FlappyBird;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using FlappyBird.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using FlappyBird.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using FlappyBird.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game")]
    public partial class GameContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
      
    GameManager _gameManager;

    protected override void OnInitialized()
        {

            _gameManager = new GameManager();
            _gameManager.MainLoopCompleted += (o, e) => StateHasChanged();
        }
        void HandleKeyUp(KeyboardEventArgs e)
        {
            if(e.Key == " ")
            {
                _gameManager.Jump();
            }
        }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
