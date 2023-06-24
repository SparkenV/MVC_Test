using BLL;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_Test.Models.SelectableItems;

namespace MVC_Test.Controllers
{
    public class SelectableItemsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new SelectableItemsViewModel
            {
                Id = Guid.NewGuid().ToString()
            };

            model.SelectableTableViewModel = new SelectableTableViewModel();
            model.SelectableTableViewModel.SelectableItems = DummyDataHelper.GetSelectableItems(10).ToArray();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(SelectableItemsViewModel viewModel)
        {
            return View(viewModel);
        }

        [Route("selectable/print")]
        [HttpPost]
        public PartialViewResult Action(SelectableItemsViewModel viewModel)
        {
            return new PartialViewResult();
        }
    }
}
