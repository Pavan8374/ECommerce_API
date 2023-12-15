using AutoMapper;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
            
        }
    }
}
