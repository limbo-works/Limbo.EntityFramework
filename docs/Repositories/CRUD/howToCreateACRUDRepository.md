# How to create a CRUD repository

```csharp
using Limbo.EntityFramework.Repositories.Crud;
using Microsoft.Extensions.Logging;

namespace MyNamespace.Repositories {
    public class MyRepository : DbCrudRepositoryBase<MyModel>, IMyRepository {
        public MyRepository(IDbContextFactory<MyDbContext> contextFactory, ILogger<DbCrudRepositoryBase<MyModel>> logger) : base(dbContext, logger) {
        }
    }
}
```

```csharp
using Limbo.EntityFramework.Repositories.Crud;

namespace MyNamespace.Repositories {
    public interface IMyRepository : IDbCrudRepositoryBase<MyModel> {
    }
}
```