using Finyx.Domain.Entities;

namespace Finyx.BLL.IRepositories
{
    public interface IDocumentRepository
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : BaseEntity;
        Task<T?> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task<T> UpdateAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        Task<bool> SoftDeleteAsync<T>(int id) where T : BaseEntity;
        Task<IEnumerable<T>> GetByUserIdAsync<T>(int userId) where T : BaseEntity;
        Task<IEnumerable<T>> GetByDocumentTypeAsync<T>(string documentType) where T : BaseEntity;
        Task<IEnumerable<T>> GetByStatusAsync<T>(string status) where T : BaseEntity;
        Task<bool> ExistsAsync<T>(int id) where T : BaseEntity;
    }
}
