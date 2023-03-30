using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO: Pending to change to the correct path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://shoppingbydaniel.azurewebsites.net/images/No_image.png"
            : $"https://shopping8.blob.core.windows.net/products/{ImageId}";

    }
}
