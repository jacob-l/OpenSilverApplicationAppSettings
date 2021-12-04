﻿using DotNetForHtml5;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using OpenSilverApplication46.Browser.Interop;

namespace OpenSilverApplication46.Browser.Pages
{
    [Route("/")]
    public class Index : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Cshtml5Initializer.Initialize(new UnmarshalledJavaScriptExecutionHandler(JSRuntime));
            Program.RunApplication(Configuration);
        }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Inject]
        private IConfiguration Configuration { get; set; }
    }
}