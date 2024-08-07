using Microsoft.AspNetCore.Components;
using Marketplace.Models;

namespace Marketplace.Components.Shared;

public partial class UserMenu
{
    [Parameter] public string Class { get; set; }
    [EditorRequired] [Parameter] public UserModel User { get; set; }
}