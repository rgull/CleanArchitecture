using Finyx.Domain.Entities;

namespace Finyx.BLL.Abstraction
{
    public interface IEventProcessingService
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : BaseEntity;
        Task<T?> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<T> CreateAsync<T>(T entity) where T : BaseEntity;
        Task<T> UpdateAsync<T>(T entity) where T : BaseEntity;
        Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        Task<bool> SoftDeleteAsync<T>(int id) where T : BaseEntity;
        Task ProcessEventAsync<T>(T eventData) where T : BaseEntity;
        Task<IEnumerable<T>> GetEventsByTypeAsync<T>(string eventType) where T : BaseEntity;
        Task<bool> PublishEventAsync<T>(T eventData) where T : BaseEntity;
    }
}
