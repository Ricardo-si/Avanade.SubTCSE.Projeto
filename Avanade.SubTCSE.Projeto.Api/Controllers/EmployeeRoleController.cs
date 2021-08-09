using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
//versionamento de API
namespace Avanade.SubTCSE.Projeto.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1", Deprecated = false)]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class EmployeeRoleController : ControllerBase
    {
        public async Task<IActionResult> CreateEmployeeRole([FromBody] EmployeeRoleDto employeeRoleDto)
        {
            EmployeeRoleAppService employeeRoleAppService = new EmployeeRoleAppService();
            await employeeRoleAppService.AddEmployeeRoleAsync(employeeRoleDto);

            return Ok();
        }
    }
}
