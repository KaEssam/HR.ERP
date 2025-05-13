using HR.ERP.API.Dtos;

namespace HR.ERP.API.Service.Department
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartments();
        Task<DepartmentDto> GetDepartmentById(int Id);
        Task<DepartmentDto> CreateDepartment(DepartmentDto departmentDto);
        Task<DepartmentDto> UpdataDepartment(int Id, DepartmentDto departmentDto);
        Task<bool> DeleteDepartment(int Id);


    }
}
