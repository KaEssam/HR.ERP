namespace HR.ERP.API.Models;

public class AuditLog
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string PerformedBy { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}
