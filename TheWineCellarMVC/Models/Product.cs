using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    public class Product
    {
        // Table containing the product details -> Entered into DB
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage="Enter a Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Enter a Product Description")]
        public string ProductDescription { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Enter the Product Price")]
        public decimal ProductPrice { get; set; }

        [DisplayName("Product Qauntity")]
        [Required(ErrorMessage = "Enter the Product Quantity")]
        public int ProductQuantity { get; set; }

        [DisplayName("Product Image")]
        [Required(ErrorMessage = "Insert a URL for Product Image")]
        public string ProductImage { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "Select the Date")]
        public DateTime Date { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "Select the Product Category")]
        public string Category { get; set; }

        [DisplayName("Farmer Email")]
        public string FarmerEmail { get; set; }

        // Foreign Key
        public string FarmerId { get; set; }
    }
}
