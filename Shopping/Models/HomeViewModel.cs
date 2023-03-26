using Shopping.Data.Entities;
using Shopping.Common;

namespace Shopping.Models
{
    public class HomeViewModel
    {
        //public PaginatedList<Product> Products { get; set; }

        public ICollection<Product> Products { get; set; }

        public float Quantity { get; set; }

    }
}
