using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPAECom.Api.Catalog.Data.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Product name is required!")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(1, 1000, ErrorMessage = "Product price must be between 1 to 1000!")]
        public double UnitPrice { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Product category is required!")]
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
