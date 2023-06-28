namespace BLL.Models.Selectable.Interfaces
{
    public interface ISelectableTableItem<T> where T : class
    {
        public T ItemData { get; set; }
        public bool IsSelected { get; set; }
        public string GetValue(string propertyName);
    }
}
