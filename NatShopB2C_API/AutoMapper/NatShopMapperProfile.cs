using AutoMapper;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.StoredProcedureModels;
using NatShopB2C.EF.Common.DTO;
using NatShopB2C_API.DTO;
using System.Text;
using Profile = AutoMapper.Profile;

namespace NatShopB2C_API.AutoMapper
{
    public class NatShopMapperProfile : Profile
    {
        public NatShopMapperProfile()
        {
            CreateNatShopB2CMap();
        }   
        private void CreateNatShopB2CMap()
        {
            CreateMap<BrandDTO, Brand>().ReverseMap()
                 .ForMember(x => x.Id, o => o.MapFrom(x => x.Id));


            CreateMap<ProductDTO, Product>().ReverseMap()
                .ForMember(x => x.ProductID, o => o.MapFrom(x => x.Id))
                .ForMember(x => x.ProductVariationID, o => o.MapFrom(x => x.ProductVariations.Select(y => y.Id).FirstOrDefault()))
                .ForMember(x => x.ProductVariationImageID, o => o.MapFrom(x =>  x.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.Id)).FirstOrDefault()))
                .ForMember(x => x.ImageID, o => o.MapFrom(x => x.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.ImageId)).FirstOrDefault()))
                .ForMember(x =>x.ImagePath, o => o.MapFrom(x => x.ProductVariations != null ? x.ProductVariations.SelectMany(y => y.ProductVariationImages.Select(y => y.Image.ImagePath)).FirstOrDefault() : null))
                .ForMember(x =>x.CategoryName, o => o.MapFrom(x => x.Category.CategoryName))
                .ForMember(x =>x.BrandName, o => o.MapFrom(x => x.Brand.BrandName))
                .ForMember(x =>x.StockTypeName, o => o.MapFrom(x => x.StockType.StockTypeName))
                ;


            CreateMap<AddressesDTO, Address>().ReverseMap()
            .ForMember(x => x.Id, o => o.MapFrom(x => x.Id))          
            .ForMember(x => x.UserId, o => o.MapFrom(x => x.UserAddresses.Select(y => y.UserId).FirstOrDefault()))
            .ForMember(x => x.CityName, o=>o.MapFrom(x => x.City.CityName))
            .ForMember(x => x.CountryName, o=>o.MapFrom(x => x.Country.CountryName))
            .ForMember(x => x.StateName, o => o.MapFrom(x =>x.State.StateName))
            ;

            CreateMap<AddressDTO, Address>().ReverseMap()
            .ForMember(x => x.UserId, o => o.MapFrom(x => x.UserAddresses.Select(y => y.UserId).FirstOrDefault()))
            ;
            


            CreateMap<AddressesDTO, UserAddress>().ReverseMap()
                //.ForMember(x => x.UserId, opt => opt.MapFrom(x => x.UserId))
                .ForMember(x => x.Id, o => o.MapFrom(x => x.AddressId))
                ;
            CreateMap<UserDetailDTO, UserDetail>().ReverseMap()
                .ForMember(x => x.UserId, o => o.MapFrom(x => x.UserId))
                
                
                ;
            CreateMap<UserDetailsDTO, UserDetail>().ReverseMap()
                .ForMember(x => x.UserId, o => o.MapFrom(x => x.UserId))
                .ForMember(x => x.ProofTypeName, o => o.MapFrom(x =>x.ProofType.ProofTypeName))
                .ForMember(x => x.UserTypeName, o => o.MapFrom(x => x.UserType.UserTypeName))


                ;

            CreateMap<UserDTO, User>().ReverseMap()
                .ForMember(x => x.UserId, o => o.MapFrom(x => x.UserId))
                
                ;
            CreateMap<CartDTO, Cart>().ReverseMap()
                .ForMember(X => X.Id, o => o.MapFrom(y => y.Id))
                ;
            CreateMap<ProductVarientDTO, ProductVariation>().ReverseMap()
                .ForMember(x => x.Id, o => o.MapFrom(x => x.Id));

            CreateMap<MenuDTO, Menu>().ReverseMap()
                .ForMember(x => x.Id, o => o.MapFrom(x => x.Id));
            //.ForMember(x =>x.CategoryId, o => o.MapFrom(x => x.ParentMenuId));

            CreateMap<CategoryHierarchyDTO, search_CategoryDetailsTree>().ReverseMap()
                .ForMember(x => x.CategoryID, o => o.MapFrom(x => x.CategoryID));
        }

    }
    
}
