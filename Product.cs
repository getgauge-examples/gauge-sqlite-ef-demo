using System.ComponentModel.DataAnnotations.Schema;

namespace netcore.template
{
    [Table("Product")]
    public sealed class Product
    {
        public long ID {get; set;}
        public string ProductName {get; set;}
    }
}