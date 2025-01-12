namespace Dedsi.Ddd.Domain.Shared.EntityIds;

/// <summary>
/// 强类型Id
/// </summary>
public interface IEntityId;

public interface IStronglyTypedId<out TSource> : IEntityId
{
    TSource Id { get; }
}

public interface IInt64StronglyTypedId : IStronglyTypedId<Int64>;

public interface IGuidStronglyTypedId : IStronglyTypedId<Guid>;

public interface IUlidStronglyTypedId : IStronglyTypedId<Ulid>;