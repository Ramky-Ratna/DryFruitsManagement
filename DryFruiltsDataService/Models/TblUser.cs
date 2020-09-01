using System;
using System.Collections.Generic;

namespace DryFruiltsDataService.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblPost = new HashSet<TblPost>();
        }

        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserMobileNumber { get; set; }
        public string UserPassword { get; set; }
        public bool? UserIsActive { get; set; }
        public DateTime? UserCreated { get; set; }
        public DateTime? UserUpdated { get; set; }

        public virtual ICollection<TblPost> TblPost { get; set; }
    }
}
