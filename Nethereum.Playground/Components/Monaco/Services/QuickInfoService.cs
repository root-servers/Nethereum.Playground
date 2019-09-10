﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Nethereum.Playground.Components.Monaco.MonacoDTOs;

namespace Nethereum.Playground.Components.Monaco.Services
{

    //https://github.com/OmniSharp/omnisharp-roslyn/blob/6836fadb9c35a88d4695276d14302336a460b841/src/OmniSharp.Roslyn.CSharp/Services/Signatures/InvocationContext.cs

    public class QuickInfoService
    {
        public static async Task<string[]> GetQuickInfo(string source, string language, int position)
        {
      
            if (language == "csharp")
            {
                if (!CSharpEditorProject.Current.IsInitialised()) return null;
                var document = CSharpEditorProject.Current.GetCurrentDocument(source);
         

                var result = new List<string>();
                var quickInfoService = Microsoft.CodeAnalysis.QuickInfo.QuickInfoService.GetService(document);
           
                var info = await quickInfoService.GetQuickInfoAsync(document, position);
                if (info != null)
                {
                   
                    foreach (var section in info.Sections)
                    {
                        result.Add("**" + section.Kind + "**");
                        result.Add(section.Text);
                    }
                }

                return result.ToArray();
            }

            else if (language == "vb")
            {

            }

            return null;
        }


        [JSInvokable()]
        public static async Task<HoverItem[]> GetQuickInfo(EditorModel editorModel, int position)
        {
            var items = await GetQuickInfo(editorModel.Script, editorModel.Language, position);
            return items?.Select(x => new HoverItem() { Value = x }).ToArray();
        }
    }
}
