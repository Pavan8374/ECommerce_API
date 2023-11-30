using NatShopB2C.Domain.Models.NatShopB2CAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            Carts = new HashSet<Cart>();
            Feedbacks = new HashSet<Feedback>();
            HelpfulProductReviews = new HashSet<HelpfulProductReview>();
            InquiryResponderUsers = new HashSet<Inquiry>();
            InquiryUsers = new HashSet<Inquiry>();
            PersonAccounts = new HashSet<PersonAccount>();
            ProductDiscounts = new HashSet<ProductDiscount>();
            ProductReviewUsers = new HashSet<ProductReview>();
            ProductReviewVarifiedByNavigations = new HashSet<ProductReview>();
            Smsqueues = new HashSet<Smsqueue>();
            SystemFlags = new HashSet<SystemFlag>();
            Tokens = new HashSet<Token>();
            UserAddresses = new HashSet<UserAddress>();
            UserContacts = new HashSet<UserContact>();
            UserFlagValues = new HashSet<UserFlagValue>();
            UserLogs = new HashSet<UserLog>();
            UserPropertyValues = new HashSet<UserPropertyValue>();
            UserSubscriptions = new HashSet<UserSubscription>();
            UsersOauthAccounts = new HashSet<UsersOauthAccount>();
        }

        public Guid UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
        public int? ProofTypeId { get; set; }
        public string? ProofNo { get; set; }
        public string? ProfilePicPath { get; set; }
        public short? UserTypeId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ProofType? ProofType { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual UserType? UserType { get; set; }
        public virtual UsersOauthDatum? UsersOauthDatum { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<HelpfulProductReview> HelpfulProductReviews { get; set; }
        public virtual ICollection<Inquiry> InquiryResponderUsers { get; set; }
        public virtual ICollection<Inquiry> InquiryUsers { get; set; }
        public virtual ICollection<PersonAccount> PersonAccounts { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
        public virtual ICollection<ProductReview> ProductReviewUsers { get; set; }
        public virtual ICollection<ProductReview> ProductReviewVarifiedByNavigations { get; set; }
        public virtual ICollection<Smsqueue> Smsqueues { get; set; }
        public virtual ICollection<SystemFlag> SystemFlags { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<UserFlagValue> UserFlagValues { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual ICollection<UserPropertyValue> UserPropertyValues { get; set; }
        public virtual ICollection<UserSubscription> UserSubscriptions { get; set; }
        public virtual ICollection<UsersOauthAccount> UsersOauthAccounts { get; set; }
    }
}
