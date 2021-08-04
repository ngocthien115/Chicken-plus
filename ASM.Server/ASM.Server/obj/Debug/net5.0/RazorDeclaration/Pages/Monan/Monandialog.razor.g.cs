// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ASM.Server.Pages.Monan
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Monan\Monandialog.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Monan\Monandialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Monan\Monandialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Monan\Monandialog.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monandialog/{id}")]
    public partial class Monandialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Server\Pages\Monan\Monandialog.razor"
       
    [Parameter]
    public string id { get; set; }

    IReadOnlyList<IBrowserFile> selectedFiles;
    MonAn monan = new MonAn();
    private string Tieude = "";

    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tieude = "THÊM MÓN ĂN";
            MonAn monan = new MonAn();
        }
        else
        {
            Tieude = "SỬA MÓN ĂN";
            monan = _monanSvc.GetMonAn(int.Parse(id));
        }
    }
    private async void SubmitForm()
    {
        var rootPath = $"{env.WebRootPath}\\images";
        if (!Directory.Exists(rootPath))
        {
            Directory.CreateDirectory(rootPath);
        }

        string dirpath = rootPath + @"\" + "monan";
        if (!Directory.Exists(dirpath))
        {
            Directory.CreateDirectory(dirpath);
        }


        if (monan.MonAnID == 0)
        {
            if (selectedFiles != null && selectedFiles.Count > 0)
            {
                var file = selectedFiles[0];
                string filePath = dirpath + @"\" + file.Name;

                
                Stream stream = file.OpenReadStream(1000000);
                //var path = $"{env.WebRootPath}\\images\\monan\\{file.Name}";
                FileStream fs = File.Create(filePath);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();

                monan.Hinh = file.Name;
            }

            _monanSvc.AddMonAn(monan);
        }
        else
        {
            if (selectedFiles != null && selectedFiles.Count > 0)
            {
                var file = selectedFiles[0];
                string filePath = dirpath + @"\" + file.Name;

                Stream stream = file.OpenReadStream(1000000);
                //var path = $"{env.WebRootPath}\\images\\monan\\{file.Name}";
                FileStream fs = File.Create(filePath);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();

                monan.Hinh = file.Name;
            }

            _monanSvc.EditMonAn(monan.MonAnID, monan);
        }
        NavigationManager.NavigateTo("MonanList");
    }
    private void Cancel()
    {
        NavigationManager.NavigateTo("monanList", true);
    }

    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ASM.Share.Models.IMonAnSvc _monanSvc { get; set; }
    }
}
#pragma warning restore 1591
