using Dedsi.Ddd.CQRS.Commands;

namespace Dedsi.Ddd.CQRS.Mediators;

public interface IDedsiMediator
{
    /// <summary>
    /// �޷���ֵ
    /// </summary>
    /// <param name="command"></param>
    /// <param name="onUnitOfWorkComplete"></param>
    /// <returns></returns>
    Task PublishAsync(IDedsiCommand command, bool onUnitOfWorkComplete = true);

    /// <summary>
    /// �з���ֵ
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TResponse> PublishAsync<TResponse>(IDedsiCommand<TResponse> request, CancellationToken cancellationToken = default);
}
