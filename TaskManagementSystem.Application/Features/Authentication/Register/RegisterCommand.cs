using MediatR;

namespace TaskManagementSystem.Application.Features.Authentication.Register;

public sealed record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
) : IRequest<Guid>;
