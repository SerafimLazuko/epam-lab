using System.Threading.Tasks;
using System.Collections.Generic;
using MLA_task.BLL.Interface.Models;

namespace MLA_task.BLL.Interface
{
    public interface IDemoModelService
    {
        Task<DemoModel> GetDemoModelByIdAsync(int id);
        Task<IEnumerable<DemoModel>> GetModelsAsync();
    }
}