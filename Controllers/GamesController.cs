

namespace GameZone.Controllers
{
	public class GamesController : Controller
	{
		// private readonly ApplicationDbContext _context;
		private readonly ICategoriesService _categoriesService;
		private readonly IDevicesService _devicesService;




		public GamesController(ICategoriesService categoriesService, IDevicesService devicesService)
		{
			_categoriesService = categoriesService;
			_devicesService = devicesService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet] // by default
		public IActionResult Create()
		{
			//var categories= _context.Categories.ToList();
			CreateGameFormViewModel viewModel = new()
			{

				Categories = _categoriesService.GetSelectList(),
				Devices = _devicesService.GetSelectList()
			};
			return View(viewModel);
		}
		[HttpPost] // by default
		[ValidateAntiForgeryToken]// layer of security
		public IActionResult Create(CreateGameFormViewModel model)
		{
			if (!ModelState.IsValid)
			{
				model.Categories = _categoriesService.GetSelectList();

				model.Devices = _devicesService.GetSelectList();

				return View(model);
			}
			// save game to database

			// save cover to server
			return RedirectToAction(nameof(Index));

		}
	}
}
