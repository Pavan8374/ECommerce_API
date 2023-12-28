using AutoMapper;
using NatShopB2C.Domain.DTO;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using NatShopB2C.EF.Common.DTO;
using NatShopB2C.EF.Common.DTO.ProdutDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Profile = AutoMapper.Profile;

namespace NatShopB2C.EF.AutoMapper
{
    public class EFMapperProfile : Profile
    {
        public EFMapperProfile()
        {
            CreateNatShopB2CMap();
        }
        private void CreateNatShopB2CMap() 
        {
            CreateMap<CategoryHierarchyDTO, Category>().ReverseMap()
                 .ForMember(x => x.CategoryID, o => o.MapFrom(x => x.Id))
                 .ForMember(x => x.IsParentActive, o => o.MapFrom(x =>x.ParentCategory.IsActive))
                 .ForMember(x => x.IsParentDelete, o => o.MapFrom(x =>x.ParentCategory.IsDelete))
                 .ForMember(dest => dest.SubCategory, opt => opt.Ignore());
            CreateMap<GlobalSearchDTO, search_ProductPopup>().ReverseMap()
                .ForMember(x => x.ID, o => o.MapFrom(x => x.ID));
            CreateMap<select_Slider_NewProduct, Product>().ReverseMap()
                .ForMember(x => x.ProductID, o => o.MapFrom(x => x.Id))
                .ForMember(x => x.ProductVariationID, o => o.MapFrom(x => x.ProductVariations.Select(y => y.Id).FirstOrDefault()))
                .ForMember(x => x.ProductVariationImageID, o => o.MapFrom(x => x.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.Id)).FirstOrDefault()))
                .ForMember(x => x.ImageID, o => o.MapFrom(x => x.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.ImageId)).FirstOrDefault()))
                .ForMember(x => x.ImagePath, o => o.MapFrom(x => x.ProductVariations != null ? x.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.Image.ImagePath)).FirstOrDefault() : null))
                .ForMember(x => x.CategoryName, o => o.MapFrom(x => x.Category.CategoryName))
                .ForMember(x => x.BrandName, o => o.MapFrom(x => x.Brand.BrandName))
                .ForMember(x => x.Caption, o => o.MapFrom(x => x.ProductVariations.Select(y => y.Caption)))
                
                ;
            CreateMap<select_Slider_NewProduct, NewProdcutDTO>().ReverseMap()
                .ForMember(x => x.ProductID, o => o.MapFrom(x => x.ProductID));
            CreateMap<select_Slider_UpCommingProduct, UpCommingProductDTO>().ReverseMap()
                .ForMember(x => x.ProductID, o => o.MapFrom(x => x.ProductID));
            CreateMap<select_Slider_PopularProduct, PopularProductDTO>().ReverseMap()
                .ForMember(x => x.ProductID, o => o.MapFrom(x => x.ProductID));
        }
    }
}
