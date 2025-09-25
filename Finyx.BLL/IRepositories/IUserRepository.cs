using Finyx.Domain.Entities;

namespace Finyx.BLL.IRepositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : BaseEntity;
        Task<T?> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task<T> UpdateAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        Task<bool> SoftDeleteAsync<T>(int id) where T : BaseEntity;
        Task<T?> GetByEmailAsync<T>(string email) where T : BaseEntity;
        Task<IEnumerable<T>> GetByRoleAsync<T>(string role) where T : BaseEntity;
        Task<bool> ExistsAsync<T>(int id) where T : BaseEntity;
    }
}
