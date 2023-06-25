using BLL;
using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models.SelectableItems;

namespace MVC_Test.Controllers
{
    public class SelectableItemsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new SelectableItemsViewModel();
            model.SelectableTableViewModel.SelectableItems = DummyDataHelper.GetSelectableItems(10);

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(SelectableItemsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return View(viewModel);
            }
            else 
            {
                return View(viewModel);
            }
        }
    }
}
