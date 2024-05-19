using MediatR;

namespace AssemblyService.Application.CQRS.Commands.CompletedSlotCommands
{
    public record CreateCompletedSlotRangeCommand : IRequest;
}
