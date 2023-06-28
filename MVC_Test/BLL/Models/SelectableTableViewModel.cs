using Microsoft.AspNetCore.Mvc.Rendering;

namespace BLL.Models.Selectable
{
    public class SelectableTableViewModel<T> where T : class
    {
        public SelectableTableViewModel()
        {
            ColumnsData = ColumnsDataStorage.GetColumnsData(typeof(Message));
        }
        public List<SelectableTableColumnData> ColumnsData { get; set; } = new List<SelectableTableColumnData>();
        public List<SelectableItemViewModel> Items { get; set; } = new List<SelectableItemViewModel>();


        public List<SelectListItem> FullListOfColumns => ColumnsData.Select(i => new SelectListItem(i.HeaderText, i.PropertyName)).ToList();
        public List<string> SelectedColumns { get; set; } = new List<string>();

        public List<string> ColumnsToShow => ColumnsData
            .Where(i => !SelectedColumns.Any() || SelectedColumns.Contains(i.PropertyName))
            .Select(i => i.PropertyName).ToList();
    }
}
