using Volo.Abp.Auditing;

namespace Dedsi.Ddd.Domain.Auditing.Contracts;

public interface IDedsiMayHaveCreator : IHasCreationName, IMayHaveCreator;