#pragma checksum "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/Score.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1c35d2ef6674dc694135621e19ef9d41f1318b"
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
#line 11 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/_Imports.razor"
using FlappyBird.Models;

#line default
#line hidden
#nullable disable
    public partial class Score : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "scoreWindow");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 1 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/Score.razor"
                                 _scoreWindowCss

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/markmahowald/personalProjects/BlazorProjects/FlappyBirdBlazorWasm/FlappyBirdBlazorWasm/FlappyBird/Components/Score.razor"
      
    [Parameter] public ScoreModel Model {get; set;}

    string _scoreWindowCss => $"";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
