﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Models
{
    public partial class FeedbackAction
    {
        public FeedbackAction()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string? ActionName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
