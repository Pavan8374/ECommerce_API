using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Common.DTO.ProdutDTOs
{
    public class UpCommingProductDTO
    {
        public string ProductID { get; set; }
        public string ProductVariationID { get; set; }
        public string ProductName { get; set; }
        public string ProdcutDesc { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public string ImagePath { get; set; }
        public string ProductPriceID { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public bool IsAddToCartVisiable { get; set; }
        public bool IsAddToWishListVisiable { get; set; }
        public bool IsAddToCompareVisiable { get; set; }
        public bool IsPriceVisiable { get; set; }
        public bool IsOutofStock { get; set; }
    }
}
