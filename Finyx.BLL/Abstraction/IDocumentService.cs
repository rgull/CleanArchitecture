using Finyx.Domain.Entities;

namespace Finyx.BLL.Abstraction
{
    public interface IDocumentService
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : BaseEntity;
        Task<T?> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task<T> UpdateAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        Task<bool> SoftDeleteAsync<T>(int id) where T : BaseEntity;
        Task<IEnumerable<T>> GetByUserIdAsync<T>(int userId) where T : BaseEntity;
        Task<bool> UploadDocumentAsync<T>(T document) where T : BaseEntity;
        Task<bool> DownloadDocumentAsync<T>(int documentId) where T : BaseEntity;
    }
}
