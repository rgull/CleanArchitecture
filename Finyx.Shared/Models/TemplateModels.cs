namespace Finyx.Shared.Models
{
    public class TemplateRequest
    {
        public string TemplateName { get; set; } = string.Empty;
        public Dictionary<string, string> Placeholders { get; set; } = new();
        public string OutputFileName { get; set; } = string.Empty;
    }

    public class TemplateResponse
    {
        public bool Success { get; set; }
        public string? FilePath { get; set; }
        public byte[]? FileContent { get; set; }
        public string? ErrorMessage { get; set; }
    }

    public class TemplateInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public enum TemplateCategory
    {
        Reports,
        Documents,
        Forms,
        Certificates
    }
}
