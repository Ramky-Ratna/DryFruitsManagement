using System;
using System.Collections.Generic;

namespace DataService.Models
{
    public partial class TblPost
    {
        public TblPost()
        {
            TblComments = new HashSet<TblComments>();
            TblLike = new HashSet<TblLike>();
        }

        public int PostId { get; set; }
        public string PostText { get; set; }
        public byte[] PostImage { get; set; }
        public int? PostCreatedBy { get; set; }
        public DateTime? PostCreatedOn { get; set; }
        public DateTime? PostUpdatedOn { get; set; }

        public virtual TblUser PostCreatedByNavigation { get; set; }
        public virtual ICollection<TblComments> TblComments { get; set; }
        public virtual ICollection<TblLike> TblLike { get; set; }
    }
}
