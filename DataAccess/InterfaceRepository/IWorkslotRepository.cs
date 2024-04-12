using BusinessObject.DTO;

namespace DataAccess.InterfaceRepository { public interface IWorkslotRepository { Task<List<Workslot>> GenerateWorkSlotsForMonth(CreateWorkSlotRequest request); Task<List<object>> GetWorkSlotsForDepartment(CreateWorkSlotRequest request); Task<int> RemoveDuplicateWorkSlots(); Task<bool> SoftDeleteAsync(Guid id); } }