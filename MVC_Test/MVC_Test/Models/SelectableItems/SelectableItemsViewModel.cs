using BLL.Models;
using static System.Formats.Asn1.AsnWriter;

namespace MVC_Test.Models.SelectableItems
{
    public class SelectableItemsViewModel
    {
        public SelectableItemsViewModel() 
        {
            SelectableTableViewModel = new SelectableTableViewModel
            {
                ColumnNames = new List<string>()
                {
                    "Selected", "#", "Name", "Type", "Description"
                }
            };
        }

        public SelectableTableViewModel SelectableTableViewModel { get; set; }
    }
}
