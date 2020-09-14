#pragma checksum "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571dcbf484f3e829a75c12c042f42268fb3fdc52"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
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
            __builder.AddMarkupContent(0, "<div class=\"score\"></div>\n<div class=\"border-left\"></div>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "game-container");
            __builder.AddAttribute(3, "tabindex", "0");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
                                                   _gameManager.StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 6 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
                                                                                     HandleKeyUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\n    <div class=\"border-top\"></div>\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sky");
            __builder.AddMarkupContent(9, "\n\n        ");
            __builder.OpenComponent<FlappyBird.Components.Bird>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FlappyBird.Models.BirdModel>(
#nullable restore
#line 10 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
                     _gameManager.Bird

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n    ");
            __builder.AddMarkupContent(14, "<div class=\"ground\"> </div>\n");
#nullable restore
#line 15 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
     foreach (var pipe in _gameManager.Pipes)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenComponent<FlappyBird.Components.Pipe>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FlappyBird.Models.PipeModel>(
#nullable restore
#line 17 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
                     pipe

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n");
#nullable restore
#line 18 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n<div class=\"border-right\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/GameContainer.razor"
      
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
