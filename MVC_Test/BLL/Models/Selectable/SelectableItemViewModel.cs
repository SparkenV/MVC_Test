using BLL.Models.Selectable.Interfaces;
using System.Diagnostics;

namespace BLL.Models.Selectable
{
    public class SelectableItemViewModel<T> : ISelectableTableItem<T> where T : class
    {
        public T ItemData { get; set; }
        public bool IsSelected { get; set; }
        public Type ItemType { get; set; }

        public string GetValue(string propertyName)
        {
            var result = ItemType.GetProperty(propertyName).GetValue(ItemData).ToString();
            Debug.WriteLine($"Name: {propertyName}; Value: {result}");
            return result;
        }
    }
}
