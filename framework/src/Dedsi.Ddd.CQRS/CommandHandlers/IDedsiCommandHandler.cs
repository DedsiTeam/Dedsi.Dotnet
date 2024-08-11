using Dedsi.Ddd.CQRS.Commands;
using MediatR;
using Volo.Abp.DependencyInjection;

namespace Dedsi.Ddd.CQRS.CommandHandlers;


public interface IDedsiCommandHandler : ITransientDependency;

public interface IDedsiCommandHandler<in TCommand> : IDedsiCommandHandler, IRequestHandler<TCommand> where TCommand : IDedsiCommand;

public interface IDedsiCommandHandler<in TCommand, TResponse> : IDedsiCommandHandler, IRequestHandler<TCommand, TResponse> where TCommand : IDedsiCommand<TResponse>;