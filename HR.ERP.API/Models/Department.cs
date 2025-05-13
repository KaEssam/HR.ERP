namespace HR.ERP.API.Models;

public class Department
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? ManagerId { get; set; }
}
