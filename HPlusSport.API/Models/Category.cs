namespace HPlusSport.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;2

        public virtual List<Product>? Products { get; set; }
    }
}
