using System.Diagnostics;
namespace BLL.Models.Selectable
{
    public class SelectableItemViewModel
    {
        public Message ItemData { get; set; }
        public bool IsSelected { get; set; }

        public string GetValue(string propertyName)
        {
            var result = ItemData.GetType().GetProperty(propertyName).GetValue(ItemData).ToString();
            Debug.WriteLine($"Name: {propertyName}; Value: {result}");
            return result;
        }
    }
}