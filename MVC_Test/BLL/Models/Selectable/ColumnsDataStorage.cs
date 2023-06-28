namespace BLL.Models.Selectable
{
    public static class ColumnsDataStorage
    {
        public static List<SelectableTableColumnData> GetColumnsData(Type type)
        {
            switch (type.Name)
            {
                case "Message":
                    return new List<SelectableTableColumnData>()
                    {
                        new SelectableTableColumnData
                        {
                            HeaderText = "MessageId",
                            PropertyName = "Id",
                            CellType = SelectableTableCellType.ActionLink
                        },
                        new SelectableTableColumnData
                        {
                            HeaderText = "Name",
                            PropertyName = "Name",
                        },
                        new SelectableTableColumnData
                        {
                            HeaderText = "Type",
                            PropertyName = "Type",
                        },
                        new SelectableTableColumnData
                        {
                            HeaderText = "Description",
                            PropertyName = "Description",
                            CellType = SelectableTableCellType.Label
                        },
                    };
                    break;
                case "MessageHistory":
                    return new List<SelectableTableColumnData>()
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
                        new SelectableTableColumnData
                        {
                            HeaderText = "CreateAt",
                            PropertyName = "CreateAt",
                            CellType = SelectableTableCellType.Label
                        },
                        new SelectableTableColumnData
                        {
                            HeaderText = "UpdateAt",
                            PropertyName = "UpdateAt",
                            CellType = SelectableTableCellType.Label
                        },
                    };
                default: return new List<SelectableTableColumnData>();
            }

        }
    }
}
