using AutoMapper;
using NatShopB2C.Domain.Models;
using NatShopB2C_API.DTO;
using System.Text;
using Profile = AutoMapper.Profile;

namespace NatShopB2C_API.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
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
                .ForMember(x => x.ProductVariationImageID, o => o.MapFrom(x => x.ProductVariations != null ? x.ProductVariations.Select(y => y.ProductVariationImages.Select(y => y.Id).FirstOrDefault()) : null))
                .ForMember(x => x.ImageID, o => o.MapFrom(x => x.ProductVariations != null ? x.ProductVariations.Select(y => y.ProductVariationImages.Select(y => y.ImageId).FirstOrDefault()) : null))

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
                .ForMember(x => x.UserId, o => o.MapFrom(x => x.UserId));

        }

    }
    
}
