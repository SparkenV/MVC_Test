namespace BLL.Models.Selectable
{
    public class ActionLinkColumnData : SelectableTableColumnData
    {
        public ActionLinkColumnData() 
        {
            CellType = SelectableTableCellType.ActionLink;
        }

        public string ViewName { get; set; } = "Index";
        public string ControllerName { get; set; } = string.Empty;
    }
}
