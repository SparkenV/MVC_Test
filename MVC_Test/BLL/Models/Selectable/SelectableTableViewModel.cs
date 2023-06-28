namespace BLL.Models.Selectable
{
    public class SelectableTableViewModel<T> where T : class
    {
        public SelectableTableViewModel()
        {
            ColumnsData = new List<SelectableTableColumnData>();
        }
        public List<SelectableTableColumnData> ColumnsData { get; set; } = new List<SelectableTableColumnData>();
        public List<SelectableItemViewModel<T>> Items { get; set; } = new List<SelectableItemViewModel<T>>();
    }
}
