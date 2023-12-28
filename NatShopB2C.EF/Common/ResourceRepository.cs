using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Common
{
    public enum FilterBy
    {
        All = 0,
        Active = 1,
        Inactive = 2
    }

    public enum AvailableSaleStatus
    {
        Pending = 1,
        Confirmed = 2,
        Packing = 3,
        Packed = 4,
        Dispatched = 5,
        Delivered = 6,
        Complete = 7,
        Cancelled = 8,
        Failed = 9,
        Aborted = 10,
        Invalid = 11,
        Initiate = 12
    }
    public class ResourceRepository : IResourceRepository
    {
        private readonly ApplicationDbContext _db;
        public ResourceRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        private delegate double RoundingFunction(double value);
        private enum RoundingDirection { Up, Down, Round }
        private static decimal GetRoundFuntion(double value, int precision, RoundingDirection roundingDirection)
        {
            RoundingFunction roundingFunction;
            if (roundingDirection == RoundingDirection.Up)
                roundingFunction = Math.Ceiling;
            else
                roundingFunction = Math.Floor;
            value *= Math.Pow(10, precision);
            value = roundingFunction(value);
            return Convert.ToDecimal(value * Math.Pow(10, -1 * precision));
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
        public Category GetCategory(int CategoryID)
        {
            try
            {
                var obj = _db.Categories.Where(x => x.Id == CategoryID).FirstOrDefault();
                return obj;
            }
            catch (Exception)
            {
                return null;
            }
        }
        internal static void LogException(Exception ex, object classLevel)
        {
            throw new NotImplementedException();
        }
        public List<ProductVariation> GetTop4PoplarProductVariant(int CategoryID, List<Guid> ExistsProductList = null)
        {
            List<ProductVariation> objProductVariants = null;
            List<ProductVariation> objVariants = new List<ProductVariation>();
            List<Guid> ProductIDList = null;
            try
            {
                objProductVariants = (from _ProductVariants in _db.ProductVariations
                                      where _ProductVariants.Product.CategoryId.Equals(CategoryID) && _ProductVariants.ProductVariationImages.Count > 0
                                      && _ProductVariants.IsActive == true && _ProductVariants.IsDelete == false
                                      && _ProductVariants.Product.IsActive == true && _ProductVariants.Product.IsDelete == false
                                      && _ProductVariants.Product.Category.IsActive == true && _ProductVariants.Product.Category.IsDelete == false
                                      && _ProductVariants.Product.Brand.IsActive == true && _ProductVariants.Product.Brand.IsDelete == false
                                      && _ProductVariants.Product.ProductType.IsShowInCatalog == true && _ProductVariants.Product.ProductType.IsActive == true && _ProductVariants.Product.ProductType.IsDelete == false
                                      orderby _ProductVariants.Popularity descending
                                      select _ProductVariants).ToList();

                //var obj = _db.ProductVariations.
                //    Where(x => x.Product.CategoryId == CategoryID && x.ProductVariationImages.Count > 0
                //    && x.IsActive == true && x.IsDelete == false
                //    && x.Product.IsActive == true && x.Product.IsDelete == false
                //    && x.Product.Category.IsActive == true && x.Product.Category.IsDelete == false
                //    && x.Product.Brand.IsActive == true && x.Product.Brand.IsDelete == false
                //    && x.Product.ProductType.IsShowInCatalog == true && x.Product.ProductType.IsActive == true
                //    && x.Product.ProductType.IsDelete == false).ToList();


                ProductIDList = objProductVariants.Select(x => x.ProductId).Distinct().ToList<Guid>().Take(4).ToList();
                if (ExistsProductList != null && ExistsProductList.Count > 0)
                {
                    objProductVariants = (from _P in objProductVariants
                                          where (!ExistsProductList.Contains(_P.ProductId))
                                          select _P).ToList();
                }

                foreach (ProductVariation item in objProductVariants)
                {
                    if (ProductIDList.Contains(item.ProductId))
                    {
                        objVariants.Add(item);
                        ProductIDList.Remove(item.ProductId);
                    }
                }
                return objVariants;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        
        public GenericRecordList<SalesStatus> GetSalesStatus()
        {
            GenericRecordList<SalesStatus> objSalesStatus = new GenericRecordList<SalesStatus>();
            try
            {
                objSalesStatus.RecordList = (from _SalesStatus in _db.SalesStatuses
                                             where _SalesStatus.IsActive.Equals(true)
                                             && _SalesStatus.IsDelete.Equals(false)
                                             select _SalesStatus).ToList();
            }
            catch (Exception ex)
            {

            }
            return objSalesStatus;
        }
        public class GenericRecordList<T> : GenericClass
        {
            public List<T> RecordList { get; set; }
            public int TotalRecords { get; set; }
            public GenericRecordList()
            {
                RecordList = new List<T>();
            }
        }
        public class GenericClass
        {
            public string ReturnCode { get; set; }
            public string ReturnMsg { get; set; }
            public string ReturnValue { get; set; }
            public GenericClass()
            {

            }
        }




        public List<object> ConvertPriceAccordingToCurrency(decimal? Price)
        {
            List<object> PriceList = null;
            try
            {
                if (Price != null)
                {
                    Currency objCurrency = GetCurrentCurrency();
                    if (objCurrency != null)
                    {
                        Price = (Convert.ToDecimal(Price) / objCurrency.Value);
                        Price = ConvertPriceAccordingToRoundType(Convert.ToDecimal(Price));
                        if (Price != null)
                        {
                            PriceList = new List<object>();
                            PriceList.Add(objCurrency.Icon);
                            PriceList.Add(FormatCurrencyPrice(Convert.ToDecimal(Price)));
                            PriceList.Add(Price);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                PriceList = null;
            }
            return PriceList;
        }

        public Currency GetCurrentCurrency()
        {
            Currency objCurrency = null;
            try
            {
                objCurrency = GetDefaultCurrency();
                //if (HttpContext.Current.Session["CurrentCurrency"] != null)
                //{
                //    objCurrency = (Currency)HttpContext.Current.Session["CurrentCurrency"];
                //}
                //else
                //{
                //    objCurrency = GetDefaultCurrency();
                //    if (objCurrency != null)
                //    {
                //        HttpContext.Current.Session["CurrentCurrency"] = objCurrency;
                //    }
                //}
            }
            catch (Exception Ex)
            {
                objCurrency = null;
            }
            return objCurrency;
        }
        public Currency GetDefaultCurrency()
        {
            Currency objCurrency = null;
            try
            {
                objCurrency = (from _Currency in _db.Currencies
                               where _Currency.IsDefaultCurrency == true && _Currency.IsActive == true && _Currency.IsDelete == false
                               select _Currency).FirstOrDefault();
            }
            catch (Exception Ex)
            {
                objCurrency = null;
            }
            return objCurrency;
        }
        public decimal? ConvertPriceAccordingToRoundType(decimal Price)
        {
            decimal? _dPrice = null;
            try
            {
                string DecimalPoint = "";
                string RoundType = "";
                SystemFlag _objsysflag = null;
                _objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysPriceDecimalPoint")).FirstOrDefault();
                if (_objsysflag != null)
                {
                    if (!string.IsNullOrEmpty(_objsysflag.Value.ToString().Trim()))
                    {
                        DecimalPoint = _objsysflag.Value.ToString().Trim();
                    }
                }
                _objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysPriceRoundType")).FirstOrDefault();
                if (_objsysflag != null)
                {
                    if (!string.IsNullOrEmpty(_objsysflag.Value.ToString().Trim()))
                    {
                        RoundType = _objsysflag.Value.ToString().Trim();
                    }
                }
                if (DecimalPoint != "" && RoundType != "")
                {
                    _dPrice = ConvertPriceToRoundType(DecimalPoint, RoundType, Price.ToString().Trim());
                }
            }
            catch (Exception Ex)
            {
                _dPrice = null;
            }
            return _dPrice;
        }
        public decimal? ConvertPriceToRoundType(string DecimalPoint, string RoundType, string Price)
        {
            decimal? _dPrice = null;
            try
            {
                switch (DecimalPoint)
                {
                    case "-10":
                        _dPrice = Convert.ToDecimal(Price);
                        if (_dPrice != null)
                        {

                            if (RoundType.ToUpper().Trim() == "ROUND")
                            {
                                _dPrice = Math.Round(Convert.ToDecimal(_dPrice), 0);
                                if (Convert.ToDecimal(_dPrice) % 10 < Convert.ToDecimal(5))
                                {
                                    _dPrice = Math.Floor(Convert.ToDecimal(_dPrice / 10)) * 10;
                                }
                                else
                                {
                                    _dPrice = (Math.Floor(Convert.ToDecimal(_dPrice / 10)) * 10) + 10;
                                }
                            }
                            else if (RoundType.ToUpper().Trim() == "CEIL")
                            {
                                if (_dPrice % 10 != 0)
                                {
                                    _dPrice = (Math.Floor(Convert.ToDecimal(Convert.ToDecimal(_dPrice) / 10)) * 10) + 10;
                                }
                            }
                            else if (RoundType.ToUpper().Trim() == "FLOOR")
                            {
                                if (_dPrice % 10 != 0)
                                {
                                    _dPrice = Math.Floor(Convert.ToDecimal(Convert.ToDecimal(_dPrice) / 10)) * 10;
                                }
                            }
                        }
                        break;
                    case "-5":
                        _dPrice = Convert.ToDecimal(Price);
                        if (_dPrice != null)
                        {
                            if (RoundType.ToUpper().Trim() == "ROUND")
                            {
                                _dPrice = Math.Round(Convert.ToDecimal(_dPrice), 0);
                                if (Convert.ToDecimal(_dPrice) % 5 < Convert.ToDecimal(2.5))
                                {
                                    _dPrice = Math.Floor(Convert.ToDecimal(_dPrice / 5)) * 5;
                                }
                                else
                                {
                                    _dPrice = (Math.Floor(Convert.ToDecimal(_dPrice / 5)) * 5) + 5;
                                }
                            }
                            else if (RoundType.ToUpper().Trim() == "CEIL")
                            {
                                _dPrice = (Math.Floor(Convert.ToDecimal(Convert.ToDecimal(_dPrice) / 5)) * 5) + 5;
                            }
                            else if (RoundType.ToUpper().Trim() == "FLOOR")
                            {
                                _dPrice = Math.Floor(Convert.ToDecimal(Convert.ToDecimal(_dPrice) / 5)) * 5;
                            }
                        }
                        break;
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                        _dPrice = GetRoundTypeValue(RoundType, Price, Convert.ToInt32(DecimalPoint.Trim()));
                        if (_dPrice != null)
                        {
                            _dPrice = Convert.ToDecimal(_dPrice);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception Ex)
            {
                _dPrice = null;
            }
            return _dPrice;
        }
        public decimal? GetRoundTypeValue(string RoundType, string _sPrice, int DecimalPoint)
        {
            decimal? price = null;
            try
            {
                if (RoundType.ToUpper().Trim() == "ROUND")
                {
                    price = Math.Round(Convert.ToDecimal(_sPrice), DecimalPoint);
                }
                else if (RoundType.ToUpper().Trim() == "CEIL")
                {
                    price = Convert.ToDecimal(GetRoundFuntion(Convert.ToDouble(_sPrice), DecimalPoint, RoundingDirection.Up));

                }
                else if (RoundType.ToUpper().Trim() == "FLOOR")
                {
                    price = Convert.ToDecimal(GetRoundFuntion(Convert.ToDouble(_sPrice), DecimalPoint, RoundingDirection.Down));

                }

                //string PriceArray = price.ToString().Split(".");
                //if (PriceArray.Length == 1)
                //{
                //    price = Convert.ToDecimal(price.ToString().PadRight(DecimalPoint, "0"));
                //}




            }
            catch (Exception Ex)
            {
                price = null;
            }
            return price;
        }
        public string FormatCurrencyPrice(decimal Price)
        {
            string FormattedPrice = "";
            int DecimalPoint = 2;
            try
            {

                SystemFlag _objsysflag = null;
                _objsysflag = _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysPriceDecimalPoint")).FirstOrDefault();
                if (_objsysflag != null)
                {
                    if (!string.IsNullOrEmpty(_objsysflag.Value.ToString().Trim()))
                    {
                        DecimalPoint = Convert.ToInt32(_objsysflag.Value.ToString().Trim());

                        if (DecimalPoint == -5 || DecimalPoint == -10)
                        {
                            DecimalPoint = 2;
                        }
                    }
                }

                Currency ObjCurrency = GetCurrentCurrency();
                if (ObjCurrency != null)
                {
                    CultureInfo objCultureInfo = new CultureInfo(ObjCurrency.Culture.Trim());
                    objCultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
                    System.Globalization.NumberFormatInfo nfi = objCultureInfo.NumberFormat;
                    nfi.CurrencyDecimalDigits = Convert.ToInt32(DecimalPoint);
                    nfi.NumberDecimalDigits = Convert.ToInt32(DecimalPoint);
                    nfi.NumberDecimalSeparator = ".";
                    FormattedPrice = Convert.ToDouble(Price).ToString("N", nfi).ToString();
                }
            }
            catch (Exception Ex)
            {
                FormattedPrice = "";
            }
            return FormattedPrice;
        }
        public DateTime? ToClientDateTimeZone(DateTime? dt)
        {
            if (dt.HasValue)
            {
                // read the value from session
                //var timeOffSet = HttpContext.Current.Session["timezoneoffset"];

                //if (timeOffSet != null)
                //{
                //    var offset = int.Parse(timeOffSet.ToString());
                //    dt = dt.Value.AddMinutes(-1 * offset);
                //    return dt;
                //}
                // if there is no offset in session return the datetime in server timezone
                return dt.Value.ToLocalTime();
            }
            else
            {
                return dt;
            }
        }
        public string[,] CalculateDiscountValue(decimal OldPrice, decimal DiscountValue, byte DiscountValueType)
        {
            string[,] CalcualteValue = null;
            try
            {
                if (DiscountValueType == 1)
                {
                    decimal newvalue = 0;
                    List<object> PriceList = ConvertPriceAccordingToCurrency(DiscountValue);
                    if (PriceList != null)
                    {
                        DiscountValue = Convert.ToDecimal(PriceList[2]);
                        newvalue = OldPrice - DiscountValue;
                    }
                    // decimal newvalue = OldPrice - DiscountValue;
                    CalcualteValue = new string[1, 2] { { OldPrice.ToString(), newvalue.ToString() } };
                }
                else if (DiscountValueType == 2)
                {
                    decimal newvalue = Convert.ToDecimal(OldPrice - ((OldPrice * DiscountValue) / 100));
                    decimal? _newvalue = ConvertPriceAccordingToRoundType(newvalue);
                    if (_newvalue != null)
                    {
                        CalcualteValue = new string[1, 2] { { OldPrice.ToString(), _newvalue.ToString() } };
                    }
                }
                return CalcualteValue;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string FilterValue(string value)
        {
            if (Convert.ToInt32(value) == ((int)FilterBy.Active))
            {
                return true.ToString();
            }
            else if (Convert.ToInt32(value) == ((int)FilterBy.Inactive))
            {
                return false.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
