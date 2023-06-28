using BLL;
using BLL.Models;
using BLL.Models.Selectable;
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
                model.SelectableTableViewModel.ColumnsData = new List<SelectableTableColumnData>()
                {
                    new SelectableTableColumnData
                    {
                        HeaderText = string.Empty,
                        PropertyName = "Id",
                        CellType = SelectableTableCellType.ActionLink
                    },
                    new SelectableTableColumnData
                    {
                        HeaderText = "Name",
                        PropertyName = "Name",
                        CellType = SelectableTableCellType.Label
                    },
                    new SelectableTableColumnData
                    {
                        HeaderText = "Type",
                        PropertyName = "Type",
                        CellType = SelectableTableCellType.Label
                    },
                    new SelectableTableColumnData
                    {
                        HeaderText = "Description",
                        PropertyName = "Description",
                        CellType = SelectableTableCellType.Label
                    },
                };
            }

            return View("Index", model);
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

        public IActionResult Rebind(SelectableItemsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Request.Method == "POST")
                {
                    var c = viewModel.SelectableTableViewModel.Items.Count(i => i.IsSelected);

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
                    var c = viewModel.SelectableTableViewModel.Items.Count(i => i.IsSelected);

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
