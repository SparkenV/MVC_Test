namespace BLL.Models
{
    public class SelectableTableViewModel
    {
        public List<string> ColumnNames { get; set; } = new List<string>();
        public List<SelectableItem> SelectableItems { get; set; } = new List<SelectableItem>();
    }
}
