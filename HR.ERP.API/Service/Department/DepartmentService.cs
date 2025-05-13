using HR.ERP.API.Data;
using HR.ERP.API.Dtos;
using HR.ERP.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HR.ERP.API.Service.Department
{
    public class DepartmentService : IDepartmentService
    {
        private readonly AppDbContext _context;
        public DepartmentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllDepartments()
        {
            var departments = await _context.Departments.ToListAsync();

            return departments.Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name,
            });
        }

        public async Task<DepartmentDto> GetDepartmentById(int Id)
        {
            var department = await _context.Departments.FindAsync(Id);

            if (department == null)
                return null;

            return new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name
            };
        }

        public async Task<DepartmentDto> CreateDepartment(DepartmentDto departmentDto)
        {
            if (departmentDto.Name == null || departmentDto.Name == string.Empty)
                throw new Exception("Enter Valid Name");

            var department = new Models.Department
            {
                Name = departmentDto.Name
            };

            _context.Departments.Add(department);
            await _context.SaveChangesAsync();

            return new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name
            };
        }

        public async Task<DepartmentDto> UpdataDepartment(int Id, DepartmentDto departmentDto)
        {
            var department = await _context.Departments.FindAsync(Id);

            if (department == null)
                return null;

            department.Name = departmentDto.Name;
            department.ManagerId = departmentDto.ManagerId;

            await _context.SaveChangesAsync();
            return departmentDto;
        }

        public async Task<bool> DeleteDepartment(int Id)
        {
            var department = await _context.Departments.FindAsync(Id);
            if (department == null)
                return false;

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
