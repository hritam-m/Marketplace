using Microsoft.AspNetCore.Components;
using MudBlazor;
using Toolbelt.Blazor.HotKeys2;

namespace Marketplace.Components.Shared;

public partial class CommandPalette
{
    private readonly Dictionary<string, string> _pages = [];
    private HotKeysContext? _hotKeysContext;
    private Dictionary<string, string> _pagesFiltered = [];
    private string? _search;
    [Inject] private HotKeys? HotKeys { get; set; }
    [Inject] private NavigationManager? Navigation { get; set; }
    [CascadingParameter] private MudDialogInstance? MudDialog { get; set; }

    public async ValueTask DisposeAsync()
    {
        await _hotKeysContext!.DisposeAsync();
    }

    protected override void OnInitialized()
    {
        _pages.Add("App", "/");

        _pagesFiltered = _pages;

        _hotKeysContext = HotKeys?.CreateContext()
            .Add(ModCode.None, Code.Escape, () => MudDialog?.Close(), "Close command palette.");
    }

    private void SearchPages(string value)
    {
        _pagesFiltered = new Dictionary<string, string>();

        if (!string.IsNullOrWhiteSpace(value))
            _pagesFiltered = _pages
                .Where(x => x.Key
                    .Contains(value, StringComparison.InvariantCultureIgnoreCase))
                .ToDictionary(x => x.Key, x => x.Value);
        else
            _pagesFiltered = _pages;
    }
}
