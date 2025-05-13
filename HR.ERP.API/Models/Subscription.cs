namespace HR.ERP.API.Models;

public class Subscription
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public string PlanType { get; set; } = string.Empty;
    public int MaxEmployees { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
