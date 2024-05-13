using System.ComponentModel.DataAnnotations;

namespace AuthenticationRoleBase.Models
{
    public class Item
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; } = "";

        public int Unit { get; set; }

        public int Quantity { get; set; }

        [MaxLength(150)]
        public string ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }


    }
}
