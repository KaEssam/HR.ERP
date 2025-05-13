namespace HR.ERP.API.Models;

public class Payroll
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public decimal Amount { get; set; }
    public string Period { get; set; } = string.Empty;
    public string PayslipLang { get; set; } = string.Empty;
    
    public Employee Employee { get; set; }
    
}
