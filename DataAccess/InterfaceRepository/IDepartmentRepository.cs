using BusinessObject.DTO;

namespace DataAccess.InterfaceRepository { public interface IDepartmentRepository { Task<bool> AddAsync(DepartmentDTO a); Task<List<DepartmentDTO>> GetAllAsync(); Task<Team> GetDepartmentAsync(Guid departmentId); List<DepartmentDTO> GetDepartmentsWithoutManager(); Task<List<EmployeeDTO>> GetEmployeesByDepartmentIdAsync(Guid departmentId); Task<object> GetTeamInfoByEmployeeIdAsync(Guid employeeId); Task<bool> SoftDeleteAsync(Guid id); } }