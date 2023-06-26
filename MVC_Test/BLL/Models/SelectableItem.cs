using BLL.Models.Interfaces;

namespace BLL.Models
{
    public class SelectableItem : ISelectableTableItem<Message>
    {
        public Message ItemData { get; set; }
        public bool IsSelected { get; set; }
    }
}
