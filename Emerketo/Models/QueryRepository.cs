using Emerketo.Areas.Identity.Data;

namespace Emerketo.Models
{
	public class QueryRepository : IQueryRepository
	{
		private readonly EmerketoDbContext _context;

		public QueryRepository(EmerketoDbContext context)
		{
			_context = context;
		}

		public void AddQuery(Query query)
		{
			_context.Querys.Add(query);
			_context.SaveChanges();
		}
	}
}
