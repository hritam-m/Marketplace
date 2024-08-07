using Marketplace.Models.Article;

namespace Marketplace.Services;

public interface IArticlesService
{
    Task<IEnumerable<ArticlePreviewModel>> GetArticles();
}