using Marketplace.Models.Products;
using Microsoft.AspNetCore.Components;

namespace Marketplace.Pages.Products;

public partial class ProductDetail
{
    [Parameter]
    public int ProductId { get; set; }

    private Product? SelectedProduct { get; set; }

    private List<Product> ProductList =
    [
        new Product { Id = 1, Name = "Product 1", Description = "Description of Product 1", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 2, Name = "Product 2", Description = "Description of Product 2", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 3, Name = "Product 3", Description = "Description of Product 3", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 4, Name = "Product 4", Description = "Description of Product 4", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 5, Name = "Product 5", Description = "Description of Product 5", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 6, Name = "Product 6", Description = "Description of Product 6", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 7, Name = "Product 7", Description = "Description of Product 7", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 8, Name = "Product 8", Description = "Description of Product 8", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 9, Name = "Product 9", Description = "Description of Product 9", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 10, Name = "Product 10", Description = "Description of Product 10", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 11, Name = "Product 11", Description = "Description of Product 11", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 12, Name = "Product 12", Description = "Description of Product 12", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 13, Name = "Product 13", Description = "Description of Product 13", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 14, Name = "Product 14", Description = "Description of Product 14", ImageUrl = "https://via.placeholder.com/200" },
        new Product { Id = 15, Name = "Product 15", Description = "Description of Product 15", ImageUrl = "https://via.placeholder.com/200" }
    ];

    protected override void OnInitialized() => SelectedProduct = ProductList!.FirstOrDefault(p => p.Id == ProductId)!;

    private void NavigateBack() => Navigation.NavigateTo("/products");
}
