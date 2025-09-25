using Finyx.Shared.Models;

namespace Finyx.BLL.Abstraction
{
    public interface IPdfGeneratorService
    {
        Task<byte[]> GeneratePdfAsync(string htmlContent);
        Task<byte[]> GeneratePdfFromTemplateAsync(string templatePath, Dictionary<string, string> placeholders);
        Task<byte[]> MergePdfsAsync(IEnumerable<byte[]> pdfFiles);
        Task<byte[]> AddWatermarkAsync(byte[] pdfContent, string watermarkText);
        Task<byte[]> AddHeaderFooterAsync(byte[] pdfContent, string? headerText = null, string? footerText = null);
        Task<bool> ValidatePdfAsync(byte[] pdfContent);
    }
}
