using System.ComponentModel.DataAnnotations.Schema;

namespace HR.ERP.API.Models;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    [ForeignKey("Employee")]
    public int? ManagerId { get; set; }
    
    public Employee Manager { get; set; }
    public List<Employee> Employees { get; set; } = new List<Employee>();   
    
}
