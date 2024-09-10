using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategorieRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategorieRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategorieRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategorieRequest request);
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategorieRequest request);
    }
}
