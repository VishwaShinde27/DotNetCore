using DotNetCoreWebAPI.Interfaces;

namespace DotNetCoreWebAPI.Models
{
    public class ProductDetails : IProductDetails
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public ProductDetails()
        {
            ProductName = "IPhone 11";
            ProductPrice = 100000;
            ProductQuantity = 1;
        }
        /// <summary>    
        /// Get properties values assigned in constructor    
        /// </summary>    
        /// <returns>Returns this object</returns>    
        public ProductDetails GetProductDetails()
        {
            return this;
        }

        
    }
}
