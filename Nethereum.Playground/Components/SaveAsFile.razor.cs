﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Blazor.FileReader;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Nethereum.Playground.Components.Modal;

namespace Nethereum.Playground.Components
{
    public class SaveAsFileBase: ComponentBase
    {
        [Parameter]
        public SaveAsFileModel Model { get; set; }

    }
}