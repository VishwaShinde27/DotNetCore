using DotNetCoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Models
{
    public class ProductDataAccess
    {
        #region Properties      
        //Has-ARelationship      
        public ProductDetails ProductData;
        #endregion

        //[Dependency]
        //public IProductDetails productData { get; set; }

        #region Constructor injection      
        public ProductDataAccess(IProductDetails _productDetails)
        {
            //here we have problem      
            ProductData = new ProductDetails();
        }
        #endregion


        ///// <summary>    
        ///// This method prints product details using Property DI    
        ///// </summary>    
        //public void PrintProductDetailsWithPropDI()
        //{
        //    ProductDetails ProdDetails = productData.GetProductDetails();
        //    Console.WriteLine("***********************************Receipt From Property/Setter DI***********************************");
        //    Console.WriteLine("                Product :" + ProdDetails.ProductName);
        //    Console.WriteLine("                Price   :" + ProdDetails.ProductPrice);
        //    Console.WriteLine("                Quantity:" + ProdDetails.ProductQuantity);
        //    Console.WriteLine("******************Thank you for shopping with Us !!!!!***********************");
        //}
        //#endregion
    }

}