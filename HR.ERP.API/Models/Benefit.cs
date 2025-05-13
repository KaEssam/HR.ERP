namespace HR.ERP.API.Models;

public class Benefit
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public string Type { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}
