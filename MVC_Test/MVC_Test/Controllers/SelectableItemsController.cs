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
            var model = TempData["SelectableItemsViewModel"] as SelectableItemsViewModel;

            if (model == null)
            {
                model = new SelectableItemsViewModel();
                model.SelectableTableViewModel.Items = DummyDataHelper.GetSelectableItems(10);
            }

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Index(SelectableItemsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return View("Index", viewModel);
            }
            else 
            {
                return View("Index", viewModel);
            }
        }

        public IActionResult Rebind(SelectableItemsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Request.Method == "POST")
                {
                    var c = viewModel.SelectableTableViewModel.Items.Count(i =>
                    {
                        if (i.IsSelected)
                        {
                            System.Diagnostics.Debug.WriteLine($"Rebind. Id: {i.ItemData.Id}");
                        }

                        return i.IsSelected;
                    });

                    System.Diagnostics.Debug.WriteLine($"Rebind Action for {c} items!");
                    return View("Index", viewModel);
                }
                else
                {
                    return Index();
                }                
            }

            throw new Exception("InvalidModel");
        }

        public IActionResult Rebatch(SelectableItemsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Request.Method == "POST")
                {
                    var c = viewModel.SelectableTableViewModel.Items.Count(i =>
                    {
                        if (i.IsSelected)
                        {
                            System.Diagnostics.Debug.WriteLine($"Rebatch. Id: {i.ItemData.Id}");
                        }

                        return i.IsSelected;
                    });

                    System.Diagnostics.Debug.WriteLine($"Rebatch Action for {c} items!");
                    return View("Index", viewModel);
                }
                else
                {
                    return Index();
                }
            }

            throw new Exception("InvalidModel");
        }
    }
}
