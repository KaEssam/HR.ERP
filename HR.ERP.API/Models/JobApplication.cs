namespace HR.ERP.API.Models;

public class JobApplication
{
    public int Id { get; set; }
    public int JobPostingId { get; set; }
    public int EmployeeId { get; set; }
    public string Status { get; set; } = string.Empty;
}
