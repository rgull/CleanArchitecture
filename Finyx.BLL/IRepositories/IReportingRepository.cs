using Finyx.Domain.Entities;

namespace Finyx.BLL.IRepositories
{
    public interface IReportingRepository
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : BaseEntity;
        Task<T?> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task<T> UpdateAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        Task<bool> SoftDeleteAsync<T>(int id) where T : BaseEntity;
        Task<IEnumerable<T>> GetReportsByDateRangeAsync<T>(DateTime fromDate, DateTime toDate) where T : BaseEntity;
        Task<IEnumerable<T>> GetReportsByTypeAsync<T>(string reportType) where T : BaseEntity;
        Task<IEnumerable<T>> GetReportsByUserIdAsync<T>(int userId) where T : BaseEntity;
        Task<bool> ExistsAsync<T>(int id) where T : BaseEntity;
    }
}
