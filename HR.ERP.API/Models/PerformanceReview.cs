namespace HR.ERP.API.Models;

public class PerformanceReview
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public string KPI { get; set; } = string.Empty;
    public int Score { get; set; }
    public DateTime ReviewDate { get; set; }
    
    public Employee Employee { get; set; }
    
}
