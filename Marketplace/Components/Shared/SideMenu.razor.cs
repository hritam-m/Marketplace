using Microsoft.AspNetCore.Components;
using MudBlazor;
using Marketplace.Models;
using Marketplace.Models.SideMenu;

namespace Marketplace.Components.Shared;

public partial class SideMenu
{
    private List<MenuSectionModel> _menuSections = new()
    {
        new MenuSectionModel
        {
            Title = "GENERAL",
            SectionItems = new List<MenuSectionItemModel>
            {
                new()
                {
                    Title = "App",
                    Icon = Icons.Material.Filled.Speed,
                    Href = "/"
                }
            }
        },

        new MenuSectionModel
        {
            Title = "MANAGEMENT",
            SectionItems = new List<MenuSectionItemModel>
            {
                new()
                {
                    IsParent = true,
                    Title = "User",
                    Icon = Icons.Material.Filled.Person,
                    MenuItems = new List<MenuSectionSubItemModel>
                    {
                        new()
                        {
                            Title = "Profile",
                            Href = "/user/profile",
                            PageStatus = PageStatus.Completed
                        },
                        new()
                        {
                            Title = "Login",
                            Href = "/login",
                            PageStatus = PageStatus.Completed
                        },
                        new()
                        {
                            Title = "Register",
                            Href = "/register",
                            PageStatus = PageStatus.Completed
                        },
                        new()
                        {
                            Title = "Forgot Password",
                            Href = "/forgot-password",
                            PageStatus = PageStatus.Completed
                        },
                        new()
                        {
                            Title = "Reset Password",
                            Href = "/reset-password",
                            PageStatus = PageStatus.Completed
                        }
                    }
                },
                new()
                {
                    IsParent = true,
                    Title = "Article",
                    Icon = Icons.Material.Filled.Article,
                    MenuItems = new List<MenuSectionSubItemModel>
                    {
                        new()
                        {
                            Title = "Posts",
                            Href = "/user/posts",
                            PageStatus = PageStatus.ComingSoon
                        },
                        new()
                        {
                            Title = "Post",
                            Href = "/user/post",
                            PageStatus = PageStatus.ComingSoon
                        },
                        new()
                        {
                            Title = "New Post",
                            Href = "/user/newpost",
                            PageStatus = PageStatus.ComingSoon
                        }
                    }
                }
            }
        }
    };

    [EditorRequired] [Parameter] public bool SideMenuDrawerOpen { get; set; }
    [EditorRequired] [Parameter] public EventCallback<bool> SideMenuDrawerOpenChanged { get; set; }
    [EditorRequired] [Parameter] public bool CanMiniSideMenuDrawer { get; set; }
    [EditorRequired] [Parameter] public EventCallback<bool> CanMiniSideMenuDrawerChanged { get; set; }
    [EditorRequired] [Parameter] public UserModel? User { get; set; }
}