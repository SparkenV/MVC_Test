using BLL.Models;
using BLL.Models.Selectable;

namespace MVC_Test.Models.SelectableItems
{
    public class SelectableItemsViewModel
    {
        public SelectableItemsViewModel() 
        {
            SelectableTableViewModel = new SelectableTableViewModel<Message>();
        }

        public SelectableTableViewModel<Message> SelectableTableViewModel { get; set; }
    }
}
