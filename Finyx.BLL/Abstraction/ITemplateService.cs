using Finyx.Shared.Models;

namespace Finyx.BLL.Abstraction
{
    public interface ITemplateService
    {
        Task<TemplateResponse> GeneratePdfFromTemplateAsync(TemplateRequest request);
        Task<IEnumerable<TemplateInfo>> GetAvailableTemplatesAsync();
        Task<TemplateInfo?> GetTemplateInfoAsync(string templateName);
        Task<byte[]?> GetTemplateBytesAsync(string templateName);
        Task<bool> ValidateTemplateAsync(string templateName);
        Task<string> GetTemplatePathAsync(string templateName);
    }
}
