#pragma checksum "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e7b9d97244a942e300f6cfe0219a3a51a1996e7"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\_Imports.razor"
using ASM.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "...");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pagination justify-content-center pagination-circle");
#nullable restore
#line 4 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
         foreach (var link in links)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
                            () => SeletedPageInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "cursor:pointer");
            __builder.AddAttribute(7, "class", "page-item" + " " + (
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
                                   link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 7 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
                                                                       link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "page-link");
            __builder.AddAttribute(10, "href", "#");
            __builder.AddContent(11, 
#nullable restore
#line 8 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\nthie\Downloads\ASM\ASM.Server\ASM.Client\Shared\Pagination.razor"
       
    [Parameter]
    public int CurrentPage { get; set; } = 1;
    [Parameter]
    public int TotalPagesQuantity { get; set; }
    [Parameter]
    public int Radius { get; set; } = 3;
    [Parameter]
    public EventCallback<int> SelectedPage { get; set; }
    List<LinkModel> links;

    protected override void OnParametersSet()
    {
        LoadPages();
    }

    private async Task SeletedPageInternal(LinkModel link)
    {
        if (link.Page == CurrentPage)
        {
            return;
        }

        if (!link.Enabled)
        {
            return;
        }

        CurrentPage = link.Page;
        await SelectedPage.InvokeAsync(link.Page);
    }

    private void LoadPages()
    {
        links = new List<LinkModel>();
        var isPreviousPageLinkEnable = CurrentPage != 1;
        var previousPage = CurrentPage - 1;
        links.Add(new LinkModel(previousPage, isPreviousPageLinkEnable, "Previous"));
        for(int i = 1; i <= TotalPagesQuantity; i++)
        {
            if (i >= CurrentPage - Radius && i <= CurrentPage + Radius)
            {
                links.Add(new LinkModel(i) { Active = CurrentPage == i });
            }
        }

        var isNextPageLinkEnable = CurrentPage != TotalPagesQuantity;
        var nextPage = CurrentPage + 1;
        links.Add(new LinkModel(nextPage, isNextPageLinkEnable, "Next"));
    }

    class LinkModel{
        public LinkModel(int page)
            :this(page, true) { }

        public LinkModel(int page, bool enabled)
            :this(page, enabled, page.ToString())
        { }

        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }

        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
