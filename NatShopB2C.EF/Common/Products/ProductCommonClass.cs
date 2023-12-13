using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Common.Products
{
    public class ProductCommonClass
    {
        private readonly ApplicationDbContext _db;
        private readonly BusinessClass _bc;
        Currency CC = new Currency();
        public ProductCommonClass(ApplicationDbContext db, BusinessClass bc)
        {
            _db = db;
            _bc = bc;
        }

        public async Task<ProductVariation> GetProductVarientsByProductVarientID(Guid? ProductVarientID)
        {
            try
            {
                var objProductVarients = await _db.ProductVariations.Where(x => x.Id == ProductVarientID && x.IsDelete == false).AsNoTracking().FirstOrDefaultAsync();
                return objProductVarients;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string CalculateDiscountOnProduct(Product objProduct, bool IsDiscountCaption, decimal? Price)
        {
            string Discounttext = "";
            decimal oldPrice;
            if (Price != null)
            {
                oldPrice = (decimal)Price;
            }
            else
            {
                oldPrice = (decimal)objProduct.Price;
            }

            List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(oldPrice));
            if (PriceList != null)
            {
                oldPrice = Convert.ToDecimal(PriceList[2]);
            }

            DiscountOptioin objDiscount = GetFlatDiscountOptionOnProducts(objProduct.Id, (int)objProduct.BrandId, (int)objProduct.CategoryId, 1, oldPrice);
            if (objDiscount != null)
            {
                if ((_bc.ToClientDateTimeZone(objDiscount.Discount.StartDate).Value.Date <= System.DateTime.Now.ToUniversalTime().Date && _bc.ToClientDateTimeZone(objDiscount.Discount.EndDate).Value.Date >= System.DateTime.Now.ToUniversalTime().Date))
                {
                    string DiscountCaption = "";
                    if (!string.IsNullOrEmpty(objDiscount.Caption))
                    {
                        DiscountCaption = objDiscount.Caption.ToString().Trim();
                    }
                    decimal discountval = (decimal)objDiscount.DiscountValue;
                    byte discountvaltype = (byte)objDiscount.DiscountValueTypeId;
                    string[,] CalculatedValue = _bc.CalculateDiscountValue(oldPrice, discountval, discountvaltype);
                    if (CalculatedValue != null)
                    {
                        Discounttext += " <div class='product-price-block'>";
                        Discounttext += "<div class='product-offerprice'>";
                        Discounttext += "<span class='deductedprice'>";
                        Discounttext += "<span class='currency-icon'><i class='" + CC.Icon + "'></i></span>";
                        Discounttext += _bc.FormatCurrencyPrice(Convert.ToDecimal(oldPrice));
                        //old code by mayur
                        //Discounttext += "<span class='currency-icon'><i class='fa-rupee'></i></span>";
                        //Discounttext += string.Format("{0:#,#0.00}", oldPrice);
                        Discounttext += "</span>";
                        Discounttext += " ";
                        if (IsDiscountCaption)
                        {
                            Discounttext += "<span>" + DiscountCaption + "</span>";
                        }
                        Discounttext += "</div>";

                        //Discounttext += "<div class='product-price'><span class='currency-icon'><i class='fa-rupee'></i></span>" + oldPrice + "</div></div>";

                        Discounttext += _bc.FormatCurrencyPrice(Convert.ToDecimal(CalculatedValue[0, 1].ToString()));
                        //Discounttext += "<div class='product-price'><span class='currency-icon'><i class='" + CC.Icon + "'></i></span>" + BC.FormatCurrencyPrice(Convert.ToDecimal(CalculatedValue[0, 1].ToString())) + "</div></div>";
                        //old code by mayur
                        //Discounttext += "<div class='product-price'><span class='currency-icon'><i class='fa-rupee'></i></span>" + CalculatedValue[0, 1].ToString() + "</div></div>";
                    }
                    else
                    {
                        Discounttext += _bc.FormatCurrencyPrice(Convert.ToDecimal(oldPrice));
                        //Discounttext += "<div class='product-price-block'><div class='product-price'><span class='currency-icon'><i class='" + CC.Icon + "'></i></span>" + BC.FormatCurrencyPrice(Convert.ToDecimal(oldPrice)) + "</div></div>";
                        //old code by mayur
                        //Discounttext += "<div class='product-price-block'><div class='product-price'><span class='currency-icon'><i class='fa-rupee'></i></span>" + string.Format("{0:#,#0.00}", oldPrice) + "</div></div>";
                    }
                }
                else
                {
                    Discounttext += _bc.FormatCurrencyPrice(Convert.ToDecimal(oldPrice));
                    //Discounttext += "<div class='product-price-block'><div class='product-price'><span class='currency-icon'><i class='" + CC.Icon + "'></i></span>" + BC.FormatCurrencyPrice(Convert.ToDecimal(oldPrice)) + "</div></div>";
                    //old code by mayur
                    //Discounttext += "<div class='product-price-block'><div class='product-price'><span class='currency-icon'><i class='fa-rupee'></i></span>" + string.Format("{0:#,#0.00}", oldPrice) + "</div></div>";
                }
            }
            else
            {
                Discounttext += _bc.FormatCurrencyPrice(Convert.ToDecimal(oldPrice));
                //Discounttext += "<div class='product-price-block'><div class='product-price'><span class='currency-icon'><i class='" + CC.Icon + "'></i></span>" + BC.FormatCurrencyPrice(Convert.ToDecimal(oldPrice)) + "</div></div>";
                //old code by mayur
                //Discounttext += "<div class='product-price-block'><div class='product-price'><span class='currency-icon'><i class='fa-rupee'></i></span>" + string.Format("{0:#,#0.00}", oldPrice) + "</div></div>";
            }
            return Discounttext;
        }
        public DiscountOptioin GetFlatDiscountOptionOnProducts(Guid ProductID, int BrandID, int CategoryID, int ProductQTY, decimal ProductPrice)
        {
            try
            {
                List<ProductDiscount> objProductDiscount = GetProductDiscountsByProductID(ProductID).Where(x => _bc.ToClientDateTimeZone(x.Discount.StartDate).Value.Date <= System.DateTime.Now.ToUniversalTime().Date && _bc.ToClientDateTimeZone(x.Discount.EndDate).Value.Date >= System.DateTime.Now.ToUniversalTime().Date).ToList();
                List<ProductDiscount> objBrandDisocunt = GetBrandDiscountsByBrandID(BrandID).Where(x => _bc.ToClientDateTimeZone(x.Discount.StartDate).Value.Date <= System.DateTime.Now.ToUniversalTime().Date && _bc.ToClientDateTimeZone(x.Discount.EndDate).Value.Date >= System.DateTime.Now.ToUniversalTime().Date).ToList();
                List<ProductDiscount> objCateogryDiscount = GetCategoryDiscountsByCategoryID(CategoryID).Where(x => _bc.ToClientDateTimeZone(x.Discount.StartDate).Value.Date <= System.DateTime.Now.ToUniversalTime().Date && _bc.ToClientDateTimeZone(x.Discount.EndDate).Value.Date >= System.DateTime.Now.ToUniversalTime().Date).ToList();

                List<DiscountOptioin> objDiscountOption = new List<DiscountOptioin>();
                foreach (ProductDiscount pitem in objProductDiscount.Where(x => x.DiscountOption.MinBreakPoint == 1 && x.DiscountOption.MaxBreakPoin == 9999999))
                {
                    if (pitem.DiscountOption.BreakPointCode.ToString().Trim().Equals("q"))
                    {
                        int lowerbound = Convert.ToInt32(pitem.DiscountOption.MinBreakPoint);
                        int upperbound = Convert.ToInt32(pitem.DiscountOption.MaxBreakPoin);
                        if (ProductQTY >= lowerbound && ProductQTY <= upperbound)
                        {
                            objDiscountOption.Add(pitem.DiscountOption);
                        }
                    }

                    if (pitem.DiscountOption.BreakPointCode.ToString().Trim().Equals("p"))
                    {
                        int? MinBreakPoint;
                        int? MaxBreakPoint;
                        List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(pitem.DiscountOption.MinBreakPoint));
                        {
                            MinBreakPoint = Convert.ToInt32(Math.Round(Convert.ToDecimal(PriceList[2]), 0));
                        }

                        List<object> PriceList1 = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(pitem.DiscountOption.MaxBreakPoin));
                        {
                            MaxBreakPoint = Convert.ToInt32(Math.Round(Convert.ToDecimal(PriceList1[2]), 0));
                        }

                        int lowerbound = Convert.ToInt32(MinBreakPoint);
                        int upperbound = Convert.ToInt32(MaxBreakPoint);
                        if (ProductPrice >= lowerbound && ProductPrice <= upperbound)
                        {
                            objDiscountOption.Add(pitem.DiscountOption);
                        }
                    }
                }
                foreach (ProductDiscount bitem in objBrandDisocunt.Where(x => x.DiscountOption.MinBreakPoint == 1 && x.DiscountOption.MaxBreakPoin == 9999999))
                {
                    if (bitem.DiscountOption.BreakPointCode.ToString().Trim().Equals("q"))
                    {
                        int lowerbound = Convert.ToInt32(bitem.DiscountOption.MinBreakPoint);
                        int upperbound = Convert.ToInt32(bitem.DiscountOption.MaxBreakPoin);
                        if (ProductQTY >= lowerbound && ProductQTY <= upperbound)
                        {
                            objDiscountOption.Add(bitem.DiscountOption);
                        }
                    }

                    if (bitem.DiscountOption.BreakPointCode.ToString().Trim().Equals("p"))
                    {
                        int? MinBreakPoint;
                        int? MaxBreakPoint;
                        List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(bitem.DiscountOption.MinBreakPoint));
                        {
                            MinBreakPoint = Convert.ToInt32(Math.Round(Convert.ToDecimal(PriceList[2]), 0));
                        }

                        List<object> PriceList1 = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(bitem.DiscountOption.MaxBreakPoin));
                        {
                            MaxBreakPoint = Convert.ToInt32(Math.Round(Convert.ToDecimal(PriceList1[2]), 0));
                        }

                        int lowerbound = Convert.ToInt32(MinBreakPoint);
                        int upperbound = Convert.ToInt32(MaxBreakPoint);
                        if (ProductPrice >= lowerbound && ProductPrice <= upperbound)
                        {
                            objDiscountOption.Add(bitem.DiscountOption);
                        }
                    }
                }

                foreach (ProductDiscount citem in objCateogryDiscount.Where(x => x.DiscountOption.MinBreakPoint == 1 && x.DiscountOption.MaxBreakPoin == 9999999))
                {
                    if (citem.DiscountOption.BreakPointCode.ToString().Trim().Equals("q"))
                    {
                        int lowerbound = Convert.ToInt32(citem.DiscountOption.MinBreakPoint);
                        int upperbound = Convert.ToInt32(citem.DiscountOption.MaxBreakPoin);
                        if (ProductQTY >= lowerbound && ProductQTY <= upperbound)
                        {
                            objDiscountOption.Add(citem.DiscountOption);
                        }
                    }

                    if (citem.DiscountOption.BreakPointCode.ToString().Trim().Equals("p"))
                    {
                        int? MinBreakPoint;
                        int? MaxBreakPoint;
                        List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(citem.DiscountOption.MinBreakPoint));
                        {
                            MinBreakPoint = Convert.ToInt32(Math.Round(Convert.ToDecimal(PriceList[2]), 0));
                        }

                        List<object> PriceList1 = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(citem.DiscountOption.MaxBreakPoin));
                        {
                            MaxBreakPoint = Convert.ToInt32(Math.Round(Convert.ToDecimal(PriceList1[2]), 0));
                        }

                        int lowerbound = Convert.ToInt32(MinBreakPoint);
                        int upperbound = Convert.ToInt32(MaxBreakPoint);
                        if (ProductPrice >= lowerbound && ProductPrice <= upperbound)
                        {
                            objDiscountOption.Add(citem.DiscountOption);
                        }
                    }
                }
                return GetMaximumProfitDiscountOptionOnProduct(objDiscountOption, ProductPrice);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<ProductDiscount> GetProductDiscountsByProductID(Guid ProductID)
        {
            try
            {
                var objProductDiscount = _db.ProductDiscounts.Where(x => x.ProductId == ProductID && x.ProductVariationId == null && x.BrandId == null && x.CategoryId == null && x.IsActive == true && x.Discount.IsDelete == false).AsNoTracking().ToList();
                return objProductDiscount;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<ProductDiscount> GetBrandDiscountsByBrandID(int BrandID)
        {
            try
            {
                var objBrandDiscount = _db.ProductDiscounts.Where(x => x.ProductId == null && x.ProductVariationId == null && x.BrandId == BrandID && x.CategoryId == null && x.IsActive == true && x.IsDelete == false).ToList();
                return objBrandDiscount;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<ProductDiscount> GetCategoryDiscountsByCategoryID(int CategoryID)
        {
            try
            {
                var objCategoryDiscount = _db.ProductDiscounts.Where(x => x.ProductId == null && x.ProductVariationId == null && x.BrandId == null && x.CategoryId == CategoryID && x.IsActive == true && x.IsDelete == false).ToList();
                return objCategoryDiscount;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DiscountOptioin GetMaximumProfitDiscountOptionOnProduct(List<DiscountOptioin> objDiscountoptions, decimal objProductPrice)
        {
            try
            {

                decimal[] CalcualteValue = new decimal[objDiscountoptions.Count];
                int index = 0;
                foreach (DiscountOptioin item in objDiscountoptions)
                {
                    //absolute
                    if (item.DiscountValueTypeId == 1)
                    {
                        decimal DiscountValue = 0;
                        List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(Convert.ToDecimal(item.DiscountValue));
                        if (PriceList != null)
                        {
                            DiscountValue = Convert.ToDecimal(PriceList[2]);
                        }
                        decimal newvalue = objProductPrice - DiscountValue;
                        //old code by mayur
                        //decimal newvalue = objProductPrice - (decimal)item.DiscountValue;
                        CalcualteValue[index] = newvalue;
                    }
                    else if (item.DiscountValueTypeId == 2) //percentage
                    {
                        decimal? newvalue = Convert.ToDecimal(objProductPrice - ((objProductPrice * ((decimal)item.DiscountValue)) / 100));

                        //added by bhavesh patel
                        newvalue = _bc.ConvertPriceAccordingToRoundType(Convert.ToDecimal(newvalue));
                        if (newvalue != null)
                        {
                            CalcualteValue[index] = Convert.ToDecimal(newvalue);
                        }
                    }
                    index++;
                }
                decimal MaxCalculatePrice = CalcualteValue.Min();
                index = 0;
                foreach (decimal item in CalcualteValue)
                {
                    if (item.Equals(MaxCalculatePrice))
                    {
                        break;
                    }
                    index++;
                }
                return objDiscountoptions[index];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool IsProductOutofStock(Product objProduct, int quantity, out int AvailableStockQty)
        {
            bool IsOutOfStock = true;
            AvailableStockQty = 0;
            try
            {
                if (objProduct != null)
                {
                    switch (objProduct.StockTypeId)
                    {
                        case 1:
                            //Available
                            IsOutOfStock = false;
                            break;
                        case 2:
                            //InStock
                            if (objProduct.StockQuantity != null)
                            {
                                if (objProduct.StockQuantity >= quantity)
                                {
                                    IsOutOfStock = false;
                                }
                                else
                                {
                                    AvailableStockQty = (int)objProduct.StockQuantity;
                                    IsOutOfStock = true;
                                }
                            }
                            else
                            {
                                IsOutOfStock = true;
                            }
                            break;
                        case 3:
                            //Not available
                            IsOutOfStock = true;
                            break;
                        case 4:
                            //Pre-Order
                            IsOutOfStock = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    IsOutOfStock = true;
                }
            }
            catch (Exception ex)
            {
                IsOutOfStock = true;
            }
            return IsOutOfStock;
        }
        public List<ProductImageDTO> GetProductImagesForClient(Guid? ProductVariantID)
        {
            List<ProductImageDTO> _objProductImages = null;
            //string subdomain = GetCurrentSubDomain();
            try
            {
                _objProductImages = (from _ProductVariantImages in _db.ProductVariationImages
                                     where _ProductVariantImages.ProductVariationId.Equals(ProductVariantID) && _ProductVariantImages.Image.IsActive == true && _ProductVariantImages.Image.IsDelete == false
                                     orderby _ProductVariantImages.ImageOrderNo ascending
                                     select new ProductImageDTO
                                     {
                                         ImageID = _ProductVariantImages.ImageId,
                                         ProductID = _ProductVariantImages.ProductVariation.ProductId,
                                         ProductVariantID = _ProductVariantImages.ProductVariation.Id,
                                         ImageOrderNo = (Int32)_ProductVariantImages.ImageOrderNo,
                                         LargeImagePath = _ProductVariantImages.Image.ImagePath
                                         //LargeImagePath = subdomain + _ProductVariantImages.Image.ImagePath.Replace("~", "")
                                         //SmallImagePath = subdomain + _ProductVariantImages.Image.ImagePath.Replace("~/UploadImages/Products/" + _ProductVariantImages.ProductVariation.ProductID + "/" + _ProductVariantImages.ProductVariation.ID, "/UploadImages/Products/" + _ProductVariantImages.ProductVariation.ProductID + "/" + _ProductVariantImages.ProductVariation.ID + "/_thumbnail/Small"),
                                         //MediumImagePath = subdomain + _ProductVariantImages.Image.ImagePath.Replace("~/UploadImages/Products/" + _ProductVariantImages.ProductVariation.ProductID + "/" + _ProductVariantImages.ProductVariation.ID, "/UploadImages/Products/" + _ProductVariantImages.ProductVariation.ProductID + "/" + _ProductVariantImages.ProductVariation.ID + "/_thumbnail/medium")
                                     }).ToList<ProductImageDTO>();
            }
            catch (Exception ex)
            {
                return _objProductImages;
            }
            return _objProductImages;

        }
        public List<ProductSpecificationDTO> GetAllProductSpecificationByProductID(Guid? ProductID)
        {
            List<ProductSpecificationDTO> _objProductSpecification = null;
            try
            {
                _objProductSpecification = (from _ProductSpecification in _db.ProductSpecifications
                                            join s in _db.Specifications on _ProductSpecification.SpecificationId equals s.Id
                                            join g in _db.SpecificationGroups on _ProductSpecification.SpecificationGroupId equals g.Id
                                            where _ProductSpecification.ProductId == ProductID && s.IsActive == true && s.IsDelete == false && g.IsActive == true && g.IsDelete == false
                                            orderby _ProductSpecification.Specification.SpecificationName ascending
                                            select new ProductSpecificationDTO
                                            {
                                                ProductID = _ProductSpecification.ProductId,
                                                SpecificationName = s.SpecificationName,
                                                Value = _ProductSpecification.Value,
                                                SpecificationID = _ProductSpecification.SpecificationId,
                                                GroupID = (int)_ProductSpecification.SpecificationGroupId,
                                                GroupName = g.SpecificationGroupName
                                            }).ToList<ProductSpecificationDTO>();
            }
            catch (Exception ex)
            {
                return _objProductSpecification;
            }
            return _objProductSpecification;
        }
        public List<ProductVariationPrice> GetProductVarientPriceByProductVarientID(Guid? ProductVarientID, string filter)
        {
            List<ProductVariationPrice> objProductVarientPrice = null;
            try
            {
                string _sFilterBy = _bc.FilterValue(filter);
                if (_sFilterBy.Trim() != "")
                {
                    bool _bFilterBy = Convert.ToBoolean(_sFilterBy);
                    objProductVarientPrice = (from _ProductVarientPrice in _db.ProductVariationPrices
                                              join pv in _db.ProductVariations on _ProductVarientPrice.ProductVariationId equals pv.Id
                                              where _ProductVarientPrice.ProductVariationId.Equals(ProductVarientID) && pv.IsDelete == false && pv.IsActive == _bFilterBy
                                              select _ProductVarientPrice).ToList();
                }
                else
                {
                    objProductVarientPrice = (from _ProductVarientPrice in _db.ProductVariationPrices
                                              join pv in _db.ProductVariations on _ProductVarientPrice.ProductVariationId equals pv.Id
                                              where _ProductVarientPrice.ProductVariationId.Equals(ProductVarientID) && pv.IsDelete == false
                                              select _ProductVarientPrice).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return objProductVarientPrice;
        }
    }
}
