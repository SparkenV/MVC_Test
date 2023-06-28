namespace BLL.Models
{
    public class SelectableTableViewModel<T> where T : class
    {
        public SelectableTableViewModel() 
        {
            ColumnNames = new List<string>()
            {
                ""
            };
        }
        public List<string> ColumnNames { get; set; } = new List<string>();
        public List<SelectableItem> Items { get; set; } = new List<SelectableItem>();
    }
}
