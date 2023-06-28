using BLL.Models.Selectable;

namespace MVC_Test.Models.SelectableItems
{
    public class SelectableItemsViewModel
    {
        public SelectableItemsViewModel() 
        {
            SelectableTableViewModel = new SelectableTableViewModel<object>();
        }

        public SelectableTableViewModel<object> SelectableTableViewModel { get; set; }
    }
}
