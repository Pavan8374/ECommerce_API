using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C_API.AccountModels;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/Product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        protected Response response;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
            this.response = new();
        }

        [HttpPost]
        [Route("UpsertProduct")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> UpsertProduct(ProductDTO DTO)
        {
            try
            {
                if (DTO == null)
                {
                    return NotFound();
                }
                var obj = _mapper.Map<Product>(DTO);

                if (DTO.ProductID == null || DTO.ProductID == "")
                {
                    response.Result = await _productService.AddProduct(obj);
                    response.StatusCode = System.Net.HttpStatusCode.Created;
                    return Ok(response);
                }
                else
                {
                    response.Result = await _productService.UpdateProduct(obj);
                    response.StatusCode = System.Net.HttpStatusCode.NoContent;
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpDelete]
        [Route("DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> DeleteProduct(Guid id)
        {
            try
            {

                var product = await _productService.GetProduct(id);
                if (product == null)
                {
                    return NotFound();
                }
                await _productService.DeleteProduct(product);
                response.StatusCode = System.Net.HttpStatusCode.NoContent;
                response.IsSuccess = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpGet]
        [Route("GetProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetProducts()
        {
            try
            {
                var products = await _productService.GetProducts();
                if (products == null)
                {
                    return NotFound();
                }
                var list = _mapper.Map<List<ProductDTO>>(products);
                response.Result = list;
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpGet]
        [Route("GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetProduct(Guid? id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var product = await _productService.GetProduct(id);
                if (product == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<ProductDTO>(product);
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpPost]
        [Route("UpsertProductVarient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> UpsertProductVarient(ProductVarientDTO DTO)
        {
            try
            {
                if (DTO == null)
                {
                    return NotFound();
                }
                var obj = _mapper.Map<ProductVariation>(DTO);

                if (DTO.Id == null)
                {
                    response.Result = await _productService.AddProductVarient(obj);
                    response.StatusCode = System.Net.HttpStatusCode.Created;
                    return Ok(response);
                }
                else
                {
                    //response.Result = await _productService.UpdateProduct(obj);
                    response.StatusCode = System.Net.HttpStatusCode.NoContent;
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }

        [HttpGet]
        [Route("GetProductsByFilterOptions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetProductsByFilterOptions(int? Start, int? End, string? ProductID, string? BrandID, string? CategoryID, string? UsageTypeID, string? Keyword, string? SpecificationValueList, string? DiscountIDList, decimal? MinPrice, decimal? MaxPrice, string? OrderColumn, bool? IsAscending)
        {
            try
            {
                var product = await _productService.GetProductsByFilterOptions(Start, End, ProductID, BrandID, CategoryID, UsageTypeID, Keyword, SpecificationValueList, DiscountIDList, MinPrice, MaxPrice, OrderColumn, IsAscending);
                if (product == null)
                {
                    return NotFound();
                }
                response.Result = product;
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }

        [HttpGet]
        [Route("GetProductByFilterOption")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetProductByFilterOption(string ID)
        {
            try
            {
                var product = await _productService.GetProductByFilterOption(ID);
                if (product == null)
                {
                    return NotFound();
                }
                response.Result = product;
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }

        //[HttpGet]
        //[Route("GetProduct")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<Response>> GetProduct(Guid? ProductVariationID)
        //{
        //    try
        //    {
        //        string ProductDiscountID = "", PriceID = "", ProductVariantPriceID = "", variantimagepath = "";
        //        string ProductVariationImageID = "", ImageID = "", ProductStockStatus = "", productdefaultdesc = "";
        //        string ProductPrice = "", UnitCode = "", Quantity = "";
        //        bool IsImageZoom = true, IsOutofStock = false, IsPriceVisiable = true;


        //        if (ProductVariationID != null)
        //        {
        //            ProductDetailDTO _objProduct = new ProductDetailDTO();
        //            _objProduct.ProductImages = new List<ProductImageDTO>();
        //            _objProduct.ProductSpecification = new List<ProductSpecificationDTO>();
        //            _objProduct.OtherPack = new List<ProductOtherPackDTO>();


        //            ProductVariation _objProductVariant = await _pc.GetProductVarientsByProductVarientID(ProductVariationID);

        //            if (_objProductVariant != null && _objProductVariant.Product.Brand.IsActive == true && _objProductVariant.Product.Brand.IsDelete == false && _objProductVariant.Product.Category.IsActive == true && _objProductVariant.Product.Category.IsDelete == false)
        //            {
        //                ProductDiscount objProductDiscount = _objProductVariant.Product.ProductDiscounts.Where(x => x.ProductId.Equals(_objProductVariant.ProductId)).FirstOrDefault();
        //                if (objProductDiscount != null)
        //                {
        //                    ProductDiscountID = _ac.Encrypt(objProductDiscount.Id.ToString());
        //                }

        //                #region Product General Settings

        //                SystemFlag objsysflag = null;
        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysIsEnableImageZoomOption")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsImageZoom = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }

        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowPrice")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsPriceVisiable = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }

        //                bool IsShowAddtoCart = false;
        //                bool IsShowBuy = false;

        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName.Equals("SysShowAddToCartButton")).AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsShowAddtoCart = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }

        //                objsysflag = await _db.SystemFlags.Where(x => x.SystemFlagName == "SysShowBuyButton").AsNoTracking().FirstOrDefaultAsync();
        //                if (objsysflag != null)
        //                {
        //                    if (!string.IsNullOrEmpty(objsysflag.Value))
        //                    {
        //                        IsShowBuy = Convert.ToBoolean(objsysflag.Value);
        //                    }
        //                }
        //                #endregion


        //                decimal? VariantPrice = null;
        //                ProductVariationPrice objVarientPrice = _objProductVariant.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
        //                if (objVarientPrice != null)
        //                {
        //                    VariantPrice = objVarientPrice.Price.Price1;
        //                    PriceID = objVarientPrice.Price.Id.ToString();
        //                    ProductVariantPriceID = objVarientPrice.Id.ToString();
        //                }

        //                if (IsPriceVisiable)
        //                {
        //                    ProductPrice = _pc.CalculateDiscountOnProduct(_objProductVariant.Product, true, VariantPrice);
        //                    ProductVariationPrice objProductVariationPrice = _objProductVariant.ProductVariationPrices.Where(x => x.IsDefaultPrice == true).FirstOrDefault();
        //                    if (objProductVariationPrice != null)
        //                    {
        //                        if (objProductVariationPrice.Price != null)
        //                        {
        //                            UnitCode = "[ " + objProductVariationPrice.Price.Quantity + " " + _objProductVariant.Product.Unit.UnitCode + " ]";
        //                        }
        //                    }
        //                }

        //                if (_objProductVariant.ProductVariationImages.Count > 0)
        //                {
        //                    ProductVariationImage objVarientImage = _objProductVariant.ProductVariationImages.Where(x => x.ImageOrderNo == 0).FirstOrDefault();
        //                    if (objVarientImage != null)
        //                    {
        //                        variantimagepath = objVarientImage.Image.ImagePath.Replace("~", "");
        //                        variantimagepath = objVarientImage.Image.ImagePath;
        //                        ProductVariationImageID = objVarientImage.Id.ToString();
        //                        ImageID = objVarientImage.Image.Id.ToString();
        //                    }
        //                }

        //                int AvailableStockQty = 0;
        //                IsOutofStock = _pc.IsProductOutofStock(_objProductVariant.Product, 1, out AvailableStockQty);
        //                if (!IsOutofStock)
        //                {
        //                    ProductStockStatus = "In Stock";
        //                }
        //                else
        //                {
        //                    ProductStockStatus = "Out of Stock";
        //                }

        //                if (IsShowAddtoCart == true || IsShowBuy == true)
        //                {

        //                }


        //                #region Get Product Images
        //                List<ProductImageDTO> _objProductImages = _pc.GetProductImagesForClient(ProductVariationID);
        //                if (_objProductImages != null)
        //                {
        //                    foreach (ProductImageDTO item in _objProductImages)
        //                    {
        //                        if (File.Exists(HttpContext.Current.Server.MapPath("~/" + item.LargeImagePath)))
        //                        {
        //                            Image img = Image.FromFile(HttpContext.Current.Server.MapPath("~/" + item.LargeImagePath));
        //                            if (img.Width > 500 && img.Height > 500)
        //                            {
        //                                item.IsImageZoom = true;
        //                            }
        //                            else
        //                            {
        //                                item.IsImageZoom = false;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            item.IsImageZoom = false;
        //                        }
        //                    }
        //                    if (_objProductImages.Count() > 0)
        //                    {
        //                        _objProduct.ProductImages.AddRange(_objProductImages);
        //                    }
        //                }
        //                #endregion

        //                #region  Product Description
        //                if (!string.IsNullOrEmpty(_objProductVariant.Product.Description))
        //                {
        //                    productdefaultdesc = _objProductVariant.Product.Description.ToString();
        //                }
        //                #endregion

        //                #region Product Specification

        //                List<ProductSpecificationDTO> _objProductSpecification = _pc.GetAllProductSpecificationByProductID(_objProductVariant.Product.Id);
        //                if (_objProductSpecification != null)
        //                {
        //                    if (_objProductSpecification.Count() > 0)
        //                    {
        //                        _objProduct.ProductSpecification.AddRange(_objProductSpecification);
        //                    }
        //                }
        //                #endregion

        //                #region Product Other Pack

        //                List<ProductVariationPrice> objProductVarienPrice = _pc.GetProductVarientPriceByProductVarientID(ProductVariationID, "1");
        //                if (objProductVarienPrice != null)
        //                {
        //                    if (objProductVarienPrice.Count() > 0)
        //                    {
        //                        List<ProductOtherPackDTO> objOtherPack = new List<ProductOtherPackDTO>();
        //                        string UnitName = "", Price = "";
        //                        foreach (ProductVariationPrice PP in objProductVarienPrice)
        //                        {
        //                            if (PP.Price.Caption != null)
        //                                UnitName = PP.Price.Caption.ToString();
        //                            else
        //                                UnitName = PP.Price.Quantity + " " + PP.Price.Unit.UnitName.ToString().Trim() + " Pack";

        //                            List<object> PriceList = _bc.ConvertPriceAccordingToCurrency(PP.Price.Price1);
        //                            if (PriceList != null)
        //                            {
        //                                Price = "<span class='currency-icon'><i class='" + PriceList[0] + "'></i></span><span>" + PriceList[1] + "</span>";
        //                            }
        //                            objOtherPack.Add(new ProductOtherPackDTO()
        //                            {
        //                                ProductVariantPriceID = _ac.Encrypt(PP.Id.ToString()),
        //                                ProductID = _ac.Encrypt(PP.ProductVariation.ProductId.ToString()),
        //                                ProductVariantID = _ac.Encrypt(PP.ProductVariation.Id.ToString()),
        //                                PriceID = _ac.Encrypt(PP.PriceId.ToString()),
        //                                UnitID = PP.Price.UnitId,
        //                                UnitCode = PP.Price.Unit.UnitCode.ToString().Trim(),
        //                                UnitName = UnitName,
        //                                Quantity = PP.Price.Quantity,
        //                                Price = Price,
        //                                IsBasePrice = Convert.ToBoolean(PP.IsBasePrice),
        //                                IsDefaultPrice = Convert.ToBoolean(PP.IsDefaultPrice),
        //                                LinkUrl = PP.ProductVariation.Product.LinkUrl,
        //                                ProductPriceID = _ac.Encrypt(PP.PriceId.ToString()),
        //                                IsOutofStock = IsOutofStock,
        //                                IsShowAddToCart = IsShowAddtoCart,
        //                                IsShowBuy = IsShowBuy
        //                            });
        //                            _objProduct.OtherPack.AddRange(objOtherPack);
        //                        }
        //                    }
        //                }

        //                #endregion

        //                _objProduct.ProductID = _objProductVariant.Product.Id;
        //                _objProduct.ProductVariationID = _objProductVariant.Id;
        //                _objProduct.ProductVariationImageID = ProductVariationImageID;
        //                _objProduct.ImageID = ImageID;
        //                _objProduct.ProductVariantPriceID = ProductVariantPriceID;
        //                _objProduct.PriceID = PriceID;
        //                _objProduct.ProductName = _objProductVariant.Product.ProductName;
        //                _objProduct.BrandName = _objProductVariant.Product.Brand.BrandName;
        //                _objProduct.BrandUrl = "/Products/B" + _ac.Encrypt(_objProductVariant.Product.Brand.Id.ToString());
        //                _objProduct.Caption = _objProductVariant.Caption;
        //                _objProduct.ProductCode = _objProductVariant.Product.ProductCode;
        //                _objProduct.Price = ProductPrice;
        //                _objProduct.UnitCode = UnitCode;
        //                _objProduct.ImagePath = variantimagepath;
        //                _objProduct.Rating = _objProductVariant.Rating;
        //                _objProduct.StockStatus = ProductStockStatus;
        //                _objProduct.Description = productdefaultdesc;
        //                _objProduct.Quantity = Quantity;
        //                _objProduct.IsShowAddtoCart = IsShowAddtoCart;
        //                _objProduct.IsShowBuy = IsShowBuy;

        //                return Ok(_objProduct);
        //            }
        //            else
        //            {
        //                return null;
        //            }
        //        }
        //        else
        //        {
        //            return null;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
