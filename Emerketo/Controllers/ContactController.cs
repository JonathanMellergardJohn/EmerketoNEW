using Emerketo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emerketo_webapp.Controllers
{
    public class ContactController : Controller
    {
		private readonly IQueryRepository _queryRepository;

		public ContactController(IQueryRepository queryRepository)
		{
			_queryRepository = queryRepository;
		}
		public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult SubmitQuery(Query query)
		{
			// Add the query to the database using the QueryRepository
			_queryRepository.AddQuery(query);

			// Redirect to a success page or perform any other necessary actions

			return RedirectToAction("Success");
		}
	}

	

	



	
}
