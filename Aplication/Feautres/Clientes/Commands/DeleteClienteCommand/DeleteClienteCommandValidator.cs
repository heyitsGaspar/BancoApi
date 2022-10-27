using FluentValidation;

namespace Aplication.Feautres.Clientes.Commands.DeleteClienteCommand
{
    public class DeleteClienteCommandValidator : AbstractValidator<DeleteClienteCommand>
    {
        public DeleteClienteCommandValidator()
        {
            RuleFor(p => p.Id)
                 .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.");
        }
    }
}
