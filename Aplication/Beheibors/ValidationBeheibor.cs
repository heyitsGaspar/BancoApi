using FluentValidation;
using MediatR;
namespace Aplication.Beheibors
{
    public class ValidationBeheibor<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validators;

        public ValidationBeheibor(IEnumerable<IValidator<TRequest>> validators)
        {
            this.validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if(validators.Any())
            {
                var context = new FluentValidation.ValidationContext<TRequest>(request);
                var validatioResults = await Task.WhenAll(validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validatioResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();

                if(failures.Count != 0)
                {
                    throw new Exceptions.ValidatioException(failures);
                }
            }
            return await next();
        }
    }
}
