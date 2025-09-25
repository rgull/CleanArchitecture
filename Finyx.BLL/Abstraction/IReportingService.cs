using Finyx.Domain.Entities;

namespace Finyx.BLL.Abstraction
{
    public interface IReportingService
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : BaseEntity;
        Task<T?> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task<T> UpdateAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        Task<bool> SoftDeleteAsync<T>(int id) where T : BaseEntity;
        Task<IEnumerable<T>> GenerateReportAsync<T>(DateTime fromDate, DateTime toDate) where T : BaseEntity;
        Task<byte[]> ExportReportAsync<T>(string reportType, DateTime fromDate, DateTime toDate) where T : BaseEntity;
    }
}
