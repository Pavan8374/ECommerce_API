using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface IResourceRepository
    {
        public Category GetCategory(int CategoryID);
        public List<ProductVariation> GetTop4PoplarProductVariant(int CategoryID, List<Guid> ExistsProductList = null);

    }
}
