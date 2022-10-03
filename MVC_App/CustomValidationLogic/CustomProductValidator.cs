using Application.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_App.CustomValidationLogic
{
    public class CustomProductValidator
    {
        public bool Validate(Product product)
        {
            if (String.IsNullOrEmpty(product.ProductId) || product.ProductId.Length > 50 ||
                  String.IsNullOrEmpty(product.ProductName) || String.IsNullOrEmpty(product.Manufacturer) ||
                  String.IsNullOrEmpty(product.Description))
                return false;
            return true;
        }
    }
}