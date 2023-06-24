namespace BLL.Models
{
    public class SelectableItem
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public bool Selected { get; set; }
        public int NumberInTable { get; set; }
    }
}
