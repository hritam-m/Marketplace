using MudBlazor;

namespace Marketplace.Layout;

public partial class LoginLayout
{
    private readonly MudTheme _theme = new()
    {
        PaletteLight = new PaletteLight()
        {
            Primary = Colors.Blue.Default,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.Red.Default,
        },
        PaletteDark = new PaletteDark()
        {
            Black = "#27272f",
            Background = "rgb(21,27,34)",
            Surface = "#212B36",
            DrawerBackground = "rgb(21,27,34)",
            DrawerText = "rgba(255,255,255, 0.50)",
            DrawerIcon = "rgba(255,255,255, 0.50)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.70)",
            TextPrimary = "rgba(255,255,255, 0.70)",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)"
        },
        LayoutProperties = new LayoutProperties
        {
            AppbarHeight = "80px",
            DefaultBorderRadius = "12px"
        },
        Typography = new Typography
        {
            Default = new Default
            {
                FontSize = "0.9rem",
            }
        }
    };
}
