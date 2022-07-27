using DotNetCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Interfaces
{
   public interface IProductDetails
    {
        ProductDetails GetProductDetails();
    }
}
