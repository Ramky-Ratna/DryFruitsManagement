using System;
using System.Collections.Generic;

namespace DataService.Models
{
    public partial class TblAdmin
    {
        public TblAdmin()
        {
            TblNotifications = new HashSet<TblNotifications>();
        }

        public int AdminId { get; set; }
        public string AdminEmail { get; set; }
        public string AdminMobileNumber { get; set; }
        public string AdminPassword { get; set; }
        public bool? AdminIsActive { get; set; }
        public DateTime? AdminCreated { get; set; }
        public DateTime? AdminUpdated { get; set; }

        public virtual ICollection<TblNotifications> TblNotifications { get; set; }
    }
}
