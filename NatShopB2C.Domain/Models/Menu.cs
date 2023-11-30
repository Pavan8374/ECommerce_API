using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string? MenuName { get; set; }
        public string? Caption { get; set; }
        public string? Key { get; set; }
        public short? Order { get; set; }
        public string? Url { get; set; }
        public short? Level { get; set; }
        public string? Type { get; set; }
        public string? ImagePath { get; set; }
        public int? ParentMenuId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
