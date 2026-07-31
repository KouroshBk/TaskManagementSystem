using MediatR;

namespace TaskManagementSystem.Application.Features.Authentication.Register;

public class RegisterCommandHandler
    : IRequestHandler<RegisterCommand, Guid>
{
    public Task<Guid> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
