namespace NatShopB2C_API.DTO
{
    public class MenuDTO
    {
        public int Id { get; set; }
        public string? MenuName { get; set; }
        public string? Caption { get; set; }
        //public string Key { get; set; }
        //public Nullable<short> Order { get; set; }
        public string Url { get; set; }
        //public Nullable<short> Level { get; set; }
        //public string Type { get; set; }
        public string? ImagePath { get; set; }

        //public Nullable<int> ParentMenuID { get; set; }
        //public Nullable<bool> IsActive { get; set; }
        //public Nullable<bool> IsDelete { get; set; }
        //public Nullable<System.Guid> CreatedBy { get; set; }
        //public Nullable<System.Guid> ModifiedBy { get; set; }
        //public Nullable<System.DateTime> CreateDate { get; set; }
        //public Nullable<System.DateTime> ModifiedDate { get; set; }

        public List<MenuDTO> SubMenu { get; set; }
    }
}
