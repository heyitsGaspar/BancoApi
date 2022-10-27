using Aplication.Feautres.Clientes.Commands.CreateClienteCommand;
using Aplication.Feautres.Clientes.Commands.DeleteClienteCommand;
using Aplication.Feautres.Clientes.Commands.UpdateClienteCommand;
using Aplication.Feautres.Clientes.Queries.GetClienteById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers._1
{
    [Route("1.0")]

    public class ClienteController : BaseApiController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetClienteByIdQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateClienteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, UpdateClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(new DeleteClienteCommand { Id = id}));
        }


    }
}
