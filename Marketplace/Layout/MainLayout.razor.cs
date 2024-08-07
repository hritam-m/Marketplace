using Blazored.LocalStorage;
using Marketplace.Components.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Marketplace.Models;
using Toolbelt.Blazor.HotKeys2;
using MudBlazor.ThemeManager;
using Marketplace.Theme;

namespace Marketplace.Layout;

public partial class MainLayout : IDisposable
{
    private ThemeManagerTheme _themeManager = new();
    public bool _themeManagerOpen = false;

    void OpenThemeManager(bool value)
    {
        _themeManagerOpen = value;
    }

    void UpdateTheme(ThemeManagerTheme value)
    {
        _themeManager = value;
        StateHasChanged();
    }

    private readonly UserModel _user = new()
    {
        Avatar = "/sample-data/avatar.jpg",
        DisplayName = "Marsha",
        Email = "marsha.j.scarborough@email.com",
        Role = "Administrator"
    };

    private bool _canMiniSideMenuDrawer = true;
    private bool _commandPaletteOpen;

    private HotKeysContext? _hotKeysContext;
    private bool _sideMenuDrawerOpen;

    private bool _themingDrawerOpen;
    [Inject] private IDialogService? _dialogService { get; set; }
    [Inject] private HotKeys? _hotKeys { get; set; }
    [Inject] private ILocalStorageService? _localStorage { get; set; }

    public void Dispose()
    {
        _hotKeysContext?.Dispose();
    }

    protected override async Task OnInitializedAsync()
    {
        _themeManager.Theme = new MudBlazorAdminDashboard();
        _themeManager.DrawerClipMode = DrawerClipMode.Always;
        _themeManager.FontFamily = "Montserrat";
        _themeManager.DefaultBorderRadius = 3;

        _hotKeysContext = _hotKeys.CreateContext()
            .Add(ModCode.Meta, Code.K, OpenCommandPalette, "Open command palette.");
    }

    private void ToggleSideMenuDrawer()
    {
        _sideMenuDrawerOpen = !_sideMenuDrawerOpen;
    }

    private async Task OpenCommandPalette()
    {
        if (!_commandPaletteOpen)
        {
            var options = new DialogOptions
            {
                NoHeader = true,
                MaxWidth = MaxWidth.Medium,
                FullWidth = true
            };

            var commandPalette = _dialogService?.Show<CommandPalette>("", options);
            _commandPaletteOpen = true;

            await commandPalette!.Result;
            _commandPaletteOpen = false;
        }
    }
}
