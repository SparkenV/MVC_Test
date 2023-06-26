using BLL.Models;

namespace MVC_Test.Models.SelectableItems
{
    public class SelectableItemsViewModel
    {
        public SelectableItemsViewModel() 
        {
            SelectableTableViewModel = new SelectableTableViewModel<Message>();
            SelectableTableViewModel.ColumnNames.AddRange(new string[]{ "", "Name", "Type", "Description" });
        }

        public SelectableTableViewModel<Message> SelectableTableViewModel { get; set; }
    }
}
