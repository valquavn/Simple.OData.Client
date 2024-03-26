using System.Data.Entity;

namespace Simple.OData.Tests.Shared.ActionProvider;

public class EntityFrameworkActionProvider : ActionProvider
{
	public EntityFrameworkActionProvider(DbContext dbContext) : base(dbContext, new EntityFrameworkParameterMarshaller())
	{
	}
}
