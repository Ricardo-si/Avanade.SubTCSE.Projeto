using AutoMapper;
using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services;
using System.Threading.Tasks;
//essa implementação mapeia o employeeRoleDto p/ o dominio e chamar o met. dominio p/ adicionar
namespace Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole
{
    public class EmployeeRoleAppService : IEmployeeRoleAppService
    {
        private readonly IMapper _mapper;

        private readonly IEmployeeRoleAppService _empployeeRoleService;
        public async Task<EmployeeRoleDto> AddEmployeeRoleAsync(EmployeeRoleDto employeeRoleDto)
        {
            //mapper
            var itemDomain = _mapper.Map<EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>(employeeRoleDto);

            //vamos chamar o método agora
            var item = await _empployeeRoleService.AddEmployeeRoleAsync(itemDomain);

            // mapear de volta para poder devolver 

            var itemDto = _mapper.Map<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, EmployeeRoleDto>(item);

            //agora devolve

            return itemDto;



        }
    }
}